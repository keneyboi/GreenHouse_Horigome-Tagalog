using System;
using System.Drawing;
using System.Windows.Forms;

namespace GreenHouse_Horigome_Tagalog
{
    public partial class Form1 : Form
    {   
        private double soilMoisture;
        private double temperature;
        private double humidity;

        private double fanSpeed = 0.0;
        private double pumpDuration = 0.0;


        private double prevSoil, prevTemp, prevHum;
        private int stableTickCount = 0;
        private const int RequiredStableTicks = 10;
        private const double StabilityTolerance = 0.025;

        private System.Windows.Forms.Timer simTimer;
        private bool isRunning = false;
        private int tickCount = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeSimulation();
        }
 
        private void UpdateDisplay()
        {
            soilLabel.Text = $"{soilMoisture:F1}%";
            soilBar.Value = Math.Min(100, Math.Max(0, (int)soilMoisture));

            tempLabel.Text = $"{temperature:F1}°C";
            tempBar.Value = Math.Min(60, Math.Max(0, (int)temperature));

            humLabel.Text = $"{humidity:F1}%";
            humBar.Value = Math.Min(100, Math.Max(0, (int)humidity));

            fanLabel.Text = $"{fanSpeed:F1}%";
            fanBar.Value = Math.Min(100, Math.Max(0, (int)fanSpeed));

            pumpLabel.Text = $"{pumpDuration:F2} mins";
            pumpBar.Value = Math.Min(200, Math.Max(0, (int)(pumpDuration * 10)));
        }

        private void InitializeSimulation()
        {
            // Set up the timer
            simTimer = new System.Windows.Forms.Timer();
            simTimer.Interval = 100; // 100ms per closed-loop step
            simTimer.Tick += SimulationTick;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;
            if (isRunning)
            {
                simTimer.Start();
                startButton.Text = "PAUSE SIMULATION";
                statusLabel.Text = "Status: Regulating toward equilibrium.";
                SetInputsEnabled(false);
            }
            else
            {
                simTimer.Stop();
                startButton.Text = "RESUME SIMULATION";
                statusLabel.Text = "Status: Simulation Paused.";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            simTimer?.Stop();
            isRunning = false;
            startButton.Text = "RUN SIMULATION";
            SetInputsEnabled(true);

            soilMoisture = (double)startSoilMoisture.Value;
            temperature = (double)startTemperature.Value;
            humidity = (double)startHumidity.Value;

            prevSoil = soilMoisture;
            prevTemp = temperature;
            prevHum = humidity;

            stableTickCount = 0;
            tickCount = 0;

            (fanSpeed, pumpDuration) = MamdaniAgent(soilMoisture, temperature, humidity);
            pumpDuration = 0.0;
            fanSpeed = 0.0;
            UpdateDisplay();

            statusLabel.Text = "Status: Initialized to configured setpoints.";
            tickLabel.Text = "Ticks: 0";
        }


        private void SetInputsEnabled(bool enabled)
        {
            startSoilMoisture.Enabled = enabled;
            startTemperature.Enabled = enabled;
            startHumidity.Enabled = enabled;
        }

        private void SimulationTick(object sender, EventArgs e)
        {
            tickCount++;
            tickLabel.Text = $"Ticks: {tickCount}";

            // 1. Evaluate Pure Mamdani Agent
            (fanSpeed, pumpDuration) = MamdaniAgent(soilMoisture, temperature, humidity);

            // 2. Physical Microclimate Coupling
            double outsideAmbientTemp = 20.0; // Outside ambient thermal anchor
            double outsideAmbientHum = 70.0; // Outside ambient humidity anchor

            // Continuous background heat trap (solar greenhouse effect)
            double solarGreenhouseHeat = 0.05;

            // Passive envelope drift (structural heat/humidity loss toward outside)
            double passiveTempDrift = (outsideAmbientTemp - temperature) * 0.02;
            double passiveHumDrift = (outsideAmbientHum - humidity) * 0.02;

            // Active fan ventilation: Replaces greenhouse air with outside ambient
            double activeFanTempChange = (outsideAmbientTemp - temperature) * (fanSpeed / 100.0) * 0.15;
            double activeFanHumChange = (outsideAmbientHum - humidity) * (fanSpeed / 100.0) * 0.15;

            // Evapotranspiration: Continuous evaporation that scales with temperature and current moisture
            double soilEvaporation = 0.025 * (temperature / 20.0) * (soilMoisture / 40.0);
            double plantWaterAddition = (pumpDuration / 20.0) * 0.18;

            // State Integration
            temperature += solarGreenhouseHeat + passiveTempDrift + activeFanTempChange;
            humidity += passiveHumDrift + activeFanHumChange + (soilEvaporation * 0.6);
            soilMoisture += plantWaterAddition - soilEvaporation;

            temperature = Math.Max(10.0, Math.Min(50.0, temperature));
            humidity = Math.Max(20.0, Math.Min(98.0, humidity));
            soilMoisture = Math.Max(0.0, Math.Min(100.0, soilMoisture));

            UpdateDisplay();

            double dSoil = Math.Abs(soilMoisture - prevSoil);
            double dTemp = Math.Abs(temperature - prevTemp);
            double dHum = Math.Abs(humidity - prevHum);

            if (dSoil < StabilityTolerance && dTemp < StabilityTolerance && dHum < StabilityTolerance)
            {
                stableTickCount++;
                if (stableTickCount >= RequiredStableTicks)
                {
                    simTimer.Stop();
                    isRunning = false;
                    startButton.Text = "RUN SIMULATION";
                    SetInputsEnabled(true);
                    statusLabel.Text = $"Status: EQUILIBRIUM REACHED at Tick {tickCount}!";
                    return;
                }
            }
            else
            {
                stableTickCount = 0;
            }

            prevSoil = soilMoisture;
            prevTemp = temperature;
            prevHum = humidity;
        }


        public static (double fanSpeed, double pumpDuration) MamdaniAgent (double soilMoisture, double temperature, double humidity)
        {
            double smDry = TriangularMembership(soilMoisture, -10.0, 0.0, 40.0);
            double smOptimal = TriangularMembership(soilMoisture, 25.0, 40.0, 55.0);
            double smWet = TriangularMembership(soilMoisture, 38.0, 70.0, 110.0);

            double tempLow = TriangularMembership(temperature, -5.0, 12.0, 20.0);
            double tempOptimal = TriangularMembership(temperature, 16.0, 20.0, 24.0);
            double tempHigh = TriangularMembership(temperature, 20.0, 30.0, 70.0);

            double humLow = TriangularMembership(humidity, -5.0, 40.0, 70.0);
            double humOptimal = TriangularMembership(humidity, 55.0, 70.0, 85.0);
            double humHigh = TriangularMembership(humidity, 70.0, 88.0, 110.0);

            // if the temp is low and humidity is high, then the fan should be off
            double fanOff = Math.Min(tempLow, humLow);
            // if the temp is optimal is optimal or temp is low and humidity is optimal, then the fan should be medium
            double fanMedium = Math.Max(tempOptimal, Math.Min(tempLow, humOptimal));
            // if the temp is high and humidity is high, then the fan should be high
            double fanHigh = Math.Max(tempHigh, humHigh);

            // if the soil is wet, then the pump should be off
            double pumpOff = smWet;
            // if the soil is soil is optimal and temp is optimal or humidity is optimal, then the pump should be low
            double pumpLow = Math.Min(smOptimal, Math.Max(tempOptimal, humOptimal));
            // if the soil is dry and temp is low or soil is optimal and the temp is high, then the pump should be medium
            double pumpMedium = Math.Max(Math.Min(smDry, tempLow), Math.Min(smOptimal, tempHigh));
            // if the soil is dry and temp is optimal or temp is high, then the pump should be high
            double pumpHigh = Math.Min(smDry, Math.Max(tempOptimal, tempHigh));

            double fanNum = 0.0, fanDen = 0.0;
            for (double y = 0.0; y <= 100.0; y += 1.0)
            {
                // Calculate the degree of membership for each output fuzzy set
                double outOff = TriangularMembership(y, -5.0, 0.0, 15.0);
                double outMed = TriangularMembership(y, 15.0, 45.0, 75.0);
                double outFast = TriangularMembership(y, 50.0, 100.0, 105.0);

                
                double muFan = Math.Max(Math.Min(fanOff, outOff), Math.Max(Math.Min(fanMedium, outMed), Math.Min(fanHigh, outFast)));

                fanNum += y * muFan;
                fanDen += muFan;
            }
            double crispFan = (fanDen > 0.0) ? (fanNum / fanDen) : 0.0;

            double pumpNum = 0.0, pumpDen = 0.0;
            for (double p = 0.0; p <= 20.0; p += 0.2)
            {
                // Calculate the degree of membership for each output fuzzy set
                double outOff = TriangularMembership(p, -2.0, 0.0, 1.5);
                double outMaint = TriangularMembership(p, 0.5, 1.5, 3.5);
                double outMed = TriangularMembership(p, 3.0, 6.0, 10.0);
                double outLong = TriangularMembership(p, 8.0, 14.0, 20.0);

                double muPump = Math.Max(Math.Min(pumpOff, outOff), Math.Max(Math.Min(pumpLow, outMaint), Math.Max(Math.Min(pumpMedium, outMed), Math.Min(pumpHigh, outLong))));

                pumpNum += p * muPump;
                pumpDen += muPump;
            }
            double crispPump = (pumpDen > 0.0) ? (pumpNum / pumpDen) : 0.0;

            return (crispFan, crispPump);
        }

        public static double TriangularMembership(double x, double a, double b, double c)
        {
            if (x <= a || x >= c) return 0.0;
            if (x == b) return 1.0;
            if (x > a && x < b) return (x - a) / (b - a);
            return (c - x) / (c - b);
        }
    }
}
