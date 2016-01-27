using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bCoach_Assistant.Wizard
{
    public partial class CameraConfigurationSource : Form
    {
        private Video vid;

        public string FileName { get; set; }
        public int StartFrame { get; set; }
        public int EndFrame { get; set; }

        public CameraConfigurationSource()
        {
            FileName = "";
            StartFrame = -1;
            EndFrame = -1;

            InitializeComponent();            
        }

        public CameraConfigurationSource(string fileName, int startFrame, int endFrame)
        {
            FileName = fileName;
            StartFrame = startFrame;
            EndFrame = endFrame;

            InitializeComponent();
        }

        private void configSource_browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.Multiselect = false;

            // TODO: Filter extensions to video exclusively

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                configSource_browsePath.Text = ofd.FileName;
                FileName = ofd.FileName;

                StartFrame = 0;

                vid = new Video(FileName); // TODO: What if exception here?
                EndFrame = vid.CountFrames() - 1;

                SetupTextboxValidation();

                configSource_startFrame.Value = 0;
                configSource_endFrame.Value = EndFrame;

                SetStartFramePreview((int)configSource_startFrame.Value);
                SetEndFramePreview((int)configSource_endFrame.Value);

                configSource_startFrame.Enabled = true;
                configSource_endFrame.Enabled = true;
            }
        }

        private void SetupTextboxValidation()
        {            
            configSource_startFrame.Minimum = 0;
            configSource_startFrame.Maximum = vid.CountFrames() - 1;            
                        
            configSource_endFrame.Minimum = 0;
            configSource_endFrame.Maximum = vid.CountFrames() - 1; ;
            
        }

        private void CameraConfigurationSource_Load(object sender, EventArgs e)
        {
            if (StartFrame != -1 && EndFrame != -1)
            {
                configSource_browsePath.Text = FileName;
                vid = new Video(FileName);

                SetupTextboxValidation();

                configSource_startFrame.Value = StartFrame;
                configSource_endFrame.Value = EndFrame;

                SetStartFramePreview((int)configSource_startFrame.Value);
                SetEndFramePreview((int)configSource_endFrame.Value);
            }
            else
            {
                configSource_startFrame.Enabled = false;
                configSource_endFrame.Enabled = false;
            }
        }

        private void configSource_startFrame_ValueChanged(object sender, EventArgs e)
        {
            StartFrame = (int)configSource_startFrame.Value;
            SetStartFramePreview((int)configSource_startFrame.Value);
        }

        private void configSource_endFrame_ValueChanged(object sender, EventArgs e)
        {
            EndFrame = (int)configSource_endFrame.Value;
            SetEndFramePreview((int)configSource_endFrame.Value);
        }

        private void SetStartFramePreview(int frame)
        {
            configSource_startFramePreview.Image = vid.GetFrameAsBitmap(frame);
        }

        private void SetEndFramePreview(int frame)
        {
            configSource_endFramePreview.Image = vid.GetFrameAsBitmap(frame);
        }

        private void configSource_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
