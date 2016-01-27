using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using bCoach_Assistant.Simplifiers;
using bCoach_Assistant.Detectors;

namespace bCoach_Assistant.Wizard
{
    public partial class CameraConfigurationBallDetection : Form
    {
        private string videoFile = "";
        private int minimumFrame = 0;
        private int maximumFrame = 0;
        private Video video;

        private Bitmap helperFrame;
        private Pen p;
        private double zoom = 0;
        private double xOffset = 0;
        private double yOffset = 0;

        private int prevX = -1000;
        private int prevY = -1000;

        private bool mouseDown = false;

        // Public properties
        public Bgr Minimum { get; private set; }
        public Bgr Maximum { get; private set; }
        public int Iterations { get; private set; }

        public CameraConfigurationBallDetection(string path, int minimumFrame, int maximumFrame)
        {
            videoFile = path;
            video = new Video(path);
            this.minimumFrame = minimumFrame;
            this.maximumFrame = maximumFrame;

            Minimum = new Bgr();
            Maximum = new Bgr();
            Iterations = -1;

            helperFrame = video.GetFrameAsBitmap(minimumFrame);
            p = new Pen(Brushes.Lime, 1f);     

            InitializeComponent();
        }

        public CameraConfigurationBallDetection(string path, int minimumFrame, int maximumFrame, Bgr minimum, Bgr maximum, int iterations)
        {
            videoFile = path;
            video = new Video(path);
            this.minimumFrame = minimumFrame;
            this.maximumFrame = maximumFrame;

            Minimum = minimum;
            Maximum = maximum;
            Iterations = iterations;

            helperFrame = video.GetFrameAsBitmap(minimumFrame);
            p = new Pen(Brushes.Lime, 1f);

            InitializeComponent();
        }

        private void CameraConfigurationBallDetection_Load(object sender, EventArgs e)
        {
            if (Iterations != -1)
            {
                configBall_iterations.Value = Iterations;

                configBall_bMin.Value = (decimal)Minimum.Blue;
                configBall_bMax.Value = (decimal)Maximum.Blue;

                configBall_gMin.Value = (decimal)Minimum.Green;
                configBall_gMax.Value = (decimal)Maximum.Green;

                configBall_rMin.Value = (decimal)Minimum.Red;
                configBall_rMax.Value = (decimal)Maximum.Red;
            }

            // Helper 
            configBall_helper.MouseDown += configBall_helper_MouseDown;
            configBall_helper.MouseMove += configBall_helper_MouseMove;
            configBall_helper.MouseUp += configBall_helper_MouseUp;

            // Numeric up & downs
            configBall_bMin.ValueChanged += UpdatePreview;
            configBall_bMax.ValueChanged += UpdatePreview;
            configBall_gMin.ValueChanged += UpdatePreview;
            configBall_gMax.ValueChanged += UpdatePreview;
            configBall_rMin.ValueChanged += UpdatePreview;
            configBall_rMax.ValueChanged += UpdatePreview;

            zoom = (double)configBall_helper.Width / (double)helperFrame.Width < (double)configBall_helper.Height / (double)helperFrame.Height ?
                (double)configBall_helper.Width / (double)helperFrame.Width : (double)configBall_helper.Height / (double)helperFrame.Height;

            xOffset = ((configBall_helper.Width / zoom) - helperFrame.Width) / 2;
            yOffset = ((configBall_helper.Height / zoom) - helperFrame.Height) / 2;

            configBall_previewFrame.Minimum = minimumFrame;
            configBall_previewFrame.Maximum = maximumFrame;
            configBall_previewFrame.Value = minimumFrame;
            UpdatePreview();

            configBall_helper.Image = helperFrame;
        }

        private void configBall_helper_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                mouseDown = false;
        }

        private void configBall_helper_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            prevX = me.X;
            prevY = me.Y;

            UpdateHelper();
        }

        private void configBall_helper_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                mouseDown = true;
        }

        private void UpdatePreview(object sender = null, EventArgs e = null)
        {
            ErodeDilateSimplifier simplifier = new ErodeDilateSimplifier((int)configBall_iterations.Value);
            Image<Bgr, byte> simplifiedImage = simplifier.Simplify(video.GetFrame((int)configBall_previewFrame.Value));

            Bgr minimumThresholds = new Bgr((int)configBall_bMin.Value, (int)configBall_gMin.Value, (int)configBall_rMin.Value);
            Bgr maximumThresholds = new Bgr((int)configBall_bMax.Value, (int)configBall_gMax.Value, (int)configBall_rMax.Value);

            BgrThresholdsDetector detector = new BgrThresholdsDetector(minimumThresholds, maximumThresholds);
            Blob output = detector.Detect(simplifiedImage);

            if(output != null)
                simplifiedImage.Draw(output.Contour, new Bgr(Color.Azure), 0);

            configBall_preview.Image = simplifiedImage.ToBitmap();
        }

        private void UpdateHelper()
        {
            DrawHelperCrossHair(prevX, prevY);   
        }

        private void configBall_iterations_ValueChanged(object sender, EventArgs e)
        {
            UpdatePreview();
            UpdateHelper();
        }

        private void configBall_helper_Click(object sender, EventArgs e)
        {            
        }

        private void DrawHelperCrossHair(int x, int y)
        {
            ErodeDilateSimplifier simplifier = new ErodeDilateSimplifier((int)configBall_iterations.Value);
            Bitmap erodedBitmap = simplifier.Simplify(video.GetFrame((int)configBall_previewFrame.Value)).ToBitmap();

            Image erodedBitmapCopy = (Image)erodedBitmap.Clone();
            
            Point intercept = new Point((int)(x / zoom - xOffset), (int)(y / zoom - yOffset));

            // Check it is within bounds
            if (intercept.X >= 0 && x < erodedBitmapCopy.Width)
            {
                if (intercept.Y >= 0 && intercept.Y < erodedBitmapCopy.Height)
                {
                    Color point = erodedBitmap.GetPixel(intercept.X, intercept.Y);

                    using (Graphics g = Graphics.FromImage(erodedBitmapCopy))
                    {
                        g.DrawLine(p, new Point(intercept.X, 0), new Point(intercept.X, erodedBitmapCopy.Height));
                        g.DrawLine(p, new Point(0, intercept.Y), new Point(erodedBitmapCopy.Width, intercept.Y));
                        g.Save();
                    }

                    configBall_blue.Text = "Blue: " + point.B;
                    configBall_green.Text = "Green: " + point.G;
                    configBall_red.Text = "Red: " + point.R;
                }
            }

            configBall_helper.Image = erodedBitmapCopy;
        }

        private void configBall_previewFrame_ValueChanged(object sender, EventArgs e)
        {
            UpdatePreview();
            UpdateHelper();
        }

        private void configBall_ok_Click(object sender, EventArgs e)
        {
            Minimum = new Bgr((int)configBall_bMin.Value, (int)configBall_gMin.Value, (int)configBall_rMin.Value);
            Maximum = new Bgr((int)configBall_bMax.Value, (int)configBall_gMax.Value, (int)configBall_rMax.Value);
            Iterations = (int)configBall_iterations.Value;

            this.Close();
        }
    }
}
