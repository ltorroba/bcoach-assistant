using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace bCoach_Assistant.Detectors
{
    public enum Detector
    {
        BgrThresholds,
    }

    public interface IDetector
    {
        Blob Detect(Image<Bgr, byte> frame);
    }
}
