using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using bCoach_Assistant.Storage.CaptureFile;
using bCoach_Assistant.Analyser;

namespace bCoach_Assistant.Wizard
{
    public partial class AnalysisCreationWizard : Form
    {
        int currentStep = 1;
        int totalPanels = 4;

        string path = "";
        Form creator;

        public Wrapper Capture
        {
            get
            {
                return wrapper;
            }
            private set
            {
                wrapper = value;
            }
        }

        // Data
        private Court court;
        private List<Camera> cameraList = new List<Camera>();
        private Ball ball;

        private Wrapper wrapper;
        
        public AnalysisCreationWizard(Form creator)
        {
            this.creator = creator;

            InitializeComponent();
        }

        public AnalysisCreationWizard(Form creator, Court court, List<Camera> cameraList, Ball ball, int panel)
        {
            this.creator = creator;
            this.court = court;
            this.cameraList = cameraList;
            this.ball = ball;
            this.currentStep = panel;

            InitializeComponent();
        }

        private void AnalysisCreationWizard_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            DisplayPanel(1);

            if (court != null)
            {
                court_width.Value = court.Width;
                court_height.Value = court.Height;
            }

            if (ball != null)
                ball_size.Value = ball.Diameter;

            if (cameraList.Count > 0)
            {
                for (int i = 0; i < cameraList.Count; i++)
                {
                    string[] subItems = { "No", "No", "No" }; // That's a no-no, no!
                    listView1.Items.Add(cameraList[i].Name).SubItems.AddRange(subItems);

                    listView1.Items[i].SubItems[0].Text = cameraList[i].Name;
                    listView1.Items[i].SubItems[1].Text = cameraList[i].FocalLength != -1 ? "Yes" : "No";
                    listView1.Items[i].SubItems[2].Text = (cameraList[i].X != -999 & cameraList[i].Y != -999 & cameraList[i].Angle != -1) ? "Yes" : "No";
                    listView1.Items[i].SubItems[3].Text = (cameraList[i].FilePath != "" && cameraList[i].StartFrame != -1 && cameraList[i].EndFrame != -1 && cameraList[i].Iterations != -1) ? "Yes" : "No";
                }                
            }
        }

        #region Panel manager

        private void nextBtn_Click(object sender, EventArgs e)
        {
            // Store court properties
            if (currentStep == 2)
            {
                court = new Court();
                ball = new Ball();

                court.Width = court_width.Value;
                court.Height = court_height.Value;
                ball.Diameter = (int)ball_size.Value;
            }

            if (currentStep == totalPanels)
            {
                Finish();
            }
            else
            {
                DisplayPanel(++currentStep);
            }            
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            DisplayPanel(--currentStep);
        }

        private void DisplayPanel(int n)
        {
            for (int i = 1; i <= totalPanels; i++)
            {
                this.Controls["panel" + i].Visible = false;
            }

            this.Controls["panel" + n].Visible = true;

            if (n == totalPanels)
            {
                nextBtn.Text = "Finish";
            }
            else
            {
                nextBtn.Text = "Next";
            }

            if (n == 1)
                previousBtn.Enabled = false;
            else
                previousBtn.Enabled = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ExitWizard();
        }

        private void Finish()
        {
            if (path != "")
            {
                string serial = wrapper.Serialize();

                File.WriteAllText(path + @"\capture.bcc", serial);

                // TODO: Route this through init
                Main m = new Main();
                m.Show();

                this.Hide();

            }
            else
                MessageBox.Show("You must select a valid save path for your file!");
        }

        private void ExitWizard()
        {
            creator.Show();
            this.Close();
        }

        #endregion

        #region Panel 3 - Camera calibration and positioning        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
                UpdateGroupBox(listView1.SelectedIndices[0]);
            else
                groupBox1.Enabled = false;
        }

        private void camera_add_Click(object sender, EventArgs e)
        {
            Camera c = new Camera();
            c.Id = listView1.Items.Count == 0 ? 0 : cameraList.OrderByDescending(a => a.Id).FirstOrDefault().Id + 1;
            c.Name = "Camera #" + c.Id;
            cameraList.Add(c);
            
            string[] subItems = {"No", "No", "No"}; // That's a no-no, no!
            listView1.Items.Add(c.Name).SubItems.AddRange(subItems);
            
            GrantSoleSelection(listView1.Items.Count - 1);
        }

        /// <summary>
        /// Grants selection solely to the specified index of the list view.
        /// </summary>
        /// <param name="n">The index to be selected.</param>
        private void GrantSoleSelection(int n)
        {
            foreach (ListViewItem i in listView1.Items)
                i.Selected = false;

            listView1.Items[listView1.Items.Count - 1].Selected = true;
        }

        private void UpdateGroupBox(int n)
        {
            // TODO: Add color coding to text-boxes so that it is easy to see what isn't setup yet

            groupBox1.Enabled = true;
            Camera c = cameraList.Where(p => p.Id == n).FirstOrDefault();
            camera_name.Text = c.Name;
            camera_notes.Text = c.Notes;

            if (c.FocalLength != -1)
                camera_calibrateText.Text = "Focal length: " + c.FocalLength.ToString();
            else
                camera_calibrateText.Text = "Not calibrated yet.";

            if (c.X != -999 && c.Y != -999 && c.Angle != -1)
                camera_positionText.Text = "X: " + c.X.ToString() + "; Y: " + c.Y.ToString() + "; Angle: " + c.Angle.ToString();
            else
                camera_positionText.Text = "Not positioned yet.";

            bool video = false;
            bool detector = false;

            if (c.FilePath != "" && c.StartFrame != -1 && c.EndFrame != -1)
                video = true;
            else
                video = false;

            if (c.Iterations != -1) // We can still work with unset thresholds! (e.g.: all at 0!) I think...
                detector = true;
            else
                detector = false;

            if (!video && !detector)
                camera_configText.Text = "Not setup yet.";
            else if (video && !detector)
                camera_configText.Text = "Must setup detector.";
            else if (!video && detector) // Should be impossible
                camera_configText.Text = "Must setup video.";
            else
                camera_configText.Text = "Correctly setup.";

            UpdateListView();
        }

        private int GetCurrentFocusIndex()
        {
            return listView1.SelectedIndices[0]; // Throws ArgumentOutOfRangeException if no camera from the 
                                                 // ListView is selected
        }

        private Camera GetCameraFromId(int n)
        {
            return cameraList.Where(p => p.Id == n).FirstOrDefault();
        }

        private Camera GetCurrentCamera()
        {
            int currIndex = listView1.SelectedIndices[0]; // Throws ArgumentOutOfRangeException if no camera from the 
                                                          // ListView is selected

            return cameraList[currIndex];
        }

        private void camera_calibrate_Click(object sender, EventArgs e)
        {
            using (CameraCalibration cal = new CameraCalibration(GetCurrentCamera().FocalLength))
            {
                cal.ShowDialog();
                
                GetCurrentCamera().FocalLength = cal.FocalLength;
                
                UpdateGroupBox(GetCurrentFocusIndex());
            }
        }

        private void camera_position_Click(object sender, EventArgs e)
        {
            using (CameraPosition pos = new CameraPosition(GetCurrentCamera().X, GetCurrentCamera().Y, GetCurrentCamera().Angle))
            {
                pos.ShowDialog();

                GetCurrentCamera().X = pos.X;
                GetCurrentCamera().Y = pos.Y;
                GetCurrentCamera().Angle = pos.Angle;

                UpdateGroupBox(GetCurrentFocusIndex());
            }
        }

        private void camera_notes_TextChanged(object sender, EventArgs e)
        {
            GetCurrentCamera().Notes = camera_notes.Text;
        }

        private void camera_name_TextChanged(object sender, EventArgs e)
        {
            GetCurrentCamera().Name = camera_name.Text;
            UpdateListView();
        }

        private void UpdateListView()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].SubItems[0].Text = cameraList[i].Name;
                listView1.Items[i].SubItems[1].Text = cameraList[i].FocalLength != -1 ? "Yes" : "No";
                listView1.Items[i].SubItems[2].Text = (cameraList[i].X != -999 & cameraList[i].Y != -999 & cameraList[i].Angle != -1) ? "Yes" : "No";
                listView1.Items[i].SubItems[3].Text = (cameraList[i].FilePath != "" && cameraList[i].StartFrame != -1 && cameraList[i].EndFrame != -1 && cameraList[i].Iterations != -1) ? "Yes" : "No";
            }
        }

        private void camera_config_Click(object sender, EventArgs e)
        {
            Camera c = GetCurrentCamera();

            using (CameraConfiguration camConfig = new CameraConfiguration(c.FilePath, c.StartFrame, c.EndFrame, c.MinimumThresholds,
                                                                            c.MaximumThresholds, c.Iterations))
            {
                camConfig.ShowDialog();

                GetCurrentCamera().MinimumThresholds = camConfig.Minimum;
                GetCurrentCamera().MaximumThresholds = camConfig.Maximum;
                GetCurrentCamera().Iterations = camConfig.Iterations;
                GetCurrentCamera().FilePath = camConfig.FileName;
                GetCurrentCamera().StartFrame = camConfig.StartFrame;
                GetCurrentCamera().EndFrame = camConfig.EndFrame;

                UpdateGroupBox(GetCurrentFocusIndex());
            }
        }

        #endregion

        #region Panel 4 - Save analysis file

        private void browseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();

            // TODO: Filter, not select multiples, etc.
            if (dr == DialogResult.OK)
            {
                path = fbd.SelectedPath;

                wrapper = new Wrapper();
                wrapper.Cameras = cameraList;
                wrapper.Court = court;
                wrapper.Ball = ball;

                filePathTextbox.Text = path;
            }
        }

        #endregion





    }
}
