using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bCoach_Assistant.Storage.CaptureFile;
using bCoach_Assistant.Simplifiers;
using bCoach_Assistant.Detectors;
using Emgu.CV;
using Emgu.CV.Structure;

namespace bCoach_Assistant.Storage.AnalysisFile
{
    [Serializable]
    public class CameraPrediction
    {
        public Camera Camera { get; private set; }
        public decimal[] Distances { get; private set; }
        public List<decimal> Certainty { get; private set; }

        private Video video;

        public CameraPrediction(Camera c)
        {
            this.Camera = c;
            video = new Video(Camera.FilePath);
            Distances = new decimal[Camera.EndFrame - Camera.StartFrame + 1];
        }

        public decimal PredictFrame(Ball b, int frame)
        {
            Image<Bgr, byte> frameImg = video.GetFrame(Camera.StartFrame + frame);

            ErodeDilateSimplifier s = new ErodeDilateSimplifier(Camera.Iterations);
            BgrThresholdsDetector d = new BgrThresholdsDetector(Camera.MinimumThresholds, Camera.MaximumThresholds);

            Image<Bgr, byte> simplifiedFrame = s.Simplify(frameImg);
            Blob prediction = d.Detect(simplifiedFrame);

            if (prediction != null)
            {
                int apparentWidth = (prediction.Contour.BoundingRectangle.Width + prediction.Contour.BoundingRectangle.Height) / 2;
                Distances[frame] = Camera.FocalLength / apparentWidth * b.Diameter;
            }
            else
            {
                Distances[frame] = -1; // Ball could not be located in the frame
            }

            return Distances[frame];
        }

    }
}
