using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using bCoach_Assistant.Wizard;
using bCoach_Assistant.Analyser;

namespace bCoach_Assistant
{
    public partial class Initial : Form
    {
        public Initial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnalysisCreationWizard acw = new AnalysisCreationWizard(this);
            acw.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();

            this.Hide();
        }
    }
}
