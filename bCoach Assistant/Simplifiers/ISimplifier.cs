using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace bCoach_Assistant.Simplifiers
{
    public enum Simplifier
    {
        ErodeDilate,
    }

    public interface ISimplifier
    {
        Image<Bgr, byte> Simplify(Image<Bgr, byte> frame);
    }
}
