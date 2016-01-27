namespace bCoach_Assistant.Wizard
{
    partial class CameraConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraConfiguration));
            this.config_ok = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.config_setSource = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.config_endFrame = new System.Windows.Forms.Label();
            this.config_startFrame = new System.Windows.Forms.Label();
            this.config_source = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.config_bThresh = new System.Windows.Forms.Label();
            this.config_gThresh = new System.Windows.Forms.Label();
            this.config_rThresh = new System.Windows.Forms.Label();
            this.config_iterations = new System.Windows.Forms.Label();
            this.config_setDetection = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // config_ok
            // 
            this.config_ok.Location = new System.Drawing.Point(409, 227);
            this.config_ok.Name = "config_ok";
            this.config_ok.Size = new System.Drawing.Size(75, 23);
            this.config_ok.TabIndex = 9;
            this.config_ok.Text = "OK";
            this.config_ok.UseVisualStyleBackColor = true;
            this.config_ok.Click += new System.EventHandler(this.config_ok_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(24, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(463, 68);
            this.label8.TabIndex = 8;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = "Configure camera";
            // 
            // config_setSource
            // 
            this.config_setSource.Location = new System.Drawing.Point(137, 84);
            this.config_setSource.Name = "config_setSource";
            this.config_setSource.Size = new System.Drawing.Size(75, 23);
            this.config_setSource.TabIndex = 11;
            this.config_setSource.Text = "Set...";
            this.config_setSource.UseVisualStyleBackColor = true;
            this.config_setSource.Click += new System.EventHandler(this.config_setSource_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.config_endFrame);
            this.groupBox1.Controls.Add(this.config_startFrame);
            this.groupBox1.Controls.Add(this.config_source);
            this.groupBox1.Controls.Add(this.config_setSource);
            this.groupBox1.Location = new System.Drawing.Point(27, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 113);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video source";
            // 
            // config_endFrame
            // 
            this.config_endFrame.AutoSize = true;
            this.config_endFrame.Location = new System.Drawing.Point(13, 54);
            this.config_endFrame.Name = "config_endFrame";
            this.config_endFrame.Size = new System.Drawing.Size(58, 13);
            this.config_endFrame.TabIndex = 14;
            this.config_endFrame.Text = "End frame:";
            // 
            // config_startFrame
            // 
            this.config_startFrame.AutoSize = true;
            this.config_startFrame.Location = new System.Drawing.Point(10, 37);
            this.config_startFrame.Name = "config_startFrame";
            this.config_startFrame.Size = new System.Drawing.Size(61, 13);
            this.config_startFrame.TabIndex = 13;
            this.config_startFrame.Text = "Start frame:";
            // 
            // config_source
            // 
            this.config_source.AutoSize = true;
            this.config_source.Location = new System.Drawing.Point(27, 20);
            this.config_source.Name = "config_source";
            this.config_source.Size = new System.Drawing.Size(44, 13);
            this.config_source.TabIndex = 12;
            this.config_source.Text = "Source:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.config_bThresh);
            this.groupBox2.Controls.Add(this.config_gThresh);
            this.groupBox2.Controls.Add(this.config_rThresh);
            this.groupBox2.Controls.Add(this.config_iterations);
            this.groupBox2.Controls.Add(this.config_setDetection);
            this.groupBox2.Location = new System.Drawing.Point(251, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 113);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ball detection";
            // 
            // config_bThresh
            // 
            this.config_bThresh.AutoSize = true;
            this.config_bThresh.Location = new System.Drawing.Point(29, 70);
            this.config_bThresh.Name = "config_bThresh";
            this.config_bThresh.Size = new System.Drawing.Size(31, 13);
            this.config_bThresh.TabIndex = 4;
            this.config_bThresh.Text = "Blue:";
            // 
            // config_gThresh
            // 
            this.config_gThresh.AutoSize = true;
            this.config_gThresh.Location = new System.Drawing.Point(21, 53);
            this.config_gThresh.Name = "config_gThresh";
            this.config_gThresh.Size = new System.Drawing.Size(39, 13);
            this.config_gThresh.TabIndex = 3;
            this.config_gThresh.Text = "Green:";
            // 
            // config_rThresh
            // 
            this.config_rThresh.AutoSize = true;
            this.config_rThresh.Location = new System.Drawing.Point(30, 37);
            this.config_rThresh.Name = "config_rThresh";
            this.config_rThresh.Size = new System.Drawing.Size(30, 13);
            this.config_rThresh.TabIndex = 2;
            this.config_rThresh.Text = "Red:";
            // 
            // config_iterations
            // 
            this.config_iterations.AutoSize = true;
            this.config_iterations.Location = new System.Drawing.Point(7, 20);
            this.config_iterations.Name = "config_iterations";
            this.config_iterations.Size = new System.Drawing.Size(53, 13);
            this.config_iterations.TabIndex = 1;
            this.config_iterations.Text = "Iterations:";
            // 
            // config_setDetection
            // 
            this.config_setDetection.Location = new System.Drawing.Point(152, 84);
            this.config_setDetection.Name = "config_setDetection";
            this.config_setDetection.Size = new System.Drawing.Size(75, 23);
            this.config_setDetection.TabIndex = 0;
            this.config_setDetection.Text = "Set...";
            this.config_setDetection.UseVisualStyleBackColor = true;
            this.config_setDetection.Click += new System.EventHandler(this.config_setDetection_Click);
            // 
            // CameraConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 256);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.config_ok);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CameraConfiguration";
            this.Text = "Camera Configuration";
            this.Load += new System.EventHandler(this.CameraConfiguration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button config_ok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button config_setSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button config_setDetection;
        private System.Windows.Forms.Label config_endFrame;
        private System.Windows.Forms.Label config_startFrame;
        private System.Windows.Forms.Label config_source;
        private System.Windows.Forms.Label config_bThresh;
        private System.Windows.Forms.Label config_gThresh;
        private System.Windows.Forms.Label config_rThresh;
        private System.Windows.Forms.Label config_iterations;
    }
}