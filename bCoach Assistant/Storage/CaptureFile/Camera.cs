using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV.Structure;

namespace bCoach_Assistant.Storage.CaptureFile
{
    [Serializable]
    public class Camera
    {
        private int id;
        private string name;
        private string notes;
        private double xPos = -999;
        private double yPos = -999;
        private decimal angle = -1;
        private Bgr maximumThresholds = new Bgr();
        private Bgr minimumThresholds = new Bgr();
        private int smoothingIterations = -1;
        private decimal focalLength = -1;
        private string filePath = "";
        private int startFrame = -1;
        private int endFrame = -1;

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

        public Bgr MaximumThresholds
        {
            get
            {
                return maximumThresholds;
            }
            set
            {
                maximumThresholds = value;
            }
        }

        public Bgr MinimumThresholds
        {
            get
            {
                return minimumThresholds;
            }
            set
            {
                minimumThresholds = value;
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

        public string FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
            }
        }

        public int StartFrame
        {
            get
            {
                return startFrame;
            }
            set
            {
                startFrame = value;
            }
        }

        public int EndFrame
        {
            get
            {
                return endFrame;
            }
            set
            {
                endFrame = value;
            }
        }

        // Constructor
        public Camera()
        {
        }
    }
}
