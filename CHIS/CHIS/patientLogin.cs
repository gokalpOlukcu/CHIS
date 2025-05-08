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
    public partial class patient_Login : Form
    {
        public patient_Login()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();

        void deleteArea()
        {
            nameSurname.Text = "";
            age.Text = "";
            tcNumberpatient.Text = "";
            bloodGroup.Text = "";
            gender.Text = "";
            dateTimePicker1.Text = "";
        }
        private void patient_Login_Load(object sender, EventArgs e)
        {

        }

        private void cleanBTN_Click(object sender, EventArgs e)
        {


        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            SqlCommand checkCommand = new SqlCommand(@"SELECT COUNT(*) FROM patient WHERE Registration_Date = @Registration_Date", bgl.baglanti());
            checkCommand.Parameters.AddWithValue("@Registration_Date", dateTimePicker1.Value);

            int count = (int)checkCommand.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("There is already a registration for this date!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Yeni kayıt ekleme işlemi
                SqlCommand command = new SqlCommand(@"INSERT INTO patient (Registration_Date, Name_Surname, Gender, Age, TC_Number, Blood_Group)  VALUES (@Registration_Date, @Name_Surname, @Gender, @Age, @TC_Number, @Blood_Group)", bgl.baglanti());

                command.Parameters.AddWithValue("@Registration_Date", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@Name_Surname", nameSurname.Text);
                command.Parameters.AddWithValue("@Gender", gender.Text);
                command.Parameters.AddWithValue("@Age", age.Text);
                command.Parameters.AddWithValue("@TC_Number", tcNumberpatient.Text);
                command.Parameters.AddWithValue("@Blood_Group", bloodGroup.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("Insert Patient Successfully", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                deleteArea(); // Alanları temizleme işlemi
            }

            bgl.baglanti().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baseScreen newForm1 = new baseScreen();
            newForm1.Show();
            this.Hide();
        }
    }
}
