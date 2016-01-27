using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace bCoach_Assistant.Detectors
{
    public class BgrThresholdsDetector : IDetector
    {
        public Bgr Minimum { get; private set; }
        public Bgr Maximum { get; private set; }

        public BgrThresholdsDetector(Bgr minimum, Bgr maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        public Blob Detect(Image<Bgr, byte> frame)
        {
            Image<Bgr, byte> bgr = frame;
            Image<Gray, byte> b = bgr.Split()[0].InRange(new Gray(Minimum.Blue), new Gray(Maximum.Blue));
            Image<Gray, byte> g = bgr.Split()[1].InRange(new Gray(Minimum.Green), new Gray(Maximum.Green));
            Image<Gray, byte> r = bgr.Split()[2].InRange(new Gray(Minimum.Red), new Gray(Maximum.Red));

            Image<Gray, byte> finalResult = new Image<Gray, byte>(frame.Width, frame.Height);

            Gray black = new Gray(0);
            Gray white = new Gray(255);

            for (int x = 0; x < frame.Height; x++)
            {
                for (int y = 0; y < frame.Width; y++)
                {
                    if (b[x, y].Intensity == 255 && g[x, y].Intensity == 255 && r[x, y].Intensity == 255)
                    {
                        finalResult[x, y] = white;
                    }
                    else
                    {
                        finalResult[x, y] = black;
                    }
                }
            }

            Contour<Point> largestContour = null;

            // TODO: Find reference for this
            for (Contour<Point> c = finalResult.FindContours(CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
                RETR_TYPE.CV_RETR_EXTERNAL); c != null; c = c.HNext)
            {
                if (largestContour == null || c.Area > largestContour.Area)
                {
                    largestContour = c;
                }
            }

            return largestContour == null ? null : new Blob(largestContour);
        }
    }
}
