using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using bCoach_Assistant.Storage.CaptureFile;
using bCoach_Assistant.Storage.AnalysisFile;
using bCoach_Assistant.Wizard;
using Emgu.CV;
using Emgu.CV.Structure;

namespace bCoach_Assistant.Analyser
{
    public partial class Main : Form
    {
        bCoach_Assistant.Storage.CaptureFile.Wrapper captureWrapper;
        bCoach_Assistant.Storage.AnalysisFile.Wrapper analysisWrapper;

        public Main() : this(null)
        {
        }

        public Main(bCoach_Assistant.Storage.CaptureFile.Wrapper wrapper)
        {
            this.captureWrapper = wrapper;
            InitializeComponent();

            this.FormClosed += Main_OnClosed;
        }

        private void Main_OnClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (captureWrapper == null)
            {
                // TODO: Disable all buttons except File > Open and File > New
            }
            else
            {

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void startAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (captureWrapper != null)
            {
                Analyse analysisDiag = new Analyse(captureWrapper);                
                analysisDiag.ShowDialog();

                analysisWrapper = analysisDiag.Prediction;
            }
            else
                MessageBox.Show("You must first load a capture file.");
        }

        private Bitmap DrawPredictions(int frame)
        {
            int scale = 20;

            Bitmap diagram = new Bitmap((int)(analysisWrapper.Capture.Court.Width * scale), (int)(analysisWrapper.Capture.Court.Height * scale));
            
            using (Graphics g = Graphics.FromImage(diagram))
            {
                g.FillRectangle(Brushes.Beige, 0, 0, diagram.Width, diagram.Height);

                foreach (CameraPrediction cp in analysisWrapper.Prediction.CameraPredictions)
                {
                    int x = (int)((double)cp.Camera.X * scale - (double)cp.Distances[frame] / 100 * scale);
                    int y = (int)((double)cp.Camera.Y * scale - (double)cp.Distances[frame] / 100 * scale);
                    int width = (int)((double)cp.Distances[frame] / 100 * 2 * scale);
                    int height = (int)((double)cp.Distances[frame] / 100 * 2 * scale);

                    g.DrawEllipse(Pens.Plum, x, y, width, height);
                }
            }

            return diagram;
        }

        private void setFrame_ValueChanged(object sender, EventArgs e)
        {
            courtDiagram.Image = DrawPredictions((int)setFrame.Value);
        }

        private void openAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "bCoach Analysis File (*.bca)|*.bca";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                if (filePath.EndsWith(".bca"))
                {
                    FileStream fs = File.OpenRead(filePath);
                    XmlSerializer xs = new XmlSerializer(typeof(bCoach_Assistant.Storage.AnalysisFile.Wrapper));

                    analysisWrapper = (bCoach_Assistant.Storage.AnalysisFile.Wrapper)xs.Deserialize(fs);
                }
            }
        }

        private void openCaptureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "bCoach Capture File (*.bcc)|*.bcc";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                if (filePath.EndsWith(".bcc"))
                {
                    FileStream fs = File.OpenRead(filePath);
                    XmlSerializer xs = new XmlSerializer(typeof(bCoach_Assistant.Storage.CaptureFile.Wrapper));

                    captureWrapper = (bCoach_Assistant.Storage.CaptureFile.Wrapper)xs.Deserialize(fs);
                }
            }

        }

        private void courtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AnalysisCreationWizard wiz = new AnalysisCreationWizard(this, captureWrapper.Court, captureWrapper.Cameras, 
                                                    captureWrapper.Ball, 2);

            wiz.ShowDialog();
            captureWrapper = wiz.Capture;
        }

        private void camerasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AnalysisCreationWizard wiz = new AnalysisCreationWizard(this, captureWrapper.Court, captureWrapper.Cameras,
                                                    captureWrapper.Ball, 3);

            wiz.ShowDialog();
            captureWrapper = wiz.Capture;
        }

        private void ballToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalysisCreationWizard wiz = new AnalysisCreationWizard(this, captureWrapper.Court, captureWrapper.Cameras,
                                                    captureWrapper.Ball, 2);

            wiz.ShowDialog();
            captureWrapper = wiz.Capture;
        }        
    }
}
