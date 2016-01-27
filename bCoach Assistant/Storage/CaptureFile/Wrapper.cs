using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace bCoach_Assistant.Storage.CaptureFile
{
    [Serializable]
    public class Wrapper
    {
        public Court Court { get; set; }
        public List<Camera> Cameras { get; set; }
        public Ball Ball { get; set; }

        public string Serialize()
        {
            MemoryStream s = new MemoryStream();
            XmlSerializer xs = new XmlSerializer(typeof(Wrapper));
            xs.Serialize(s, this);

            return Encoding.ASCII.GetString(s.ToArray());
        }
    }
}
