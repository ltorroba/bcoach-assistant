using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;

namespace bCoach_Assistant.Wizard
{
    public partial class CameraConfiguration : Form
    {
        // Source properties
        public string FileName { get; set; }
        public int StartFrame { get; set; }
        public int EndFrame { get; set; }

        // Ball detection properties
        public Bgr Maximum { get; set; }
        public Bgr Minimum { get; set; }
        public int Iterations { get; set; }

        public CameraConfiguration()
        {
            FileName = "";
            StartFrame = -1;
            EndFrame = -1;
            Minimum = new Bgr();
            Maximum = new Bgr();
            Iterations = -1;

            InitializeComponent();
        }

        public CameraConfiguration(string fileName, int startFrame, int endFrame, Bgr min, Bgr max, int iterations)
        {
            FileName = fileName;
            StartFrame = startFrame;
            EndFrame = endFrame;
            Minimum = min;
            Maximum = max;
            Iterations = iterations;

            InitializeComponent();
        }

        private void config_setDetection_Click(object sender, EventArgs e)
        {
            using (CameraConfigurationBallDetection camConfigBallDetect = new CameraConfigurationBallDetection(FileName, StartFrame, EndFrame, Minimum, Maximum, Iterations))
            {
                camConfigBallDetect.ShowDialog();

                this.Maximum = camConfigBallDetect.Maximum;
                this.Minimum = camConfigBallDetect.Minimum;
                this.Iterations = camConfigBallDetect.Iterations;

                config_iterations.Text = "Iterations: " + this.Iterations;
                config_rThresh.Text = "Red: " + this.Minimum.Red + "-" + this.Maximum.Red;
                config_gThresh.Text = "Green: " + this.Minimum.Green + "-" + this.Maximum.Green;
                config_bThresh.Text = "Blue: " + this.Minimum.Blue + "-" + this.Maximum.Blue;
            }
        }

        private void config_setSource_Click(object sender, EventArgs e)
        {
            using (CameraConfigurationSource camConfigSource = new CameraConfigurationSource(FileName, StartFrame, EndFrame))
            {
                camConfigSource.ShowDialog();

                this.FileName = camConfigSource.FileName;
                this.StartFrame = camConfigSource.StartFrame;
                this.EndFrame = camConfigSource.EndFrame;

                config_source.Text = "Source: " + FileName;
                config_startFrame.Text = "Start frame: " + StartFrame;
                config_endFrame.Text = "End frame: " + EndFrame;

                config_setDetection.Enabled = FileName == "" ? false : true;
            }
        }

        private void CameraConfiguration_Load(object sender, EventArgs e)
        {
            if(FileName == "")
                config_source.Text = "Source: Not set";
            else
                config_source.Text = "Source: " + FileName;

            if(StartFrame == -1)
                config_startFrame.Text = "Start frame: Not set";
            else
                config_startFrame.Text = "Start frame: " + StartFrame;

            if(EndFrame == -1)
                config_endFrame.Text = "End frame: Not set";
            else
                config_endFrame.Text = "End frame: " + EndFrame;

            if (Iterations == -1)
            {
                config_iterations.Text = "Iterations: Not set";
                config_rThresh.Text = "Red: Not set";
                config_gThresh.Text = "Green: Not set";
                config_bThresh.Text = "Blue: Not set";
            }
            else
            {
                config_iterations.Text = "Iterations: " + Iterations;
                config_rThresh.Text = "Red: " + this.Minimum.Red + "-" + this.Maximum.Red;
                config_gThresh.Text = "Green: " + this.Minimum.Green + "-" + this.Maximum.Green;
                config_bThresh.Text = "Blue: " + this.Minimum.Blue + "-" + this.Maximum.Blue;
            }

            config_setDetection.Enabled = FileName == "" ? false : true;
        }

        private void config_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
