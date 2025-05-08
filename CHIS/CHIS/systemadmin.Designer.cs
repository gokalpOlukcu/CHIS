namespace CHIS
{
    partial class systemadmin
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
            groupBox3 = new GroupBox();
            richTextBox1 = new RichTextBox();
            deleteUser = new Button();
            cleanTextBoxes = new Button();
            updateUser = new Button();
            addUser = new Button();
            label2 = new Label();
            label1 = new Label();
            securityCode = new TextBox();
            userCode = new TextBox();
            loginButton = new Button();
            pictureBox4 = new PictureBox();
            backPage = new Button();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Controls.Add(deleteUser);
            groupBox3.Controls.Add(cleanTextBoxes);
            groupBox3.Controls.Add(updateUser);
            groupBox3.Controls.Add(addUser);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(securityCode);
            groupBox3.Controls.Add(userCode);
            groupBox3.Controls.Add(loginButton);
            groupBox3.Controls.Add(pictureBox4);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(241, 597);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "System Admin Login Panel";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(19, 313);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(206, 100);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "After the user addition request is approved by the admin, you can log in to the system.";
            // 
            // deleteUser
            // 
            deleteUser.Location = new Point(19, 489);
            deleteUser.Name = "deleteUser";
            deleteUser.Size = new Size(100, 63);
            deleteUser.TabIndex = 13;
            deleteUser.Text = "System Admin Delete User";
            deleteUser.UseVisualStyleBackColor = true;
            deleteUser.Click += deleteUser_Click;
            // 
            // cleanTextBoxes
            // 
            cleanTextBoxes.Location = new Point(125, 495);
            cleanTextBoxes.Name = "cleanTextBoxes";
            cleanTextBoxes.Size = new Size(100, 57);
            cleanTextBoxes.TabIndex = 14;
            cleanTextBoxes.Text = "System Admin Textboxes Clean";
            cleanTextBoxes.UseVisualStyleBackColor = true;
            cleanTextBoxes.Click += cleanTextBoxes_Click;
            // 
            // updateUser
            // 
            updateUser.Location = new Point(125, 432);
            updateUser.Name = "updateUser";
            updateUser.Size = new Size(100, 62);
            updateUser.TabIndex = 12;
            updateUser.Text = "System Admin Update User";
            updateUser.UseVisualStyleBackColor = true;
            updateUser.Click += updateUser_Click;
            // 
            // addUser
            // 
            addUser.Location = new Point(19, 432);
            addUser.Name = "addUser";
            addUser.Size = new Size(100, 62);
            addUser.TabIndex = 11;
            addUser.Text = "System Admin Add User";
            addUser.UseVisualStyleBackColor = true;
            addUser.Click += addUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 204);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 10;
            label2.Text = "Security Code :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 175);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 9;
            label1.Text = "User Code :";
            // 
            // securityCode
            // 
            securityCode.Location = new Point(111, 201);
            securityCode.Name = "securityCode";
            securityCode.Size = new Size(100, 23);
            securityCode.TabIndex = 8;
            // 
            // userCode
            // 
            userCode.Location = new Point(111, 172);
            userCode.Name = "userCode";
            userCode.Size = new Size(100, 23);
            userCode.TabIndex = 7;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(19, 242);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(192, 51);
            loginButton.TabIndex = 6;
            loginButton.Text = "System Admin Login Panel";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.images;
            pictureBox4.Location = new Point(57, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 127);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // backPage
            // 
            backPage.Location = new Point(153, 615);
            backPage.Name = "backPage";
            backPage.Size = new Size(100, 33);
            backPage.TabIndex = 14;
            backPage.Text = "Go Back Page";
            backPage.UseVisualStyleBackColor = true;
            backPage.Click += backPage_Click;
            // 
            // systemadmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(276, 654);
            Controls.Add(backPage);
            Controls.Add(groupBox3);
            Name = "systemadmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "System Admin Login Page";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private RichTextBox richTextBox1;
        private Button deleteUser;
        private Button cleanTextBoxes;
        private Button updateUser;
        private Button addUser;
        private Label label2;
        private Label label1;
        private TextBox securityCode;
        private TextBox userCode;
        private Button loginButton;
        private PictureBox pictureBox4;
        private Button backPage;
    }
}