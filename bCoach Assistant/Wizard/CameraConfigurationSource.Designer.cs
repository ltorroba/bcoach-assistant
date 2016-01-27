namespace bCoach_Assistant.Wizard
{
    partial class CameraConfigurationSource
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.configSource_browsePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.configSource_browseBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.configSource_startFramePreview = new System.Windows.Forms.PictureBox();
            this.configSource_startFrame = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.configSource_endFramePreview = new System.Windows.Forms.PictureBox();
            this.configSource_endFrame = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.configSource_ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configSource_startFramePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configSource_startFrame)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configSource_endFramePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configSource_endFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(24, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(440, 32);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fill in the values below as appropriate. The starting and ending frame should cor" +
    "respond to the same moment in all the videos being analysed.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Set video source";
            // 
            // configSource_browsePath
            // 
            this.configSource_browsePath.Location = new System.Drawing.Point(110, 73);
            this.configSource_browsePath.Name = "configSource_browsePath";
            this.configSource_browsePath.ReadOnly = true;
            this.configSource_browsePath.Size = new System.Drawing.Size(216, 20);
            this.configSource_browsePath.TabIndex = 11;
            this.configSource_browsePath.Text = "No path selected...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Video file path:";
            // 
            // configSource_browseBtn
            // 
            this.configSource_browseBtn.Location = new System.Drawing.Point(332, 71);
            this.configSource_browseBtn.Name = "configSource_browseBtn";
            this.configSource_browseBtn.Size = new System.Drawing.Size(75, 23);
            this.configSource_browseBtn.TabIndex = 13;
            this.configSource_browseBtn.Text = "Browse...";
            this.configSource_browseBtn.UseVisualStyleBackColor = true;
            this.configSource_browseBtn.Click += new System.EventHandler(this.configSource_browseBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.configSource_startFramePreview);
            this.groupBox1.Controls.Add(this.configSource_startFrame);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 185);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start frame";
            // 
            // configSource_startFramePreview
            // 
            this.configSource_startFramePreview.Location = new System.Drawing.Point(6, 44);
            this.configSource_startFramePreview.Name = "configSource_startFramePreview";
            this.configSource_startFramePreview.Size = new System.Drawing.Size(188, 135);
            this.configSource_startFramePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.configSource_startFramePreview.TabIndex = 2;
            this.configSource_startFramePreview.TabStop = false;
            // 
            // configSource_startFrame
            // 
            this.configSource_startFrame.Location = new System.Drawing.Point(90, 18);
            this.configSource_startFrame.Name = "configSource_startFrame";
            this.configSource_startFrame.Size = new System.Drawing.Size(61, 20);
            this.configSource_startFrame.TabIndex = 1;
            this.configSource_startFrame.ValueChanged += new System.EventHandler(this.configSource_startFrame_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Frame number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.configSource_endFramePreview);
            this.groupBox2.Controls.Add(this.configSource_endFrame);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(237, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 185);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "End frame";
            // 
            // configSource_endFramePreview
            // 
            this.configSource_endFramePreview.Location = new System.Drawing.Point(6, 44);
            this.configSource_endFramePreview.Name = "configSource_endFramePreview";
            this.configSource_endFramePreview.Size = new System.Drawing.Size(188, 135);
            this.configSource_endFramePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.configSource_endFramePreview.TabIndex = 3;
            this.configSource_endFramePreview.TabStop = false;
            // 
            // configSource_endFrame
            // 
            this.configSource_endFrame.Location = new System.Drawing.Point(90, 18);
            this.configSource_endFrame.Name = "configSource_endFrame";
            this.configSource_endFrame.Size = new System.Drawing.Size(61, 20);
            this.configSource_endFrame.TabIndex = 2;
            this.configSource_endFrame.ValueChanged += new System.EventHandler(this.configSource_endFrame_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Frame number:";
            // 
            // configSource_ok
            // 
            this.configSource_ok.Location = new System.Drawing.Point(389, 291);
            this.configSource_ok.Name = "configSource_ok";
            this.configSource_ok.Size = new System.Drawing.Size(75, 23);
            this.configSource_ok.TabIndex = 16;
            this.configSource_ok.Text = "OK";
            this.configSource_ok.UseVisualStyleBackColor = true;
            this.configSource_ok.Click += new System.EventHandler(this.configSource_ok_Click);
            // 
            // CameraConfigurationSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 324);
            this.Controls.Add(this.configSource_ok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.configSource_browseBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.configSource_browsePath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Name = "CameraConfigurationSource";
            this.Text = "Camera Configuration Source";
            this.Load += new System.EventHandler(this.CameraConfigurationSource_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configSource_startFramePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configSource_startFrame)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configSource_endFramePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configSource_endFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox configSource_browsePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button configSource_browseBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox configSource_startFramePreview;
        private System.Windows.Forms.NumericUpDown configSource_startFrame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox configSource_endFramePreview;
        private System.Windows.Forms.NumericUpDown configSource_endFrame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button configSource_ok;
    }
}