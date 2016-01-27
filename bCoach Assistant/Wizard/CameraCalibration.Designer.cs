namespace bCoach_Assistant.Wizard
{
    partial class CameraCalibration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraCalibration));
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calibrate_focalLength = new System.Windows.Forms.TextBox();
            this.calibrate_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(24, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(463, 68);
            this.label8.TabIndex = 3;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "Calibrate camera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Focal length (in px):";
            // 
            // calibrate_focalLength
            // 
            this.calibrate_focalLength.Location = new System.Drawing.Point(133, 113);
            this.calibrate_focalLength.Name = "calibrate_focalLength";
            this.calibrate_focalLength.Size = new System.Drawing.Size(128, 20);
            this.calibrate_focalLength.TabIndex = 5;
            // 
            // calibrate_ok
            // 
            this.calibrate_ok.Location = new System.Drawing.Point(411, 143);
            this.calibrate_ok.Name = "calibrate_ok";
            this.calibrate_ok.Size = new System.Drawing.Size(75, 23);
            this.calibrate_ok.TabIndex = 6;
            this.calibrate_ok.Text = "OK";
            this.calibrate_ok.UseVisualStyleBackColor = true;
            this.calibrate_ok.Click += new System.EventHandler(this.calibrate_ok_Click);
            // 
            // CameraCalibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 173);
            this.Controls.Add(this.calibrate_ok);
            this.Controls.Add(this.calibrate_focalLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CameraCalibration";
            this.Text = "Calibrate Camera";
            this.Load += new System.EventHandler(this.CameraCalibration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox calibrate_focalLength;
        private System.Windows.Forms.Button calibrate_ok;

    }
}