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
            this.ProfileTab = new System.Windows.Forms.Panel();
            this.ProfileProjectsLabel = new System.Windows.Forms.Label();
            this.ProfileProjects = new System.Windows.Forms.ListBox();
            this.ProfileMeetingsLabel = new System.Windows.Forms.Label();
            this.ProfileMeetings = new System.Windows.Forms.ListBox();
            this.ProfilePhone = new System.Windows.Forms.Label();
            this.ProfileEmail = new System.Windows.Forms.Label();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.ProfileName = new System.Windows.Forms.Label();
            this.MeetingTab = new System.Windows.Forms.Panel();
            this.ProjectTab = new System.Windows.Forms.Panel();
            this.UserTab = new System.Windows.Forms.Panel();
            this.CustomerTab = new System.Windows.Forms.Panel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginEmailLabel = new System.Windows.Forms.Label();
            this.LoginPasswordLabel = new System.Windows.Forms.Label();
            this.LoginEmalBox = new System.Windows.Forms.TextBox();
            this.LoginForgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.LoginPasswordBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginPage = new System.Windows.Forms.Panel();
            this.MainMenu.SuspendLayout();
            this.ProfileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.LoginPage.SuspendLayout();
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
            this.SearchButton.Visible = false;
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
            this.MainMenu.Visible = false;
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
            this.ProjectsMenuItem.Click += new System.EventHandler(this.ProjectsMenuItem_Click);
            // 
            // UsersMenuItem
            // 
            this.UsersMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.UsersMenuItem.Name = "UsersMenuItem";
            this.UsersMenuItem.Size = new System.Drawing.Size(121, 41);
            this.UsersMenuItem.Text = "Brugere";
            this.UsersMenuItem.Click += new System.EventHandler(this.UsersMenuItem_Click);
            // 
            // CustomersMenuItem
            // 
            this.CustomersMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.CustomersMenuItem.Name = "CustomersMenuItem";
            this.CustomersMenuItem.Size = new System.Drawing.Size(114, 41);
            this.CustomersMenuItem.Text = "Kunder";
            this.CustomersMenuItem.Click += new System.EventHandler(this.CustomersMenuItem_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.Location = new System.Drawing.Point(908, 7);
            this.SearchBar.MaxLength = 300;
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(250, 30);
            this.SearchBar.TabIndex = 5;
            this.SearchBar.Visible = false;
            // 
            // ProfileTab
            // 
            this.ProfileTab.Controls.Add(this.ProfileProjectsLabel);
            this.ProfileTab.Controls.Add(this.ProfileProjects);
            this.ProfileTab.Controls.Add(this.ProfileMeetingsLabel);
            this.ProfileTab.Controls.Add(this.ProfileMeetings);
            this.ProfileTab.Controls.Add(this.ProfilePhone);
            this.ProfileTab.Controls.Add(this.ProfileEmail);
            this.ProfileTab.Controls.Add(this.ProfilePicture);
            this.ProfileTab.Controls.Add(this.ProfileName);
            this.ProfileTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileTab.Location = new System.Drawing.Point(0, 0);
            this.ProfileTab.Name = "ProfileTab";
            this.ProfileTab.Size = new System.Drawing.Size(1264, 762);
            this.ProfileTab.TabIndex = 7;
            // 
            // ProfileProjectsLabel
            // 
            this.ProfileProjectsLabel.AutoSize = true;
            this.ProfileProjectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileProjectsLabel.Location = new System.Drawing.Point(902, 90);
            this.ProfileProjectsLabel.Name = "ProfileProjectsLabel";
            this.ProfileProjectsLabel.Size = new System.Drawing.Size(188, 31);
            this.ProfileProjectsLabel.TabIndex = 7;
            this.ProfileProjectsLabel.Text = "Mine Projekter";
            // 
            // ProfileProjects
            // 
            this.ProfileProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileProjects.FormattingEnabled = true;
            this.ProfileProjects.ItemHeight = 20;
            this.ProfileProjects.Items.AddRange(new object[] {
            "Project 1",
            "Project 2",
            "Project 3"});
            this.ProfileProjects.Location = new System.Drawing.Point(797, 130);
            this.ProfileProjects.Name = "ProfileProjects";
            this.ProfileProjects.Size = new System.Drawing.Size(361, 524);
            this.ProfileProjects.TabIndex = 6;
            // 
            // ProfileMeetingsLabel
            // 
            this.ProfileMeetingsLabel.AutoSize = true;
            this.ProfileMeetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileMeetingsLabel.Location = new System.Drawing.Point(454, 90);
            this.ProfileMeetingsLabel.Name = "ProfileMeetingsLabel";
            this.ProfileMeetingsLabel.Size = new System.Drawing.Size(155, 31);
            this.ProfileMeetingsLabel.TabIndex = 5;
            this.ProfileMeetingsLabel.Text = "Mine Møder";
            // 
            // ProfileMeetings
            // 
            this.ProfileMeetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileMeetings.FormattingEnabled = true;
            this.ProfileMeetings.ItemHeight = 20;
            this.ProfileMeetings.Items.AddRange(new object[] {
            "Meeting 1",
            "Meeting 2",
            "Meeting 3"});
            this.ProfileMeetings.Location = new System.Drawing.Point(373, 130);
            this.ProfileMeetings.Name = "ProfileMeetings";
            this.ProfileMeetings.Size = new System.Drawing.Size(361, 524);
            this.ProfileMeetings.TabIndex = 4;
            this.ProfileMeetings.SelectedIndexChanged += new System.EventHandler(this.ProfileMeetings_SelectedIndexChanged);
            // 
            // ProfilePhone
            // 
            this.ProfilePhone.AutoSize = true;
            this.ProfilePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfilePhone.Location = new System.Drawing.Point(90, 317);
            this.ProfilePhone.Name = "ProfilePhone";
            this.ProfilePhone.Size = new System.Drawing.Size(35, 24);
            this.ProfilePhone.TabIndex = 3;
            this.ProfilePhone.Text = "Tlf.";
            // 
            // ProfileEmail
            // 
            this.ProfileEmail.AutoSize = true;
            this.ProfileEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileEmail.Location = new System.Drawing.Point(90, 288);
            this.ProfileEmail.Name = "ProfileEmail";
            this.ProfileEmail.Size = new System.Drawing.Size(57, 24);
            this.ProfileEmail.TabIndex = 2;
            this.ProfileEmail.Text = "Email";
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ProfilePicture.Image = global::WindowsFormsSolution.Properties.Resources._123;
            this.ProfilePicture.Location = new System.Drawing.Point(93, 90);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(150, 150);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 1;
            this.ProfilePicture.TabStop = false;
            // 
            // ProfileName
            // 
            this.ProfileName.AutoSize = true;
            this.ProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileName.Location = new System.Drawing.Point(90, 243);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(61, 24);
            this.ProfileName.TabIndex = 0;
            this.ProfileName.Text = "Name";
            // 
            // MeetingTab
            // 
            this.MeetingTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeetingTab.Location = new System.Drawing.Point(0, 0);
            this.MeetingTab.Name = "MeetingTab";
            this.MeetingTab.Size = new System.Drawing.Size(1264, 762);
            this.MeetingTab.TabIndex = 0;
            // 
            // ProjectTab
            // 
            this.ProjectTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectTab.Location = new System.Drawing.Point(0, 0);
            this.ProjectTab.Name = "ProjectTab";
            this.ProjectTab.Size = new System.Drawing.Size(1264, 762);
            this.ProjectTab.TabIndex = 0;
            // 
            // UserTab
            // 
            this.UserTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserTab.Location = new System.Drawing.Point(0, 0);
            this.UserTab.Name = "UserTab";
            this.UserTab.Size = new System.Drawing.Size(1264, 762);
            this.UserTab.TabIndex = 0;
            // 
            // CustomerTab
            // 
            this.CustomerTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerTab.Location = new System.Drawing.Point(0, 0);
            this.CustomerTab.Name = "CustomerTab";
            this.CustomerTab.Size = new System.Drawing.Size(1264, 762);
            this.CustomerTab.TabIndex = 0;
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
            this.LoginEmalBox.TabIndex = 1;
            // 
            // LoginForgotPasswordLink
            // 
            this.LoginForgotPasswordLink.AutoSize = true;
            this.LoginForgotPasswordLink.Location = new System.Drawing.Point(657, 411);
            this.LoginForgotPasswordLink.Name = "LoginForgotPasswordLink";
            this.LoginForgotPasswordLink.Size = new System.Drawing.Size(77, 13);
            this.LoginForgotPasswordLink.TabIndex = 4;
            this.LoginForgotPasswordLink.TabStop = true;
            this.LoginForgotPasswordLink.Text = "Glemt Kodeord";
            // 
            // LoginPasswordBox
            // 
            this.LoginPasswordBox.Location = new System.Drawing.Point(534, 380);
            this.LoginPasswordBox.Name = "LoginPasswordBox";
            this.LoginPasswordBox.Size = new System.Drawing.Size(200, 20);
            this.LoginPasswordBox.TabIndex = 2;
            this.LoginPasswordBox.UseSystemPasswordChar = true;
            this.LoginPasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginPasswordBox_KeyDown);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(534, 406);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginPage
            // 
            this.LoginPage.Controls.Add(this.LoginLabel);
            this.LoginPage.Controls.Add(this.LoginEmailLabel);
            this.LoginPage.Controls.Add(this.LoginPasswordLabel);
            this.LoginPage.Controls.Add(this.LoginEmalBox);
            this.LoginPage.Controls.Add(this.LoginForgotPasswordLink);
            this.LoginPage.Controls.Add(this.LoginPasswordBox);
            this.LoginPage.Controls.Add(this.LoginButton);
            this.LoginPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPage.Location = new System.Drawing.Point(0, 0);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Size = new System.Drawing.Size(1264, 762);
            this.LoginPage.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.ProfileTab);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LoginPage);
            this.Controls.Add(this.CustomerTab);
            this.Controls.Add(this.MeetingTab);
            this.Controls.Add(this.ProjectTab);
            this.Controls.Add(this.UserTab);
            this.Name = "MainForm";
            this.Text = "Fjorblink Meeting Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ProfileTab.ResumeLayout(false);
            this.ProfileTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
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
        private System.Windows.Forms.Panel ProfileTab;
        private System.Windows.Forms.Panel LoginPage;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label LoginEmailLabel;
        private System.Windows.Forms.Label LoginPasswordLabel;
        private System.Windows.Forms.TextBox LoginEmalBox;
        private System.Windows.Forms.LinkLabel LoginForgotPasswordLink;
        private System.Windows.Forms.TextBox LoginPasswordBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Panel MeetingTab;
        private System.Windows.Forms.Panel ProjectTab;
        private System.Windows.Forms.Panel UserTab;
        private System.Windows.Forms.Panel CustomerTab;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Label ProfileName;
        private System.Windows.Forms.Label ProfilePhone;
        private System.Windows.Forms.Label ProfileEmail;
        private System.Windows.Forms.ListBox ProfileMeetings;
        private System.Windows.Forms.Label ProfileMeetingsLabel;
        private System.Windows.Forms.Label ProfileProjectsLabel;
        private System.Windows.Forms.ListBox ProfileProjects;
    }
}

