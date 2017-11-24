namespace WindowsFormsSolution
{
    partial class MainForm
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
        /// 
        private void InitializeLoginComponent()
        {

        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SearchButton = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.ProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MeetingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.ProfilePage = new System.Windows.Forms.Panel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginEmailLabel = new System.Windows.Forms.Label();
            this.LoginPasswordLabel = new System.Windows.Forms.Label();
            this.LoginEmalBox = new System.Windows.Forms.TextBox();
            this.LoginForgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.LoginPasswordBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.ProfilePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(1164, 0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 45);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.TabStop = false;
            this.SearchButton.Text = "Søg";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(80)))));
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfileMenuItem,
            this.MeetingsMenuItem,
            this.ProjectsMenuItem,
            this.UsersMenuItem,
            this.CustomersMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1264, 45);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "MainMenu";
            // 
            // ProfileMenuItem
            // 
            this.ProfileMenuItem.AutoSize = false;
            this.ProfileMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.ProfileMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ProfileMenuItem.Image")));
            this.ProfileMenuItem.Name = "ProfileMenuItem";
            this.ProfileMenuItem.Size = new System.Drawing.Size(100, 41);
            this.ProfileMenuItem.Text = "Profil";
            this.ProfileMenuItem.Click += new System.EventHandler(this.ProfileMenuItem_Click);
            // 
            // MeetingsMenuItem
            // 
            this.MeetingsMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.MeetingsMenuItem.Name = "MeetingsMenuItem";
            this.MeetingsMenuItem.Size = new System.Drawing.Size(108, 41);
            this.MeetingsMenuItem.Text = "Møder";
            this.MeetingsMenuItem.Click += new System.EventHandler(this.MeetingsMenuItem_Click);
            // 
            // ProjectsMenuItem
            // 
            this.ProjectsMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.ProjectsMenuItem.Name = "ProjectsMenuItem";
            this.ProjectsMenuItem.Size = new System.Drawing.Size(135, 41);
            this.ProjectsMenuItem.Text = "Projekter";
            // 
            // UsersMenuItem
            // 
            this.UsersMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.UsersMenuItem.Name = "UsersMenuItem";
            this.UsersMenuItem.Size = new System.Drawing.Size(121, 41);
            this.UsersMenuItem.Text = "Brugere";
            // 
            // CustomersMenuItem
            // 
            this.CustomersMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.CustomersMenuItem.Name = "CustomersMenuItem";
            this.CustomersMenuItem.Size = new System.Drawing.Size(114, 41);
            this.CustomersMenuItem.Text = "Kunder";
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.Location = new System.Drawing.Point(908, 7);
            this.SearchBar.MaxLength = 300;
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(250, 30);
            this.SearchBar.TabIndex = 5;
            // 
            // ProfilePage
            // 
            this.ProfilePage.Controls.Add(this.LoginLabel);
            this.ProfilePage.Controls.Add(this.LoginEmailLabel);
            this.ProfilePage.Controls.Add(this.LoginPasswordLabel);
            this.ProfilePage.Controls.Add(this.LoginEmalBox);
            this.ProfilePage.Controls.Add(this.LoginForgotPasswordLink);
            this.ProfilePage.Controls.Add(this.LoginPasswordBox);
            this.ProfilePage.Controls.Add(this.LoginButton);
            this.ProfilePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfilePage.Location = new System.Drawing.Point(0, 45);
            this.ProfilePage.Name = "ProfilePage";
            this.ProfilePage.Size = new System.Drawing.Size(1264, 717);
            this.ProfilePage.TabIndex = 7;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1264, 762);
            this.LoginPanel.TabIndex = 11;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(589, 288);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(89, 31);
            this.LoginLabel.TabIndex = 17;
            this.LoginLabel.Text = "Log In";
            // 
            // LoginEmailLabel
            // 
            this.LoginEmailLabel.AutoSize = true;
            this.LoginEmailLabel.Location = new System.Drawing.Point(531, 325);
            this.LoginEmailLabel.Name = "LoginEmailLabel";
            this.LoginEmailLabel.Size = new System.Drawing.Size(35, 13);
            this.LoginEmailLabel.TabIndex = 16;
            this.LoginEmailLabel.Text = "Email:";
            // 
            // LoginPasswordLabel
            // 
            this.LoginPasswordLabel.AutoSize = true;
            this.LoginPasswordLabel.Location = new System.Drawing.Point(531, 364);
            this.LoginPasswordLabel.Name = "LoginPasswordLabel";
            this.LoginPasswordLabel.Size = new System.Drawing.Size(50, 13);
            this.LoginPasswordLabel.TabIndex = 15;
            this.LoginPasswordLabel.Text = "Kodeord:";
            // 
            // LoginEmalBox
            // 
            this.LoginEmalBox.Location = new System.Drawing.Point(534, 341);
            this.LoginEmalBox.Name = "LoginEmalBox";
            this.LoginEmalBox.Size = new System.Drawing.Size(200, 20);
            this.LoginEmalBox.TabIndex = 14;
            // 
            // LoginForgotPasswordLink
            // 
            this.LoginForgotPasswordLink.AutoSize = true;
            this.LoginForgotPasswordLink.Location = new System.Drawing.Point(657, 411);
            this.LoginForgotPasswordLink.Name = "LoginForgotPasswordLink";
            this.LoginForgotPasswordLink.Size = new System.Drawing.Size(77, 13);
            this.LoginForgotPasswordLink.TabIndex = 13;
            this.LoginForgotPasswordLink.TabStop = true;
            this.LoginForgotPasswordLink.Text = "Glemt Kodeord";
            // 
            // LoginPasswordBox
            // 
            this.LoginPasswordBox.Location = new System.Drawing.Point(534, 380);
            this.LoginPasswordBox.Name = "LoginPasswordBox";
            this.LoginPasswordBox.Size = new System.Drawing.Size(200, 20);
            this.LoginPasswordBox.TabIndex = 12;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(534, 406);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 11;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.ProfilePage);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.LoginPanel);
            this.Name = "MainForm";
            this.Text = "Fjorblink Meeting Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ProfilePage.ResumeLayout(false);
            this.ProfilePage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MeetingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProjectsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsersMenuItem;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.ToolStripMenuItem CustomersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfileMenuItem;
        private System.Windows.Forms.Panel ProfilePage;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label LoginEmailLabel;
        private System.Windows.Forms.Label LoginPasswordLabel;
        private System.Windows.Forms.TextBox LoginEmalBox;
        private System.Windows.Forms.LinkLabel LoginForgotPasswordLink;
        private System.Windows.Forms.TextBox LoginPasswordBox;
        private System.Windows.Forms.Button LoginButton;
    }
}

