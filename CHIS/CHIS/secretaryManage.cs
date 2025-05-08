using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CHIS
{
    public partial class secretaryManage : Form
    {
        public secretaryManage()
        {
            InitializeComponent();
        }

        sqlConnection bgl = new sqlConnection();

        void secretaryList()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM patient", bgl.baglanti());
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        void dateS()
        {
            SqlCommand komut = new SqlCommand("select * where Date between @t1 and @t2", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            komut.Parameters.AddWithValue("@t1", dateTimePicker3.Value);
            komut.Parameters.AddWithValue("@t2", dateTimePicker4.Value);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }

        void nameS()
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM patient WHERE nameSurname = @t1", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            komut.Parameters.AddWithValue("@t1", search.Text);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }
        void deleteArea()
        {
            nameSurname.Text = "";
            age.Text = "";
            tcNumberpatient.Text = "";
            bloodGroup.Text = "";
            allergies.Text = "";
            chronicDiseases.Text = "";
            id.Text = "";
            contMedicine.Text = "";
            degreRel.Text = "";
            parentNames.Text = "";
            parentTC.Text = "";
            parentNumber.Text = "";
            adress.Text = "";
            gender.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
        }
        private void secretaryManage_Load(object sender, EventArgs e)
        {
            secretaryList();
        }

        private void cleanBTN_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            secretaryList();
        }

        private void searchByDate_Click(object sender, EventArgs e)
        {
            dateS();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(@"INSERT INTO patient 
            (Registration_Date, Name_Surname, DateofBirth, Gender, Age, TC_Number, Blood_Group, Allergies, Chronic_Diseases, ContinuouslyUsed_Medications, Degree_of_Relationship, Parent_NameSurname, Parent_TC_Number, Parent_Contact_Number, Address, Approval) 
            VALUES (@Registration_Date, @Name_Surname, @DateofBirth, @Gender, @Age, @TC_Number, @Blood_Group, @Allergies, @Chronic_Diseases, @ContinuouslyUsed_Medications, @Degree_of_Relationship, @Parent_NameSurname, @Parent_TC_Number, @Parent_Contact_Number, @Address, @Approval)", bgl.baglanti());



            command.Parameters.AddWithValue("@Registration_Date", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@Name_Surname", nameSurname.Text);
            command.Parameters.AddWithValue("@DateofBirth", dateTimePicker2.Value);
            command.Parameters.AddWithValue("@Gender", gender.Text);
            command.Parameters.AddWithValue("@Age", age.Text);
            command.Parameters.AddWithValue("@TC_Number", tcNumberpatient.Text);
            command.Parameters.AddWithValue("@Blood_Group", bloodGroup.Text);
            command.Parameters.AddWithValue("@Allergies", allergies.Text);
            command.Parameters.AddWithValue("@Chronic_Diseases", chronicDiseases.Text);
            command.Parameters.AddWithValue("@ContinuouslyUsed_Medications", contMedicine.Text);
            command.Parameters.AddWithValue("@Degree_of_Relationship", degreRel.Text);
            command.Parameters.AddWithValue("@Parent_NameSurname", parentNames.Text);
            command.Parameters.AddWithValue("@Parent_TC_Number", parentTC.Text);
            command.Parameters.AddWithValue("@Parent_Contact_Number", parentNumber.Text);
            command.Parameters.AddWithValue("@Address", adress.Text);
            command.Parameters.AddWithValue("@Approval", approval.Text);


            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Insert Patient Succesfully", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            deleteArea();
            secretaryList();

        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE patient SET Registration_Date = @Registration_Date, Name_Surname = @Name_Surname, DateofBirth = @DateofBirth, Gender = @Gender, Age = @Age, TC_Number = @TC_Number, Blood_Group = @Blood_Group, Allergies = @Allergies, Chronic_Diseases = @Chronic_Diseases, ContinuouslyUsed_Medications = @ContinuouslyUsed_Medications, Degree_of_Relationship = @Degree_of_Relationship, Parent_NameSurname = @Parent_NameSurname, Parent_TC_Number = @Parent_TC_Number, Parent_Contact_Number = @Parent_Contact_Number, Address = @Address, Approval=@Approval  WHERE ID = @ID", bgl.baglanti());

            command.Parameters.AddWithValue("@Registration_Date", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@Name_Surname", nameSurname.Text);
            command.Parameters.AddWithValue("@DateofBirth", dateTimePicker2.Value);
            command.Parameters.AddWithValue("@Gender", gender.Text);
            command.Parameters.AddWithValue("@Age", age.Text);
            command.Parameters.AddWithValue("@TC_Number", tcNumberpatient.Text);
            command.Parameters.AddWithValue("@Blood_Group", bloodGroup.Text);
            command.Parameters.AddWithValue("@Allergies", allergies.Text);
            command.Parameters.AddWithValue("@Chronic_Diseases", chronicDiseases.Text);
            command.Parameters.AddWithValue("@ContinuouslyUsed_Medications", contMedicine.Text);
            command.Parameters.AddWithValue("@Degree_of_Relationship", degreRel.Text);
            command.Parameters.AddWithValue("@Parent_NameSurname", parentNames.Text);
            command.Parameters.AddWithValue("@Parent_TC_Number", parentTC.Text);
            command.Parameters.AddWithValue("@Parent_Contact_Number", parentNumber.Text);
            command.Parameters.AddWithValue("@Address", adress.Text);
            command.Parameters.AddWithValue("@ID", id.Text);
            command.Parameters.AddWithValue("@Approval", approval.Text);

            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Update Patient Succesfully", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            deleteArea();
            secretaryList();
        }

        private void cleanBTN_Click_1(object sender, EventArgs e)
        {
            secretaryList();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM patient where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", id.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Delete Patient Succesfully", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            deleteArea();
            secretaryList();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                dateTimePicker1.Text = row.Cells["Registration_Date"].Value?.ToString();
                nameSurname.Text = row.Cells["Name_Surname"].Value?.ToString();
                dateTimePicker2.Text = row.Cells["DateofBirth"].Value?.ToString();
                gender.Text = row.Cells["Gender"].Value?.ToString();
                age.Text = row.Cells["Age"].Value?.ToString();
                tcNumberpatient.Text = row.Cells["TC_Number"].Value?.ToString();
                bloodGroup.Text = row.Cells["Blood_Group"].Value?.ToString();
                allergies.Text = row.Cells["Allergies"].Value?.ToString();
                chronicDiseases.Text = row.Cells["Chronic_Diseases"].Value?.ToString();
                id.Text = row.Cells["ID"].Value?.ToString();
                contMedicine.Text = row.Cells["ContinuouslyUsed_Medications"].Value?.ToString();
                degreRel.Text = row.Cells["Degree_of_Relationship"].Value?.ToString();
                parentNames.Text = row.Cells["Parent_NameSurname"].Value?.ToString();
                parentTC.Text = row.Cells["Parent_TC_Number"].Value?.ToString();
                parentNumber.Text = row.Cells["Parent_Contact_Number"].Value?.ToString();
                adress.Text = row.Cells["Address"].Value?.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            secrateryUsers newForm5 = new secrateryUsers();
            newForm5.Show();
            this.Hide();
        }

        private void medicalBTN_Click(object sender, EventArgs e)
        {
            medical_Info newForm6 = new medical_Info();
            newForm6.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            personel newForm7 = new personel();
            newForm7.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameS();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            secretaryList();
        }

        private void searchByDate_Click_1(object sender, EventArgs e)
        {

        }
    }
}
