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
    public partial class pediatrician : Form
    {
        public pediatrician()
        {
            InitializeComponent();
        }

        private void backPage_Click(object sender, EventArgs e)
        {
            personel newForm1 = new personel();
            newForm1.Show();
            this.Hide();
        }
        sqlConnection bgl = new sqlConnection();
        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM pediatrician WHERE UserCode=@p1 and SecurityCode=@p2 and Approval=1", bgl.baglanti());
            command.Parameters.AddWithValue("@P1", userCode.Text);
            command.Parameters.AddWithValue("@P2", securityCode.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("User code or password is correct. Welcome the system.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pediatricianManage newForm2 = new pediatricianManage();
                newForm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("If the user code or password is incorrect or your user action is not confirmed, please contact the super administrator.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close(); 
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into pediatrician (UserCode,SecurityCode) VALUES (@p1,@p2)", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", userCode.Text);
            command.Parameters.AddWithValue("@p2", securityCode.Text);

            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("New user added to the system.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("New user not added to the system.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }

        private void updateUser_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE pediatrician SET UserCode=@p1, SecurityCode=@p2 where Approval=1", bgl.baglanti());

            command.Parameters.AddWithValue("@p1", userCode.Text);
            command.Parameters.AddWithValue("@p2", securityCode.Text);

            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("New user updated in the system", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("New user updated in the system.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void cleanTextBoxes_Click(object sender, EventArgs e)
        {
            userCode.Text = "";
            securityCode.Text = "";
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM pediatrician WHERE UserCode = @P1 AND SecurityCode = @P2 AND Approval = 1", bgl.baglanti());
            command.Parameters.AddWithValue("@P1", userCode.Text);
            command.Parameters.AddWithValue("@P2", securityCode.Text);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("User deleted successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("If the user code or password is incorrect or your user action is not confirmed, please contact the super administrator.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
