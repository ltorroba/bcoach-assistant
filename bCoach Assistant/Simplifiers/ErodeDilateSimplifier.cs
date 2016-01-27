using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace bCoach_Assistant.Simplifiers
{
    public class ErodeDilateSimplifier : ISimplifier
    {
        public int Iterations { get; private set; }

        public ErodeDilateSimplifier(int iterations)
        {
            Iterations = iterations;
        }

        public Image<Bgr, byte> Simplify(Image<Bgr, byte> frame)
        {
            Image<Bgr, byte> smooth = frame.Erode(Iterations).Convert<Bgr, byte>();
            smooth = smooth.Dilate(Iterations);

            return smooth;
        }
    }
}
