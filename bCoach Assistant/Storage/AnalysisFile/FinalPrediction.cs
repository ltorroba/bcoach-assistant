using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using bCoach_Assistant.Storage.CaptureFile;

namespace bCoach_Assistant.Storage.AnalysisFile
{
    [Serializable]
    public class FinalPrediction
    {
        public List<CameraPrediction> CameraPredictions { get; private set; }
        public List<Point> Path { get; private set; }

        public FinalPrediction()
        {
            CameraPredictions = new List<CameraPrediction>();
            Path = new List<Point>();
        }

        public string Serialize()
        {
            MemoryStream s = new MemoryStream();
            XmlSerializer xs = new XmlSerializer(typeof(Wrapper));
            xs.Serialize(s, this);

            return Encoding.ASCII.GetString(s.ToArray());
        }

        public void Predict(Ball b)
        {
            // TODO: The weightings of the final prediction should be based on an inverse square law on the ball 
            //       diameter or inverse relationship of the area
        }
    }
}
