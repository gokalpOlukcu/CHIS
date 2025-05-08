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
    public partial class pediatricianManage : Form
    {
        public pediatricianManage()
        {
            InitializeComponent();
        }

        sqlConnection bgl = new sqlConnection();

        void patientList()
        {
            try
            {
                using (SqlConnection conn = bgl.baglanti()) // Bağlantıyı using bloğuna aldık
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM patient WHERE Approval = 1", conn))
                    {
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertBTN_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PediatricianUsers newForm2 = new PediatricianUsers();
            newForm2.Show();
            this.Hide();
        }

        private void medicalBTN_Click(object sender, EventArgs e)
        {
            medical_Info newForm1 = new medical_Info();
            newForm1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            personel newForm3 = new personel();
            newForm3.Show();
            this.Hide();
        }

        private void pediatricianManage_Load(object sender, EventArgs e)
        {
            patientList();
        }

        private void backPage_Click(object sender, EventArgs e)
        {
            personel newForm1 = new personel();
            newForm1.Show();
            this.Hide();
        }
    }
}
