namespace bCoach_Assistant.Wizard
{
    partial class CameraPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraPosition));
            this.position_ok = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.position_x = new System.Windows.Forms.TextBox();
            this.position_y = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.position_angle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // position_ok
            // 
            this.position_ok.Location = new System.Drawing.Point(410, 192);
            this.position_ok.Name = "position_ok";
            this.position_ok.Size = new System.Drawing.Size(75, 23);
            this.position_ok.TabIndex = 9;
            this.position_ok.Text = "OK";
            this.position_ok.UseVisualStyleBackColor = true;
            this.position_ok.Click += new System.EventHandler(this.position_ok_Click);
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
            this.label9.Size = new System.Drawing.Size(186, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = "Position camera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "X Coordinate (in metres):";
            // 
            // position_x
            // 
            this.position_x.Location = new System.Drawing.Point(152, 113);
            this.position_x.Name = "position_x";
            this.position_x.Size = new System.Drawing.Size(160, 20);
            this.position_x.TabIndex = 11;
            // 
            // position_y
            // 
            this.position_y.Location = new System.Drawing.Point(152, 139);
            this.position_y.Name = "position_y";
            this.position_y.Size = new System.Drawing.Size(160, 20);
            this.position_y.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Y Coordinate (in metres):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Angle (in degrees):";
            // 
            // position_angle
            // 
            this.position_angle.Location = new System.Drawing.Point(152, 165);
            this.position_angle.Name = "position_angle";
            this.position_angle.Size = new System.Drawing.Size(160, 20);
            this.position_angle.TabIndex = 15;
            // 
            // CameraPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 227);
            this.Controls.Add(this.position_angle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.position_y);
            this.Controls.Add(this.position_x);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.position_ok);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CameraPosition";
            this.Text = "Camera Position";
            this.Load += new System.EventHandler(this.CameraPosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button position_ok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox position_x;
        private System.Windows.Forms.TextBox position_y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox position_angle;
    }
}