namespace GreenHouse_Horigome_Tagalog
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startHumidity = new System.Windows.Forms.NumericUpDown();
            this.startTemperature = new System.Windows.Forms.NumericUpDown();
            this.startSoilMoisture = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.humLabel = new System.Windows.Forms.Label();
            this.humBar = new System.Windows.Forms.ProgressBar();
            this.tempLabel = new System.Windows.Forms.Label();
            this.tempBar = new System.Windows.Forms.ProgressBar();
            this.soilLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.soilBar = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pumpLabel = new System.Windows.Forms.Label();
            this.pumpBar = new System.Windows.Forms.ProgressBar();
            this.fanLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.fanBar = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.tickLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSoilMoisture)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, -140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GreenHouse_Horigome_Tagalog.Properties.Resources.green_house__1_;
            this.pictureBox1.Location = new System.Drawing.Point(509, -41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 469);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(20, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "GREENHOUSE SIMULATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(20, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "A Mamdani Fuzzy Logic that regulates a Greenhouse";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.startHumidity);
            this.groupBox1.Controls.Add(this.startTemperature);
            this.groupBox1.Controls.Add(this.startSoilMoisture);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(22, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 79);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT INITIAL PARAMETERS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(354, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Humidity (%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(185, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Air Temperature (C)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soil Moisture (%)";
            // 
            // startHumidity
            // 
            this.startHumidity.DecimalPlaces = 1;
            this.startHumidity.Location = new System.Drawing.Point(357, 38);
            this.startHumidity.Name = "startHumidity";
            this.startHumidity.Size = new System.Drawing.Size(145, 22);
            this.startHumidity.TabIndex = 2;
            // 
            // startTemperature
            // 
            this.startTemperature.DecimalPlaces = 1;
            this.startTemperature.Location = new System.Drawing.Point(188, 38);
            this.startTemperature.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.startTemperature.Name = "startTemperature";
            this.startTemperature.Size = new System.Drawing.Size(141, 22);
            this.startTemperature.TabIndex = 1;
            // 
            // startSoilMoisture
            // 
            this.startSoilMoisture.DecimalPlaces = 1;
            this.startSoilMoisture.Location = new System.Drawing.Point(22, 38);
            this.startSoilMoisture.Name = "startSoilMoisture";
            this.startSoilMoisture.Size = new System.Drawing.Size(138, 22);
            this.startSoilMoisture.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.humLabel);
            this.groupBox2.Controls.Add(this.humBar);
            this.groupBox2.Controls.Add(this.tempLabel);
            this.groupBox2.Controls.Add(this.tempBar);
            this.groupBox2.Controls.Add(this.soilLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.soilBar);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(22, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 191);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CURRENT SENSOR READINGS (GREENHOUSE)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(18, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Humidity (%)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(18, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Air Temperature (C)";
            // 
            // humLabel
            // 
            this.humLabel.AutoSize = true;
            this.humLabel.ForeColor = System.Drawing.Color.Maroon;
            this.humLabel.Location = new System.Drawing.Point(469, 133);
            this.humLabel.Name = "humLabel";
            this.humLabel.Size = new System.Drawing.Size(35, 13);
            this.humLabel.TabIndex = 13;
            this.humLabel.Text = "0.0 %";
            this.humLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // humBar
            // 
            this.humBar.Location = new System.Drawing.Point(21, 149);
            this.humBar.Name = "humBar";
            this.humBar.Size = new System.Drawing.Size(483, 23);
            this.humBar.TabIndex = 11;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.ForeColor = System.Drawing.Color.Maroon;
            this.tempLabel.Location = new System.Drawing.Point(469, 79);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(32, 13);
            this.tempLabel.TabIndex = 10;
            this.tempLabel.Text = "0.0 C";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tempBar
            // 
            this.tempBar.Location = new System.Drawing.Point(21, 95);
            this.tempBar.Maximum = 60;
            this.tempBar.Name = "tempBar";
            this.tempBar.Size = new System.Drawing.Size(483, 23);
            this.tempBar.TabIndex = 8;
            // 
            // soilLabel
            // 
            this.soilLabel.AutoSize = true;
            this.soilLabel.ForeColor = System.Drawing.Color.Maroon;
            this.soilLabel.Location = new System.Drawing.Point(469, 26);
            this.soilLabel.Name = "soilLabel";
            this.soilLabel.Size = new System.Drawing.Size(35, 13);
            this.soilLabel.TabIndex = 7;
            this.soilLabel.Text = "0.0 %";
            this.soilLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(18, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Soil Moisture (%)";
            // 
            // soilBar
            // 
            this.soilBar.Location = new System.Drawing.Point(21, 42);
            this.soilBar.Name = "soilBar";
            this.soilBar.Size = new System.Drawing.Size(483, 23);
            this.soilBar.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.pumpLabel);
            this.groupBox3.Controls.Add(this.pumpBar);
            this.groupBox3.Controls.Add(this.fanLabel);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.fanBar);
            this.groupBox3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(22, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 129);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACTUATOR SETTINGS (MAMDANI FUZZY LOGIC)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(18, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Water Pump Duration (mins)";
            // 
            // pumpLabel
            // 
            this.pumpLabel.AutoSize = true;
            this.pumpLabel.ForeColor = System.Drawing.Color.Maroon;
            this.pumpLabel.Location = new System.Drawing.Point(454, 79);
            this.pumpLabel.Name = "pumpLabel";
            this.pumpLabel.Size = new System.Drawing.Size(50, 13);
            this.pumpLabel.TabIndex = 10;
            this.pumpLabel.Text = "0.0 mins";
            this.pumpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pumpBar
            // 
            this.pumpBar.Location = new System.Drawing.Point(21, 95);
            this.pumpBar.Maximum = 200;
            this.pumpBar.Name = "pumpBar";
            this.pumpBar.Size = new System.Drawing.Size(483, 23);
            this.pumpBar.TabIndex = 8;
            // 
            // fanLabel
            // 
            this.fanLabel.AutoSize = true;
            this.fanLabel.ForeColor = System.Drawing.Color.Maroon;
            this.fanLabel.Location = new System.Drawing.Point(469, 26);
            this.fanLabel.Name = "fanLabel";
            this.fanLabel.Size = new System.Drawing.Size(35, 13);
            this.fanLabel.TabIndex = 7;
            this.fanLabel.Text = "0.0 %";
            this.fanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Maroon;
            this.label18.Location = new System.Drawing.Point(18, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Exhaust Fan Speed (%)";
            // 
            // fanBar
            // 
            this.fanBar.Location = new System.Drawing.Point(21, 42);
            this.fanBar.Name = "fanBar";
            this.fanBar.Size = new System.Drawing.Size(483, 23);
            this.fanBar.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.resetButton);
            this.groupBox4.Controls.Add(this.startButton);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox4.Location = new System.Drawing.Point(580, 402);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 119);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CONTROL PANEL";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(19, 69);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(286, 35);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "RESET TO INPUTS";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(19, 23);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(286, 35);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "RUN SIMULATION";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(454, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "0.0 mins";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(469, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "0.0 %";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Maroon;
            this.statusLabel.Location = new System.Drawing.Point(577, 530);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLabel.Size = new System.Drawing.Size(45, 13);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Status: ";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tickLabel
            // 
            this.tickLabel.AutoSize = true;
            this.tickLabel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickLabel.ForeColor = System.Drawing.Color.Maroon;
            this.tickLabel.Location = new System.Drawing.Point(20, 530);
            this.tickLabel.Name = "tickLabel";
            this.tickLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tickLabel.Size = new System.Drawing.Size(65, 13);
            this.tickLabel.TabIndex = 18;
            this.tickLabel.Text = "Tick Speed:";
            this.tickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label8.Location = new System.Drawing.Point(467, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Horigome - Tagalog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(923, 557);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tickLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Greenhouse Simulator - Mamdani Fuzzy Logic";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSoilMoisture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown startSoilMoisture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown startHumidity;
        private System.Windows.Forms.NumericUpDown startTemperature;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar soilBar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label humLabel;
        private System.Windows.Forms.ProgressBar humBar;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.ProgressBar tempBar;
        private System.Windows.Forms.Label soilLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label pumpLabel;
        private System.Windows.Forms.ProgressBar pumpBar;
        private System.Windows.Forms.Label fanLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ProgressBar fanBar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label tickLabel;
        private System.Windows.Forms.Label label8;
    }
}

