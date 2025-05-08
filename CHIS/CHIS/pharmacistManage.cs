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
    public partial class pharmacistManage : Form
    {
        public pharmacistManage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personel newForm1 = new personel();
            newForm1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PharmacistUsersDatabase newForm2 = new PharmacistUsersDatabase();
            newForm2.Show();
            this.Hide();
        }

        private void pharmacistManage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
