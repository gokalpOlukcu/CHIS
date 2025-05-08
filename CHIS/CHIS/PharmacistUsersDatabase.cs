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
    public partial class PharmacistUsersDatabase : Form
    {
        public PharmacistUsersDatabase()
        {
            InitializeComponent();
        }

        sqlConnection bgl = new sqlConnection();

        void deleteArea()
        {
            id.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker3.Text = "";
            dateTimePicker4.Text = "";
            department.Text = "";
            position.Text = "";
            name.Text = "";
            surname.Text = "";
            usercode.Text = "";
            securityCode.Text = "";
        }

        void dateS()
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM pharmacist WHERE Date BETWEEN @t1 AND @t2", bgl.baglanti());
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
            SqlCommand komut = new SqlCommand("SELECT * FROM pharmacist WHERE Name = @t1", bgl.baglanti());
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM pharmacist", bgl.baglanti());
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void PharmacistUsersDatabase_Load(object sender, EventArgs e)
        {
            List();
        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(@"INSERT INTO pharmacist (Date, Department, Position, Name, Surname, UserCode, SecurityCode) VALUES (@Date, @Department, @Position, @Name, @Surname, @UserCode, @SecurityCode)", bgl.baglanti());

            command.Parameters.AddWithValue("@Date", dateTimePicker1.Value); // Tarih için DateTime kullanımı
            command.Parameters.AddWithValue("@Department", department.Text);
            command.Parameters.AddWithValue("@Position", position.Text);
            command.Parameters.AddWithValue("@Name", name.Text);
            command.Parameters.AddWithValue("@Surname", surname.Text);
            command.Parameters.AddWithValue("@UserCode", usercode.Text);
            command.Parameters.AddWithValue("@SecurityCode", securityCode.Text);

            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Insert Pharmacist Succesfully", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            deleteArea();
            List();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE pharmacist SET Date = @Date, Department = @Department, Position = @Position, Name = @Name, Surname = @Surname, UserCode = @UserCode, SecurityCode = @SecurityCode WHERE ID = @ID", bgl.baglanti());

            command.Parameters.AddWithValue("@ID", id.Text);
            command.Parameters.AddWithValue("@Date", dateTimePicker1.Value); // Tarih için DateTime kullanımı
            command.Parameters.AddWithValue("@Department", department.Text);
            command.Parameters.AddWithValue("@Position", position.Text);
            command.Parameters.AddWithValue("@Name", name.Text);
            command.Parameters.AddWithValue("@Surname", surname.Text);
            command.Parameters.AddWithValue("@UserCode", usercode.Text);
            command.Parameters.AddWithValue("@SecurityCode", securityCode.Text);


            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Update Pharmacist Succesfully", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            deleteArea();
            List();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameS();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List();
        }

        private void searchByDate_Click(object sender, EventArgs e)
        {
            dateS();
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
                name.Text = row.Cells["Name"].Value?.ToString();
                surname.Text = row.Cells["Surname"].Value?.ToString();
                usercode.Text = row.Cells["UserCode"].Value?.ToString();
                securityCode.Text = row.Cells["SecurityCode"].Value?.ToString();
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM pharmacist where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", id.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Delete Pharmacist Succesfully", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            deleteArea();
            List();
        }

        private void cleanBTN_Click(object sender, EventArgs e)
        {
            deleteArea();
        }
    }
}
