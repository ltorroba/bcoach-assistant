namespace bCoach_Assistant.Analyser
{
    partial class Analyse
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
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.taskProgress = new System.Windows.Forms.ProgressBar();
            this.overallProgress = new System.Windows.Forms.ProgressBar();
            this.currentTask = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(12, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(525, 57);
            this.label23.TabIndex = 2;
            this.label23.Text = "The program is now analysing the videos in order to predict the ball\'s position. " +
    "You can see the program\'s progress below. \r\n\r\nTo stop the analysis, press cancel" +
    ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentTask);
            this.groupBox1.Controls.Add(this.overallProgress);
            this.groupBox1.Controls.Add(this.taskProgress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Progress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current task:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task progress:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Overall progress:";
            // 
            // taskProgress
            // 
            this.taskProgress.Location = new System.Drawing.Point(99, 39);
            this.taskProgress.Name = "taskProgress";
            this.taskProgress.Size = new System.Drawing.Size(409, 14);
            this.taskProgress.TabIndex = 3;
            // 
            // overallProgress
            // 
            this.overallProgress.Location = new System.Drawing.Point(99, 60);
            this.overallProgress.Name = "overallProgress";
            this.overallProgress.Size = new System.Drawing.Size(409, 14);
            this.overallProgress.TabIndex = 4;
            // 
            // currentTask
            // 
            this.currentTask.AutoSize = true;
            this.currentTask.Location = new System.Drawing.Point(98, 20);
            this.currentTask.Name = "currentTask";
            this.currentTask.Size = new System.Drawing.Size(64, 13);
            this.currentTask.TabIndex = 5;
            this.currentTask.Text = "currentTask";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Analyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label23);
            this.Name = "Analyse";
            this.Text = "Analysing...";
            this.Load += new System.EventHandler(this.Analyse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label currentTask;
        private System.Windows.Forms.ProgressBar overallProgress;
        private System.Windows.Forms.ProgressBar taskProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;

    }
}