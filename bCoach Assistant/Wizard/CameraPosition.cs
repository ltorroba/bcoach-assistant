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
    public partial class CameraPosition : Form
    {
        public double X { get; set; }
        public double Y { get; set; }
        public decimal Angle { get; set; }

        public CameraPosition()
        {
            X = -999;
            Y = -999;
            Angle = -1;

            InitializeComponent();            
        }

        public CameraPosition(double x, double y, decimal angle)
        {
            X = x;
            Y = y;
            Angle = angle;

            InitializeComponent();
        }

        private void position_ok_Click(object sender, EventArgs e)
        {
            try
            {
                X = Convert.ToDouble(position_x.Text);
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("That is not a valid X coordinate. Your X coordinate must only contain numbers and a decimal separator.");
                return;
            }

            try
            {
                Y = Convert.ToDouble(position_y.Text);
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("That is not a valid Y coordinate. Your Y coordinate must only contain numbers and a decimal separator.");
                return;
            }

            try
            {
                Angle = Convert.ToDecimal(position_angle.Text);
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("That is not a valid angle. Your angle must only contain numbers and a decimal separator.");
                return;
            }

            this.Close();
        }

        private void CameraPosition_Load(object sender, EventArgs e)
        {
            if(X != -999 && Y != -999 && Angle != -1)
            {
                position_x.Text = X.ToString();
                position_y.Text = Y.ToString();
                position_angle.Text = Angle.ToString();
            }
        }
    }
}
