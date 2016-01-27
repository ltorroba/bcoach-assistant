namespace bCoach_Assistant.Wizard
{
    partial class CameraConfigurationBallDetection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraConfigurationBallDetection));
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.configBall_iterations = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.configBall_rMin = new System.Windows.Forms.NumericUpDown();
            this.configBall_rMax = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.configBall_gMax = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.configBall_gMin = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.configBall_bMax = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.configBall_bMin = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.configBall_previewFrame = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.configBall_blue = new System.Windows.Forms.Label();
            this.configBall_green = new System.Windows.Forms.Label();
            this.configBall_red = new System.Windows.Forms.Label();
            this.configBall_helper = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.configBall_preview = new System.Windows.Forms.PictureBox();
            this.configBall_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_iterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_rMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_rMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_gMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_gMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_bMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_bMin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_previewFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_helper)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(24, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(856, 50);
            this.label8.TabIndex = 10;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(303, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ball detection configuration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Iterations:";
            // 
            // configBall_iterations
            // 
            this.configBall_iterations.Location = new System.Drawing.Point(83, 75);
            this.configBall_iterations.Name = "configBall_iterations";
            this.configBall_iterations.Size = new System.Drawing.Size(95, 20);
            this.configBall_iterations.TabIndex = 12;
            this.configBall_iterations.ValueChanged += new System.EventHandler(this.configBall_iterations_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Red:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Green:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Blue:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Min:";
            // 
            // configBall_rMin
            // 
            this.configBall_rMin.Location = new System.Drawing.Point(116, 100);
            this.configBall_rMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.configBall_rMin.Name = "configBall_rMin";
            this.configBall_rMin.Size = new System.Drawing.Size(62, 20);
            this.configBall_rMin.TabIndex = 19;
            // 
            // configBall_rMax
            // 
            this.configBall_rMax.Location = new System.Drawing.Point(217, 100);
            this.configBall_rMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.configBall_rMax.Name = "configBall_rMax";
            this.configBall_rMax.Size = new System.Drawing.Size(62, 20);
            this.configBall_rMax.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Max:";
            // 
            // configBall_gMax
            // 
            this.configBall_gMax.Location = new System.Drawing.Point(217, 126);
            this.configBall_gMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.configBall_gMax.Name = "configBall_gMax";
            this.configBall_gMax.Size = new System.Drawing.Size(62, 20);
            this.configBall_gMax.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Max:";
            // 
            // configBall_gMin
            // 
            this.configBall_gMin.Location = new System.Drawing.Point(116, 126);
            this.configBall_gMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.configBall_gMin.Name = "configBall_gMin";
            this.configBall_gMin.Size = new System.Drawing.Size(62, 20);
            this.configBall_gMin.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Min:";
            // 
            // configBall_bMax
            // 
            this.configBall_bMax.Location = new System.Drawing.Point(217, 152);
            this.configBall_bMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.configBall_bMax.Name = "configBall_bMax";
            this.configBall_bMax.Size = new System.Drawing.Size(62, 20);
            this.configBall_bMax.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Max:";
            // 
            // configBall_bMin
            // 
            this.configBall_bMin.Location = new System.Drawing.Point(116, 152);
            this.configBall_bMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.configBall_bMin.Name = "configBall_bMin";
            this.configBall_bMin.Size = new System.Drawing.Size(62, 20);
            this.configBall_bMin.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(83, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Min:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.configBall_previewFrame);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.configBall_blue);
            this.groupBox1.Controls.Add(this.configBall_green);
            this.groupBox1.Controls.Add(this.configBall_red);
            this.groupBox1.Controls.Add(this.configBall_helper);
            this.groupBox1.Location = new System.Drawing.Point(410, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 313);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Helper";
            // 
            // configBall_previewFrame
            // 
            this.configBall_previewFrame.Location = new System.Drawing.Point(406, 287);
            this.configBall_previewFrame.Name = "configBall_previewFrame";
            this.configBall_previewFrame.Size = new System.Drawing.Size(48, 20);
            this.configBall_previewFrame.TabIndex = 5;
            this.configBall_previewFrame.ValueChanged += new System.EventHandler(this.configBall_previewFrame_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(323, 289);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Preview frame:";
            // 
            // configBall_blue
            // 
            this.configBall_blue.AutoSize = true;
            this.configBall_blue.Location = new System.Drawing.Point(330, 54);
            this.configBall_blue.Name = "configBall_blue";
            this.configBall_blue.Size = new System.Drawing.Size(40, 13);
            this.configBall_blue.TabIndex = 3;
            this.configBall_blue.Text = "Blue: --";
            // 
            // configBall_green
            // 
            this.configBall_green.AutoSize = true;
            this.configBall_green.Location = new System.Drawing.Point(322, 36);
            this.configBall_green.Name = "configBall_green";
            this.configBall_green.Size = new System.Drawing.Size(48, 13);
            this.configBall_green.TabIndex = 2;
            this.configBall_green.Text = "Green: --";
            // 
            // configBall_red
            // 
            this.configBall_red.AutoSize = true;
            this.configBall_red.Location = new System.Drawing.Point(331, 20);
            this.configBall_red.Name = "configBall_red";
            this.configBall_red.Size = new System.Drawing.Size(39, 13);
            this.configBall_red.TabIndex = 1;
            this.configBall_red.Text = "Red: --";
            // 
            // configBall_helper
            // 
            this.configBall_helper.Location = new System.Drawing.Point(7, 20);
            this.configBall_helper.Name = "configBall_helper";
            this.configBall_helper.Size = new System.Drawing.Size(309, 287);
            this.configBall_helper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.configBall_helper.TabIndex = 0;
            this.configBall_helper.TabStop = false;
            this.configBall_helper.Click += new System.EventHandler(this.configBall_helper_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.configBall_preview);
            this.groupBox2.Location = new System.Drawing.Point(9, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 209);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // configBall_preview
            // 
            this.configBall_preview.Location = new System.Drawing.Point(7, 19);
            this.configBall_preview.Name = "configBall_preview";
            this.configBall_preview.Size = new System.Drawing.Size(382, 184);
            this.configBall_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.configBall_preview.TabIndex = 0;
            this.configBall_preview.TabStop = false;
            // 
            // configBall_ok
            // 
            this.configBall_ok.Location = new System.Drawing.Point(805, 394);
            this.configBall_ok.Name = "configBall_ok";
            this.configBall_ok.Size = new System.Drawing.Size(75, 23);
            this.configBall_ok.TabIndex = 32;
            this.configBall_ok.Text = "OK";
            this.configBall_ok.UseVisualStyleBackColor = true;
            this.configBall_ok.Click += new System.EventHandler(this.configBall_ok_Click);
            // 
            // CameraConfigurationBallDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 429);
            this.Controls.Add(this.configBall_ok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.configBall_bMax);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.configBall_bMin);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.configBall_gMax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.configBall_gMin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.configBall_rMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.configBall_rMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.configBall_iterations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Name = "CameraConfigurationBallDetection";
            this.Text = "CameraConfigurationBallDetection";
            this.Load += new System.EventHandler(this.CameraConfigurationBallDetection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.configBall_iterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_rMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_rMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_gMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_gMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_bMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_bMin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_previewFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBall_helper)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.configBall_preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown configBall_iterations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown configBall_rMin;
        private System.Windows.Forms.NumericUpDown configBall_rMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown configBall_gMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown configBall_gMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown configBall_bMax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown configBall_bMin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown configBall_previewFrame;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label configBall_blue;
        private System.Windows.Forms.Label configBall_green;
        private System.Windows.Forms.Label configBall_red;
        private System.Windows.Forms.PictureBox configBall_helper;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox configBall_preview;
        private System.Windows.Forms.Button configBall_ok;

    }
}