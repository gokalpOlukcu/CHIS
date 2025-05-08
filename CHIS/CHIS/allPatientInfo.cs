using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHIS
{
    public partial class allPatientInfo : Form
    {
        public allPatientInfo()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pediatricianChief_ALL newForm1 = new pediatricianChief_ALL();
            newForm1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pediatricianChief_Login newForm2 = new pediatricianChief_Login();
            newForm2.Show();
            this.Hide();
        }
    }
}
