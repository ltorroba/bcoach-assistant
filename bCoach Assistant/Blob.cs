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
    public class Blob
    {
        public Contour<Point> Contour { get; private set; }
        public double Area
        {
            get
            {
                return Contour.Area;
            }
        }

        public Blob(Contour<Point> contour)
        {
            Contour = contour;
        }
    }
}
