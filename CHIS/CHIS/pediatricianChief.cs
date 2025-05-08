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
    public partial class pediatricianChief_ALL : Form
    {
        public pediatricianChief_ALL()
        {
            InitializeComponent();
        }

        private void chifBTN_Click(object sender, EventArgs e)
        {
            PediatricianChiefUserDatabases newForm4 = new PediatricianChiefUserDatabases();
            newForm4.Show();
             
        }

        private void pdrBTN_Click(object sender, EventArgs e)
        {
            PediatricianUsers newForm1 = new PediatricianUsers();
            newForm1.Show();
         }

        private void secBTN_Click(object sender, EventArgs e)
        {
            secrateryUsers newForm2 = new secrateryUsers();
            newForm2.Show();
         }

        private void adminBTN_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PharmacistUsersDatabase newForm3 = new PharmacistUsersDatabase();
            newForm3.Show();
         }
    }
}
