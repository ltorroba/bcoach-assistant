using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using bCoach_Assistant.Storage.CaptureFile;
using bCoach_Assistant.Storage.AnalysisFile;

namespace bCoach_Assistant.Analyser
{
    public partial class Analyse : Form
    {
        public Storage.AnalysisFile.Wrapper Prediction
        {
            get
            {
                return analysisWrapper;
            }
            private set
            {
                analysisWrapper = value;
            }
        }

        private Thread t;

        private Storage.AnalysisFile.Wrapper analysisWrapper;

        public Analyse(Storage.CaptureFile.Wrapper wrap) // No, not a chicken wrap
        {
            InitializeComponent();
            analysisWrapper = new Storage.AnalysisFile.Wrapper();
            analysisWrapper.Capture = wrap;
        }

        private void Analyse_Load(object sender, EventArgs e)
        {
            t = new Thread(StartAnalysis);
            t.Start();
        }

        private void SetCurrentTask(string text)
        {
            currentTask.BeginInvoke((MethodInvoker)delegate
            {
                currentTask.Text = text;
            });
        }

        private void SetTaskMaximumProgress(int maximum)
        {
            taskProgress.BeginInvoke((MethodInvoker)delegate
            {
                taskProgress.Maximum = maximum;
            });             
        }

        private void SetTaskProgress(int current)
        {
            taskProgress.BeginInvoke((MethodInvoker)delegate
            {
                taskProgress.Value = current;
            });
        }

        private void SetOverallMaximumProgress(int maximum)
        {
            overallProgress.BeginInvoke((MethodInvoker)delegate
            {
                overallProgress.Maximum = maximum;
            });
        }

        private void SetOverallProgress(int current)
        {
            overallProgress.BeginInvoke((MethodInvoker)delegate
            {
                overallProgress.Value = current;
            });
        }

        private void StartAnalysis()
        {
            foreach (Camera camera in analysisWrapper.Capture.Cameras)
            {
                CameraPrediction prediction = new CameraPrediction(camera);
                
                SetCurrentTask("Analysing camera #" + camera.Id + " (" + camera.Name + ")");
                SetTaskMaximumProgress(camera.EndFrame - camera.StartFrame);

                for (int i = camera.StartFrame; i <= camera.EndFrame; i++)
                {
                    prediction.PredictFrame(analysisWrapper.Capture.Ball, i);
                    
                    SetTaskProgress(i);             
                }

                analysisWrapper.Prediction.CameraPredictions.Add(prediction);
            }
        }
    }
}
