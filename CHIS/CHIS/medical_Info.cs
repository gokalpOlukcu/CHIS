using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CHIS
{
    public partial class medical_Info : Form
    {
        public medical_Info()
        {
            InitializeComponent();
        }

        sqlConnection bgl = new sqlConnection();


        private void button3_Click(object sender, EventArgs e)
        {
            secretaryManage newForm1 = new secretaryManage();
            newForm1.Show();
            this.Hide();
        }

        private void medical_Info_Load(object sender, EventArgs e)
        {

        }
    }
}
