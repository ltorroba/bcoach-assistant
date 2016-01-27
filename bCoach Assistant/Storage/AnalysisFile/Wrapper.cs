using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bCoach_Assistant.Storage.AnalysisFile
{
    [Serializable]
    public class Wrapper
    {
        public CaptureFile.Wrapper Capture { get; set; }
        public FinalPrediction Prediction { get; set; }

        public Wrapper()
        {
            Prediction = new FinalPrediction();
        }
    }
}
