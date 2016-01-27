using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bCoach_Assistant
{
    public struct CameraThreshold
    {
        public int lR, lG, lB; // Lower values of the threshold
        public int hR, hG, hB; // Higher values of the threshold
    }

    public class Camera
    {
        private int id;
        private string name;
        private string notes;
        private double xPos = -999;
        private double yPos = -999;
        private decimal angle = -1;
        private CameraThreshold threshold;
        private int smoothingIterations;
        private decimal focalLength = -1;

        // Properties
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
            }
        }

        public double X
        {
            get
            {
                return xPos;
            }
            set
            {
                xPos = value;
            }
        }

        public double Y
        {
            get
            {
                return yPos;
            }
            set
            {
                yPos = value;
            }
        }

        public decimal Angle
        {
            get
            {
                return angle;
            }
            set
            {
                angle = value;
            }
        }

        public CameraThreshold Threshold
        {
            get
            {
                return threshold;
            }
            set
            {
                threshold = value;
            }
        }

        public int Iterations
        {
            get
            {
                return smoothingIterations;
            }
            set
            {
                smoothingIterations = value;
            }
        }

        public decimal FocalLength
        {
            get
            {
                return focalLength;
            }
            set
            {
                focalLength = value;
            }
        }

        // Constructor
        public Camera()
        {
        }
    }
}
