namespace CHIS
{
    partial class adminManagement
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
            menuStrip1 = new MenuStrip();
            programToolStripMenuItem = new ToolStripMenuItem();
            peToolStripMenuItem = new ToolStripMenuItem();
            pediatricianChiefToolStripMenuItem = new ToolStripMenuItem();
            pediatricianToolStripMenuItem = new ToolStripMenuItem();
            pediatricianPersonnelManagementToolStripMenuItem = new ToolStripMenuItem();
            pharmacistToolStripMenuItem = new ToolStripMenuItem();
            pharmacistPersonnelManagementToolStripMenuItem = new ToolStripMenuItem();
            secretaryToolStripMenuItem = new ToolStripMenuItem();
            secretaryPersonnelManagementToolStripMenuItem = new ToolStripMenuItem();
            adminPanelToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem, peToolStripMenuItem, pediatricianToolStripMenuItem, pharmacistToolStripMenuItem, secretaryToolStripMenuItem, adminPanelToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new Size(65, 20);
            programToolStripMenuItem.Text = "Program";
            // 
            // peToolStripMenuItem
            // 
            peToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pediatricianChiefToolStripMenuItem });
            peToolStripMenuItem.Name = "peToolStripMenuItem";
            peToolStripMenuItem.Size = new Size(112, 20);
            peToolStripMenuItem.Text = "Pediatrician Chief";
            peToolStripMenuItem.Click += peToolStripMenuItem_Click;
            // 
            // pediatricianChiefToolStripMenuItem
            // 
            pediatricianChiefToolStripMenuItem.Name = "pediatricianChiefToolStripMenuItem";
            pediatricianChiefToolStripMenuItem.Size = new Size(296, 22);
            pediatricianChiefToolStripMenuItem.Text = "Pediatrician Chief Personnel Management";
            // 
            // pediatricianToolStripMenuItem
            // 
            pediatricianToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pediatricianPersonnelManagementToolStripMenuItem });
            pediatricianToolStripMenuItem.Name = "pediatricianToolStripMenuItem";
            pediatricianToolStripMenuItem.Size = new Size(81, 20);
            pediatricianToolStripMenuItem.Text = "Pediatrician";
            // 
            // pediatricianPersonnelManagementToolStripMenuItem
            // 
            pediatricianPersonnelManagementToolStripMenuItem.Name = "pediatricianPersonnelManagementToolStripMenuItem";
            pediatricianPersonnelManagementToolStripMenuItem.Size = new Size(265, 22);
            pediatricianPersonnelManagementToolStripMenuItem.Text = "Pediatrician Personnel Management";
            // 
            // pharmacistToolStripMenuItem
            // 
            pharmacistToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pharmacistPersonnelManagementToolStripMenuItem });
            pharmacistToolStripMenuItem.Name = "pharmacistToolStripMenuItem";
            pharmacistToolStripMenuItem.Size = new Size(78, 20);
            pharmacistToolStripMenuItem.Text = "Pharmacist";
            // 
            // pharmacistPersonnelManagementToolStripMenuItem
            // 
            pharmacistPersonnelManagementToolStripMenuItem.Name = "pharmacistPersonnelManagementToolStripMenuItem";
            pharmacistPersonnelManagementToolStripMenuItem.Size = new Size(262, 22);
            pharmacistPersonnelManagementToolStripMenuItem.Text = "Pharmacist Personnel Management";
            // 
            // secretaryToolStripMenuItem
            // 
            secretaryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { secretaryPersonnelManagementToolStripMenuItem });
            secretaryToolStripMenuItem.Name = "secretaryToolStripMenuItem";
            secretaryToolStripMenuItem.Size = new Size(67, 20);
            secretaryToolStripMenuItem.Text = "Secretary";
            // 
            // secretaryPersonnelManagementToolStripMenuItem
            // 
            secretaryPersonnelManagementToolStripMenuItem.Name = "secretaryPersonnelManagementToolStripMenuItem";
            secretaryPersonnelManagementToolStripMenuItem.Size = new Size(251, 22);
            secretaryPersonnelManagementToolStripMenuItem.Text = "Secretary Personnel Management";
            // 
            // adminPanelToolStripMenuItem
            // 
            adminPanelToolStripMenuItem.Name = "adminPanelToolStripMenuItem";
            adminPanelToolStripMenuItem.Size = new Size(89, 20);
            adminPanelToolStripMenuItem.Text = "Admin-Panel";
            // 
            // adminManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "adminManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Management System";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem peToolStripMenuItem;
        private ToolStripMenuItem pediatricianToolStripMenuItem;
        private ToolStripMenuItem pharmacistToolStripMenuItem;
        private ToolStripMenuItem secretaryToolStripMenuItem;
        private ToolStripMenuItem adminPanelToolStripMenuItem;
        private ToolStripMenuItem pediatricianChiefToolStripMenuItem;
        private ToolStripMenuItem pediatricianPersonnelManagementToolStripMenuItem;
        private ToolStripMenuItem pharmacistPersonnelManagementToolStripMenuItem;
        private ToolStripMenuItem secretaryPersonnelManagementToolStripMenuItem;
    }
}