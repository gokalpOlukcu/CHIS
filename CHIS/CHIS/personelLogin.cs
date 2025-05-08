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
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pediatricianChief_Login newForm1 = new pediatricianChief_Login();
            newForm1.Show();
            this.Hide();
        }

        private void pdrBTN_Click(object sender, EventArgs e)
        {
            pediatrician newForm2 = new pediatrician();
            newForm2.Show();
            this.Hide();
        }

        private void secBTN_Click(object sender, EventArgs e)
        {
            healthSecretary newForm3 = new healthSecretary();
            newForm3.Show();
            this.Hide();
        }

        private void adminBTN_Click(object sender, EventArgs e)
        {
            systemadmin newForm4 = new systemadmin();
            newForm4.Show();
            this.Hide();
        }

        private void backPage_Click(object sender, EventArgs e)
        {
            baseScreen newForm5 = new baseScreen();
            newForm5.Show();
            this.Hide();
        }
    }
}
