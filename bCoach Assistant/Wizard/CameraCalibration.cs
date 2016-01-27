using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bCoach_Assistant.Wizard
{
    public partial class CameraCalibration : Form
    {
        public decimal FocalLength { get; set; }

        public CameraCalibration()
        {
            FocalLength = -1;
            InitializeComponent();            
        }

        public CameraCalibration(decimal focalLength)
        {
            FocalLength = focalLength;
            InitializeComponent();
        }

        private void calibrate_ok_Click(object sender, EventArgs e)
        {
            try
            {
                FocalLength = Convert.ToDecimal(calibrate_focalLength.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("That is not a valid focal length. Your focal length must only contain numbers and a decimal separator.");
                return;
            }

            this.Close();
        }

        private void CameraCalibration_Load(object sender, EventArgs e)
        {
            if (FocalLength != -1)
            {
                calibrate_focalLength.Text = FocalLength.ToString();
            }
        }
    }
}
