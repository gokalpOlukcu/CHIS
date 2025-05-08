namespace CHIS
{
    partial class baseScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baseScreen));
            pictureBox3 = new PictureBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            groupBox3 = new GroupBox();
            button3 = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.foto1;
            pictureBox3.Location = new Point(21, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(612, 305);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Location = new Point(227, 425);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 222);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personel";
            // 
            // button2
            // 
            button2.Location = new Point(37, 155);
            button2.Name = "button2";
            button2.Size = new Size(125, 51);
            button2.TabIndex = 6;
            button2.Text = "Login Screen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._8700f412e3a561e7f3e4929f55017961;
            pictureBox2.Location = new Point(37, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 127);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(21, 425);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 222);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient";
            // 
            // button1
            // 
            button1.Location = new Point(37, 155);
            button1.Name = "button1";
            button1.Size = new Size(125, 51);
            button1.TabIndex = 6;
            button1.Text = "Appointment Registration Screen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FT_media_dr_Didou__Hopital_Pourtales_Neuchatel_Photo_Stephane_Etter_640x427;
            pictureBox1.Location = new Point(37, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(21, 323);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(612, 96);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(pictureBox4);
            groupBox3.Location = new Point(433, 425);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 225);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pharmacist";
            // 
            // button3
            // 
            button3.Location = new Point(37, 155);
            button3.Name = "button3";
            button3.Size = new Size(125, 51);
            button3.TabIndex = 6;
            button3.Text = "Pharmacy Login Screen";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.eczaci_kalfasi_egitimi_sertifikasiuniver_c429;
            pictureBox4.Location = new Point(37, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 127);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // baseScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(643, 662);
            Controls.Add(groupBox3);
            Controls.Add(richTextBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox3);
            Name = "baseScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Children's Hospital Information System Home Screen";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox3;
        private GroupBox groupBox2;
        private Button button2;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private GroupBox groupBox3;
        private Button button3;
        private PictureBox pictureBox4;
    }
}
