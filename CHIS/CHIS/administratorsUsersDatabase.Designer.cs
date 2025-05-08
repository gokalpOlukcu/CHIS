namespace CHIS
{
    partial class administratorsUsersDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(administratorsUsersDatabase));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            position = new TextBox();
            label6 = new Label();
            department = new TextBox();
            ıd = new Label();
            id = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cleanBTN = new Button();
            deleteBTN = new Button();
            updateBTN = new Button();
            insertBTN = new Button();
            label9 = new Label();
            securityCode = new TextBox();
            label4 = new Label();
            usercode = new TextBox();
            label2 = new Label();
            nameSurname = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            searchByDate = new Button();
            button2 = new Button();
            dateTimePicker4 = new DateTimePicker();
            label17 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label16 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            search = new TextBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(position);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(department);
            groupBox1.Controls.Add(ıd);
            groupBox1.Controls.Add(id);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(cleanBTN);
            groupBox1.Controls.Add(deleteBTN);
            groupBox1.Controls.Add(updateBTN);
            groupBox1.Controls.Add(insertBTN);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(securityCode);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(usercode);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nameSurname);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1023, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 605);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Admin Personel İnformation";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(124, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 122);
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(61, 271);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 72;
            label5.Text = "Position :";
            // 
            // position
            // 
            position.Location = new Point(124, 268);
            position.Name = "position";
            position.Size = new Size(197, 23);
            position.TabIndex = 71;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(36, 242);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 70;
            label6.Text = "Department :";
            // 
            // department
            // 
            department.Location = new Point(124, 239);
            department.Name = "department";
            department.Size = new Size(197, 23);
            department.TabIndex = 69;
            // 
            // ıd
            // 
            ıd.AutoSize = true;
            ıd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ıd.Location = new Point(89, 173);
            ıd.Name = "ıd";
            ıd.Size = new Size(26, 15);
            ıd.TabIndex = 68;
            ıd.Text = "ID :";
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(121, 170);
            id.Name = "id";
            id.Size = new Size(200, 23);
            id.TabIndex = 67;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(121, 210);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // cleanBTN
            // 
            cleanBTN.Location = new Point(124, 451);
            cleanBTN.Name = "cleanBTN";
            cleanBTN.Size = new Size(180, 23);
            cleanBTN.TabIndex = 64;
            cleanBTN.Text = "CLEAN";
            cleanBTN.UseVisualStyleBackColor = true;
            cleanBTN.Click += cleanBTN_Click;
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new Point(246, 411);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(75, 23);
            deleteBTN.TabIndex = 63;
            deleteBTN.Text = "DELETE";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // updateBTN
            // 
            updateBTN.Location = new Point(166, 411);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(75, 23);
            updateBTN.TabIndex = 62;
            updateBTN.Text = "UPDATE";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Click += updateBTN_Click;
            // 
            // insertBTN
            // 
            insertBTN.Location = new Point(85, 411);
            insertBTN.Name = "insertBTN";
            insertBTN.Size = new Size(75, 23);
            insertBTN.TabIndex = 61;
            insertBTN.Text = "INSERT";
            insertBTN.UseVisualStyleBackColor = true;
            insertBTN.Click += insertBTN_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(33, 367);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 44;
            label9.Text = "Security Code:";
            // 
            // securityCode
            // 
            securityCode.Location = new Point(124, 364);
            securityCode.Name = "securityCode";
            securityCode.Size = new Size(197, 23);
            securityCode.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(48, 336);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 42;
            label4.Text = "User Code :";
            // 
            // usercode
            // 
            usercode.Location = new Point(124, 333);
            usercode.Name = "usercode";
            usercode.Size = new Size(197, 23);
            usercode.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(19, 300);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 34;
            label2.Text = "Name Surname :";
            // 
            // nameSurname
            // 
            nameSurname.Location = new Point(124, 297);
            nameSurname.Name = "nameSurname";
            nameSurname.Size = new Size(197, 23);
            nameSurname.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(7, 213);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 32;
            label1.Text = "Registration Date :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(995, 606);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // searchByDate
            // 
            searchByDate.Location = new Point(651, 48);
            searchByDate.Name = "searchByDate";
            searchByDate.Size = new Size(102, 23);
            searchByDate.TabIndex = 64;
            searchByDate.Text = "Search by date";
            searchByDate.UseVisualStyleBackColor = true;
            searchByDate.Click += searchByDate_Click;
            // 
            // button2
            // 
            button2.Location = new Point(651, 24);
            button2.Name = "button2";
            button2.Size = new Size(102, 23);
            button2.TabIndex = 63;
            button2.Text = "List";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(444, 46);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(200, 23);
            dateTimePicker4.TabIndex = 35;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.Location = new Point(373, 46);
            label17.Name = "label17";
            label17.Size = new Size(65, 15);
            label17.TabIndex = 36;
            label17.Text = "Last Date :";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(444, 22);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 33;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label16.Location = new Point(371, 28);
            label16.Name = "label16";
            label16.Size = new Size(67, 15);
            label16.TabIndex = 34;
            label16.Text = "Fırst Date :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(search);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(searchByDate);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(dateTimePicker4);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(dateTimePicker3);
            groupBox2.Controls.Add(label16);
            groupBox2.Location = new Point(12, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1335, 75);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "SEARCH SYSTEM";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button3
            // 
            button3.Location = new Point(1223, 19);
            button3.Name = "button3";
            button3.Size = new Size(92, 49);
            button3.TabIndex = 68;
            button3.Text = "Go Back Page";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // search
            // 
            search.Location = new Point(954, 28);
            search.Name = "search";
            search.Size = new Size(180, 23);
            search.TabIndex = 66;
            // 
            // button1
            // 
            button1.Location = new Point(812, 19);
            button1.Name = "button1";
            button1.Size = new Size(136, 42);
            button1.TabIndex = 65;
            button1.Text = "Search By Name_Surname";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(344, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 69;
            pictureBox2.TabStop = false;
            // 
            // administratorsUsersDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 707);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Name = "administratorsUsersDatabase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrators Users Database";
            Load += administratorsUsersDatabase_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label ıd;
        private TextBox id;
        private DateTimePicker dateTimePicker1;
        private Button cleanBTN;
        private Button deleteBTN;
        private Button updateBTN;
        private Button insertBTN;
        private Label label9;
        private TextBox securityCode;
        private Label label4;
        private TextBox usercode;
        private Label label2;
        private TextBox nameSurname;
        private Label label1;
        private DataGridView dataGridView1;
        private Button searchByDate;
        private Button button2;
        private DateTimePicker dateTimePicker4;
        private Label label17;
        private DateTimePicker dateTimePicker3;
        private Label label16;
        private Label label5;
        private TextBox position;
        private Label label6;
        private TextBox department;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private TextBox search;
        private Button button1;
        private Button button3;
        private PictureBox pictureBox2;
    }
}