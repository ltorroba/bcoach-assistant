using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

namespace bCoach_Assistant
{
    class Video
    {
        private Capture _capture;

        public Video(string path)
        {
            _capture = new Capture(path);
        }

        public int CountFrames()
        {
            return (int)_capture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_COUNT);
        }

        public Image<Bgr, byte> GetFrame(int frame)
        {
            _capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_POS_FRAMES, frame);
            return _capture.QueryFrame();
        }

        public Bitmap GetFrameAsBitmap(int frame)
        {
            _capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_POS_FRAMES, frame);
            return _capture.QueryFrame().ToBitmap();
        }
    }
}
