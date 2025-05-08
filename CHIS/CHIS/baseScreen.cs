using Microsoft.VisualBasic.Logging;

namespace CHIS
{
    public partial class baseScreen : Form
    {
        public baseScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patient_Login newForm = new patient_Login();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personel newForm1 = new personel();
            newForm1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pharmacist newForm2 = new pharmacist();
            newForm2.Show();
            this.Hide();
        }
    }
}
