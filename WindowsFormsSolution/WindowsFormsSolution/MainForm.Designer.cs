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
            this.LogoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MeetingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.ProfileTab = new System.Windows.Forms.Panel();
            this.ProfileEditPhoneBox = new System.Windows.Forms.TextBox();
            this.ProfileEditEmailBox = new System.Windows.Forms.TextBox();
            this.ProfileEditNameBox = new System.Windows.Forms.TextBox();
            this.ProfileEditPhoneButton = new System.Windows.Forms.Button();
            this.ProfileEditEmailButton = new System.Windows.Forms.Button();
            this.ProfileEditNameButton = new System.Windows.Forms.Button();
            this.ProfileProjectsLabel = new System.Windows.Forms.Label();
            this.ProfileProjects = new System.Windows.Forms.ListBox();
            this.ProfileMeetingsLabel = new System.Windows.Forms.Label();
            this.ProfileMeetings = new System.Windows.Forms.ListBox();
            this.ProfilePhone = new System.Windows.Forms.Label();
            this.ProfileEmail = new System.Windows.Forms.Label();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.ProfileName = new System.Windows.Forms.Label();
            this.MeetingTab = new System.Windows.Forms.Panel();
            this.MeetingsUpcomingLabel = new System.Windows.Forms.Label();
            this.MeetingsFormerLabel = new System.Windows.Forms.Label();
            this.MeetingsUpcomingBox = new System.Windows.Forms.ListBox();
            this.MeetingsFormerBox = new System.Windows.Forms.ListBox();
            this.ProjectTab = new System.Windows.Forms.Panel();
            this.UserTab = new System.Windows.Forms.Panel();
            this.UsersExternalsLabel = new System.Windows.Forms.Label();
            this.UsersExternalsBox = new System.Windows.Forms.ListBox();
            this.UsersCurrentLabel = new System.Windows.Forms.Label();
            this.UsersFormerLabel = new System.Windows.Forms.Label();
            this.UsersCurrentBox = new System.Windows.Forms.ListBox();
            this.UsersFormerBox = new System.Windows.Forms.ListBox();
            this.CustomerTab = new System.Windows.Forms.Panel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginEmailLabel = new System.Windows.Forms.Label();
            this.LoginPasswordLabel = new System.Windows.Forms.Label();
            this.LoginEmalBox = new System.Windows.Forms.TextBox();
            this.LoginForgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.LoginPasswordBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginPage = new System.Windows.Forms.Panel();
            this.LoginWrong = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.ProfileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.MeetingTab.SuspendLayout();
            this.UserTab.SuspendLayout();
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
            this.ProfileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutMenuItem});
            this.ProfileMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.ProfileMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ProfileMenuItem.Image")));
            this.ProfileMenuItem.Name = "ProfileMenuItem";
            this.ProfileMenuItem.Size = new System.Drawing.Size(100, 41);
            this.ProfileMenuItem.Text = "Profil";
            this.ProfileMenuItem.Click += new System.EventHandler(this.ProfileMenuItem_Click);
            // 
            // LogoutMenuItem
            // 
            this.LogoutMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LogoutMenuItem.Name = "LogoutMenuItem";
            this.LogoutMenuItem.Size = new System.Drawing.Size(137, 26);
            this.LogoutMenuItem.Text = "Log Ud";
            this.LogoutMenuItem.Click += new System.EventHandler(this.logUdToolStripMenuItem_Click);
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
            this.ProfileTab.Controls.Add(this.ProfileEditPhoneBox);
            this.ProfileTab.Controls.Add(this.ProfileEditEmailBox);
            this.ProfileTab.Controls.Add(this.ProfileEditNameBox);
            this.ProfileTab.Controls.Add(this.ProfileEditPhoneButton);
            this.ProfileTab.Controls.Add(this.ProfileEditEmailButton);
            this.ProfileTab.Controls.Add(this.ProfileEditNameButton);
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
            this.ProfileTab.Visible = false;
            // 
            // ProfileEditPhoneBox
            // 
            this.ProfileEditPhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileEditPhoneBox.Location = new System.Drawing.Point(94, 323);
            this.ProfileEditPhoneBox.Name = "ProfileEditPhoneBox";
            this.ProfileEditPhoneBox.Size = new System.Drawing.Size(150, 29);
            this.ProfileEditPhoneBox.TabIndex = 13;
            this.ProfileEditPhoneBox.Visible = false;
            this.ProfileEditPhoneBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProfileEditPhoneBox_KeyDown);
            // 
            // ProfileEditEmailBox
            // 
            this.ProfileEditEmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileEditEmailBox.Location = new System.Drawing.Point(93, 288);
            this.ProfileEditEmailBox.Name = "ProfileEditEmailBox";
            this.ProfileEditEmailBox.Size = new System.Drawing.Size(150, 29);
            this.ProfileEditEmailBox.TabIndex = 12;
            this.ProfileEditEmailBox.Visible = false;
            this.ProfileEditEmailBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProfileEditEmailBox_KeyDown);
            // 
            // ProfileEditNameBox
            // 
            this.ProfileEditNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileEditNameBox.Location = new System.Drawing.Point(94, 243);
            this.ProfileEditNameBox.Name = "ProfileEditNameBox";
            this.ProfileEditNameBox.Size = new System.Drawing.Size(150, 29);
            this.ProfileEditNameBox.TabIndex = 11;
            this.ProfileEditNameBox.Visible = false;
            this.ProfileEditNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProfileEditNameBox_KeyDown);
            // 
            // ProfileEditPhoneButton
            // 
            this.ProfileEditPhoneButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfileEditPhoneButton.BackgroundImage")));
            this.ProfileEditPhoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileEditPhoneButton.Location = new System.Drawing.Point(61, 326);
            this.ProfileEditPhoneButton.Name = "ProfileEditPhoneButton";
            this.ProfileEditPhoneButton.Size = new System.Drawing.Size(23, 23);
            this.ProfileEditPhoneButton.TabIndex = 10;
            this.ProfileEditPhoneButton.UseVisualStyleBackColor = true;
            this.ProfileEditPhoneButton.Click += new System.EventHandler(this.ProfileEditPhoneButton_Click);
            // 
            // ProfileEditEmailButton
            // 
            this.ProfileEditEmailButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfileEditEmailButton.BackgroundImage")));
            this.ProfileEditEmailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileEditEmailButton.Location = new System.Drawing.Point(61, 291);
            this.ProfileEditEmailButton.Name = "ProfileEditEmailButton";
            this.ProfileEditEmailButton.Size = new System.Drawing.Size(23, 23);
            this.ProfileEditEmailButton.TabIndex = 9;
            this.ProfileEditEmailButton.UseVisualStyleBackColor = true;
            this.ProfileEditEmailButton.Click += new System.EventHandler(this.ProfileEditEmailButton_Click);
            // 
            // ProfileEditNameButton
            // 
            this.ProfileEditNameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfileEditNameButton.BackgroundImage")));
            this.ProfileEditNameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileEditNameButton.Location = new System.Drawing.Point(61, 246);
            this.ProfileEditNameButton.Name = "ProfileEditNameButton";
            this.ProfileEditNameButton.Size = new System.Drawing.Size(23, 23);
            this.ProfileEditNameButton.TabIndex = 8;
            this.ProfileEditNameButton.UseVisualStyleBackColor = true;
            this.ProfileEditNameButton.Click += new System.EventHandler(this.ProfileEditNameButton_Click);
            // 
            // ProfileProjectsLabel
            // 
            this.ProfileProjectsLabel.AutoSize = true;
            this.ProfileProjectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileProjectsLabel.Location = new System.Drawing.Point(882, 90);
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
            this.ProfileMeetingsLabel.Location = new System.Drawing.Point(474, 90);
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
            this.ProfilePhone.Location = new System.Drawing.Point(90, 325);
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
            this.MeetingTab.Controls.Add(this.MeetingsUpcomingLabel);
            this.MeetingTab.Controls.Add(this.MeetingsFormerLabel);
            this.MeetingTab.Controls.Add(this.MeetingsUpcomingBox);
            this.MeetingTab.Controls.Add(this.MeetingsFormerBox);
            this.MeetingTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeetingTab.Location = new System.Drawing.Point(0, 0);
            this.MeetingTab.Name = "MeetingTab";
            this.MeetingTab.Size = new System.Drawing.Size(1264, 762);
            this.MeetingTab.TabIndex = 0;
            // 
            // MeetingsUpcomingLabel
            // 
            this.MeetingsUpcomingLabel.AutoSize = true;
            this.MeetingsUpcomingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingsUpcomingLabel.Location = new System.Drawing.Point(850, 90);
            this.MeetingsUpcomingLabel.Name = "MeetingsUpcomingLabel";
            this.MeetingsUpcomingLabel.Size = new System.Drawing.Size(234, 31);
            this.MeetingsUpcomingLabel.TabIndex = 3;
            this.MeetingsUpcomingLabel.Text = "Kommende Møder";
            // 
            // MeetingsFormerLabel
            // 
            this.MeetingsFormerLabel.AutoSize = true;
            this.MeetingsFormerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingsFormerLabel.Location = new System.Drawing.Point(209, 90);
            this.MeetingsFormerLabel.Name = "MeetingsFormerLabel";
            this.MeetingsFormerLabel.Size = new System.Drawing.Size(201, 31);
            this.MeetingsFormerLabel.TabIndex = 2;
            this.MeetingsFormerLabel.Text = "Tidligere Møder";
            // 
            // MeetingsUpcomingBox
            // 
            this.MeetingsUpcomingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingsUpcomingBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MeetingsUpcomingBox.FormattingEnabled = true;
            this.MeetingsUpcomingBox.ItemHeight = 20;
            this.MeetingsUpcomingBox.Items.AddRange(new object[] {
            "Meeting 1",
            "Meeting 2",
            "Meeting 3"});
            this.MeetingsUpcomingBox.Location = new System.Drawing.Point(684, 130);
            this.MeetingsUpcomingBox.MultiColumn = true;
            this.MeetingsUpcomingBox.Name = "MeetingsUpcomingBox";
            this.MeetingsUpcomingBox.Size = new System.Drawing.Size(535, 584);
            this.MeetingsUpcomingBox.TabIndex = 1;
            // 
            // MeetingsFormerBox
            // 
            this.MeetingsFormerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingsFormerBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MeetingsFormerBox.FormattingEnabled = true;
            this.MeetingsFormerBox.ItemHeight = 20;
            this.MeetingsFormerBox.Items.AddRange(new object[] {
            "Meeting 1",
            "Meeting 2",
            "Meeting 3"});
            this.MeetingsFormerBox.Location = new System.Drawing.Point(46, 130);
            this.MeetingsFormerBox.Name = "MeetingsFormerBox";
            this.MeetingsFormerBox.Size = new System.Drawing.Size(535, 584);
            this.MeetingsFormerBox.TabIndex = 0;
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
            this.UserTab.Controls.Add(this.UsersExternalsLabel);
            this.UserTab.Controls.Add(this.UsersExternalsBox);
            this.UserTab.Controls.Add(this.UsersCurrentLabel);
            this.UserTab.Controls.Add(this.UsersFormerLabel);
            this.UserTab.Controls.Add(this.UsersCurrentBox);
            this.UserTab.Controls.Add(this.UsersFormerBox);
            this.UserTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserTab.Location = new System.Drawing.Point(0, 0);
            this.UserTab.Name = "UserTab";
            this.UserTab.Size = new System.Drawing.Size(1264, 762);
            this.UserTab.TabIndex = 0;
            // 
            // UsersExternalsLabel
            // 
            this.UsersExternalsLabel.AutoSize = true;
            this.UsersExternalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersExternalsLabel.Location = new System.Drawing.Point(892, 69);
            this.UsersExternalsLabel.Name = "UsersExternalsLabel";
            this.UsersExternalsLabel.Size = new System.Drawing.Size(309, 31);
            this.UsersExternalsLabel.TabIndex = 9;
            this.UsersExternalsLabel.Text = "Eksterne Mødedeltagere";
            // 
            // UsersExternalsBox
            // 
            this.UsersExternalsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersExternalsBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UsersExternalsBox.FormattingEnabled = true;
            this.UsersExternalsBox.ItemHeight = 20;
            this.UsersExternalsBox.Items.AddRange(new object[] {
            "sdasd",
            "sadasd",
            "sadasd",
            "asdads",
            "asd"});
            this.UsersExternalsBox.Location = new System.Drawing.Point(869, 109);
            this.UsersExternalsBox.MultiColumn = true;
            this.UsersExternalsBox.Name = "UsersExternalsBox";
            this.UsersExternalsBox.Size = new System.Drawing.Size(350, 584);
            this.UsersExternalsBox.TabIndex = 8;
            // 
            // UsersCurrentLabel
            // 
            this.UsersCurrentLabel.AutoSize = true;
            this.UsersCurrentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersCurrentLabel.Location = new System.Drawing.Point(505, 69);
            this.UsersCurrentLabel.Name = "UsersCurrentLabel";
            this.UsersCurrentLabel.Size = new System.Drawing.Size(256, 31);
            this.UsersCurrentLabel.TabIndex = 7;
            this.UsersCurrentLabel.Text = "Nuværende Ansatte";
            // 
            // UsersFormerLabel
            // 
            this.UsersFormerLabel.AutoSize = true;
            this.UsersFormerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersFormerLabel.Location = new System.Drawing.Point(112, 69);
            this.UsersFormerLabel.Name = "UsersFormerLabel";
            this.UsersFormerLabel.Size = new System.Drawing.Size(218, 31);
            this.UsersFormerLabel.TabIndex = 6;
            this.UsersFormerLabel.Text = "Tidligere Ansatte";
            // 
            // UsersCurrentBox
            // 
            this.UsersCurrentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersCurrentBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UsersCurrentBox.FormattingEnabled = true;
            this.UsersCurrentBox.ItemHeight = 20;
            this.UsersCurrentBox.Items.AddRange(new object[] {
            "sdasd",
            "sadasd",
            "sadasd",
            "asdads",
            "asd"});
            this.UsersCurrentBox.Location = new System.Drawing.Point(457, 109);
            this.UsersCurrentBox.MultiColumn = true;
            this.UsersCurrentBox.Name = "UsersCurrentBox";
            this.UsersCurrentBox.Size = new System.Drawing.Size(350, 584);
            this.UsersCurrentBox.TabIndex = 5;
            // 
            // UsersFormerBox
            // 
            this.UsersFormerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersFormerBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UsersFormerBox.FormattingEnabled = true;
            this.UsersFormerBox.ItemHeight = 20;
            this.UsersFormerBox.Items.AddRange(new object[] {
            "sdasd",
            "sadasd",
            "sadasd",
            "asdads",
            "asdasd",
            "ä",
            "sd",
            "asd",
            "sad",
            "",
            "asd",
            "as",
            "dasd",
            "a",
            "f",
            "sd",
            "f",
            "s",
            "fd",
            "",
            "f",
            "fd",
            "g",
            "sf",
            "g",
            "fds",
            "g",
            "fds",
            "ds",
            "f",
            "dsf",
            "ds",
            "f",
            "dsf",
            "ds",
            "fsd",
            "f",
            "sf",
            "sd",
            "f",
            "dsf",
            "sd",
            "f",
            "sdf"});
            this.UsersFormerBox.Location = new System.Drawing.Point(46, 109);
            this.UsersFormerBox.Name = "UsersFormerBox";
            this.UsersFormerBox.Size = new System.Drawing.Size(350, 584);
            this.UsersFormerBox.TabIndex = 4;
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
            this.LoginLabel.Location = new System.Drawing.Point(589, 260);
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
            this.LoginPage.Controls.Add(this.LoginWrong);
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
            // LoginWrong
            // 
            this.LoginWrong.AutoSize = true;
            this.LoginWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginWrong.ForeColor = System.Drawing.Color.Red;
            this.LoginWrong.Location = new System.Drawing.Point(540, 300);
            this.LoginWrong.Name = "LoginWrong";
            this.LoginWrong.Size = new System.Drawing.Size(192, 17);
            this.LoginWrong.TabIndex = 14;
            this.LoginWrong.Text = "Wrong Username / Password";
            this.LoginWrong.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MeetingTab);
            this.Controls.Add(this.ProjectTab);
            this.Controls.Add(this.UserTab);
            this.Controls.Add(this.ProfileTab);
            this.Controls.Add(this.LoginPage);
            this.Controls.Add(this.CustomerTab);
            this.Name = "MainForm";
            this.Text = "Fjorblink Meeting Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ProfileTab.ResumeLayout(false);
            this.ProfileTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.MeetingTab.ResumeLayout(false);
            this.MeetingTab.PerformLayout();
            this.UserTab.ResumeLayout(false);
            this.UserTab.PerformLayout();
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
        private System.Windows.Forms.Button ProfileEditNameButton;
        private System.Windows.Forms.Button ProfileEditPhoneButton;
        private System.Windows.Forms.Button ProfileEditEmailButton;
        private System.Windows.Forms.TextBox ProfileEditNameBox;
        private System.Windows.Forms.TextBox ProfileEditPhoneBox;
        private System.Windows.Forms.TextBox ProfileEditEmailBox;
        private System.Windows.Forms.Label LoginWrong;
        private System.Windows.Forms.ToolStripMenuItem LogoutMenuItem;
        private System.Windows.Forms.ListBox MeetingsFormerBox;
        private System.Windows.Forms.Label MeetingsUpcomingLabel;
        private System.Windows.Forms.Label MeetingsFormerLabel;
        private System.Windows.Forms.ListBox MeetingsUpcomingBox;
        private System.Windows.Forms.ListBox UsersExternalsBox;
        private System.Windows.Forms.Label UsersCurrentLabel;
        private System.Windows.Forms.Label UsersFormerLabel;
        private System.Windows.Forms.ListBox UsersCurrentBox;
        private System.Windows.Forms.ListBox UsersFormerBox;
        private System.Windows.Forms.Label UsersExternalsLabel;
    }
}

