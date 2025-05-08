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
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace CHIS
{
    public partial class administratorsUsersDatabase : Form
    {
        public administratorsUsersDatabase()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();
        private void button3_Click(object sender, EventArgs e)
        {
            allPatientInfo newForm1 = new allPatientInfo();
            newForm1.Show();
            this.Hide();
        }

        void deleteArea()
        {
            id.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker3.Text = "";
            dateTimePicker4.Text = "";
            department.Text = "";
            position.Text = "";
            nameSurname.Text = "";
            usercode.Text = "";
            securityCode.Text = "";
        }

        void dateS()
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM adminpanel WHERE Date BETWEEN @t1 AND @t2", bgl.baglanti());
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
            SqlCommand komut = new SqlCommand("SELECT * FROM adminpanel WHERE NameSurname = @t1", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            komut.Parameters.AddWithValue("@t1", search.Text);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }

        void List()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM adminpanel", bgl.baglanti());
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void administratorsUsersDatabase_Load(object sender, EventArgs e)
        {
            List();
        }

        private void cleanBTN_Click(object sender, EventArgs e)
        {
            deleteArea();
        }

        private void searchByDate_Click(object sender, EventArgs e)
        {
            dateS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameS();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM adminpanel where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", id.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Delete Admin Succesfully", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            deleteArea();
            List();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                id.Text = row.Cells["ID"].Value?.ToString();
                dateTimePicker1.Text = row.Cells["Date"].Value?.ToString();
                department.Text = row.Cells["Department"].Value?.ToString();
                position.Text = row.Cells["Position"].Value?.ToString();
                nameSurname.Text = row.Cells["NameSurname"].Value?.ToString();
                usercode.Text = row.Cells["UserCode"].Value?.ToString();
                securityCode.Text = row.Cells["SecurityCode"].Value?.ToString();
            }
        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(@"INSERT INTO adminpanel (Date, Department, Position, NameSurname, UserCode, SecurityCode) VALUES (@Date, @Department, @Position, @NameSurname, @UserCode, @SecurityCode)", bgl.baglanti());

            command.Parameters.AddWithValue("@Date", dateTimePicker1.Value); // Tarih için DateTime kullanımı
            command.Parameters.AddWithValue("@Department", department.Text);
            command.Parameters.AddWithValue("@Position", position.Text);
            command.Parameters.AddWithValue("@NameSurname", nameSurname.Text);
            command.Parameters.AddWithValue("@UserCode", usercode.Text);
            command.Parameters.AddWithValue("@SecurityCode", securityCode.Text);

            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Insert Admin Succesfully", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            deleteArea();
            List();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE adminpanel SET Date = @Date, Department = @Department, Position = @Position, NameSurname = @NameSurname, UserCode = @UserCode, SecurityCode = @SecurityCode WHERE ID = @ID", bgl.baglanti());

            command.Parameters.AddWithValue("@ID", id.Text);
            command.Parameters.AddWithValue("@Date", dateTimePicker1.Value); // Tarih için DateTime kullanımı
            command.Parameters.AddWithValue("@Department", department.Text);
            command.Parameters.AddWithValue("@Position", position.Text);
            command.Parameters.AddWithValue("@NameSurname", nameSurname.Text);
            command.Parameters.AddWithValue("@UserCode", usercode.Text);
            command.Parameters.AddWithValue("@SecurityCode", securityCode.Text);


            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Update Admin Succesfully", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            deleteArea();
            List();
        }
    }
}

