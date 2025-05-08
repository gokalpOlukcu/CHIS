namespace CHIS
{
    partial class pediatricianManage
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
            medicalBTN = new Button();
            button1 = new Button();
            searchByDate = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label17 = new Label();
            dateTimePicker4 = new DateTimePicker();
            groupBox2 = new GroupBox();
            button3 = new Button();
            dateTimePicker3 = new DateTimePicker();
            label16 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            backPage = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // medicalBTN
            // 
            medicalBTN.Location = new Point(805, 22);
            medicalBTN.Name = "medicalBTN";
            medicalBTN.Size = new Size(174, 39);
            medicalBTN.TabIndex = 67;
            medicalBTN.Text = "Insert Medical Information";
            medicalBTN.UseVisualStyleBackColor = true;
            medicalBTN.Click += medicalBTN_Click;
            // 
            // button1
            // 
            button1.Location = new Point(452, 22);
            button1.Name = "button1";
            button1.Size = new Size(136, 23);
            button1.TabIndex = 65;
            button1.Text = "Search By Name";
            button1.UseVisualStyleBackColor = true;
            // 
            // searchByDate
            // 
            searchByDate.Location = new Point(291, 48);
            searchByDate.Name = "searchByDate";
            searchByDate.Size = new Size(102, 23);
            searchByDate.TabIndex = 64;
            searchByDate.Text = "Search by date";
            searchByDate.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(291, 24);
            button2.Name = "button2";
            button2.Size = new Size(102, 23);
            button2.TabIndex = 63;
            button2.Text = "List";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(594, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 66;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.Location = new Point(13, 46);
            label17.Name = "label17";
            label17.Size = new Size(65, 15);
            label17.TabIndex = 36;
            label17.Text = "Last Date :";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(84, 46);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(200, 23);
            dateTimePicker4.TabIndex = 35;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(backPage);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(medicalBTN);
            groupBox2.Controls.Add(textBox1);
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
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "SEARCH SYSTEM";
            // 
            // button3
            // 
            button3.Location = new Point(985, 22);
            button3.Name = "button3";
            button3.Size = new Size(174, 39);
            button3.TabIndex = 69;
            button3.Text = "Pediatrician Users Panel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(84, 22);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 33;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label16.Location = new Point(11, 28);
            label16.Name = "label16";
            label16.Size = new Size(67, 15);
            label16.TabIndex = 34;
            label16.Text = "Fırst Date :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1335, 605);
            dataGridView1.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(1173, 698);
            button4.Name = "button4";
            button4.Size = new Size(174, 39);
            button4.TabIndex = 70;
            button4.Text = "Go Previus Pages";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // backPage
            // 
            backPage.Location = new Point(1161, 22);
            backPage.Name = "backPage";
            backPage.Size = new Size(168, 39);
            backPage.TabIndex = 70;
            backPage.Text = "Go Back Page";
            backPage.UseVisualStyleBackColor = true;
            backPage.Click += backPage_Click;
            // 
            // pediatricianManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1370, 749);
            Controls.Add(button4);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Name = "pediatricianManage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pediatrician Management System";
            Load += pediatricianManage_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button medicalBTN;
        private Button button1;
        private Button searchByDate;
        private Button button2;
        private TextBox textBox1;
        private Label label17;
        private DateTimePicker dateTimePicker4;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker3;
        private Label label16;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Button backPage;
    }
}