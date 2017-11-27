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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("1. Test");
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
            this.ProjectCurrentLabel = new System.Windows.Forms.Label();
            this.ProjectFormerLabel = new System.Windows.Forms.Label();
            this.ProjectCurrentBox = new System.Windows.Forms.ListBox();
            this.ProjectFormerBox = new System.Windows.Forms.ListBox();
            this.UserTab = new System.Windows.Forms.Panel();
            this.UsersExternalsLabel = new System.Windows.Forms.Label();
            this.UsersExternalsBox = new System.Windows.Forms.ListBox();
            this.UsersCurrentLabel = new System.Windows.Forms.Label();
            this.UsersFormerLabel = new System.Windows.Forms.Label();
            this.UsersCurrentBox = new System.Windows.Forms.ListBox();
            this.UsersFormerBox = new System.Windows.Forms.ListBox();
            this.CustomerTab = new System.Windows.Forms.Panel();
            this.MeetingPage = new System.Windows.Forms.Panel();
            this.MeetingAgendaLabel = new System.Windows.Forms.Label();
            this.MeetingAgendaTree = new System.Windows.Forms.TreeView();
            this.MeetingDescriptionLabel = new System.Windows.Forms.Label();
            this.MeetingTitleLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginEmailLabel = new System.Windows.Forms.Label();
            this.LoginPasswordLabel = new System.Windows.Forms.Label();
            this.LoginEmalBox = new System.Windows.Forms.TextBox();
            this.LoginForgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.LoginPasswordBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginPage = new System.Windows.Forms.Panel();
            this.LoginWrong = new System.Windows.Forms.Label();
            this.ProjectPage = new System.Windows.Forms.Panel();
            this.ProfileReferatLabel = new System.Windows.Forms.Label();
            this.ProjectReferBox = new System.Windows.Forms.ListBox();
            this.ProjectTitleLabel = new System.Windows.Forms.Label();
            this.MeetingStartingTimeLabel = new System.Windows.Forms.Label();
            this.MeetingEndingTimeLabel = new System.Windows.Forms.Label();
            this.MeetingAtendeeBox = new System.Windows.Forms.ListBox();
            this.MeetingAtendeeLabel = new System.Windows.Forms.Label();
            this.ProjectDescription = new System.Windows.Forms.Label();
            this.ProjectUsersBox = new System.Windows.Forms.ListBox();
            this.ProjectUsersLabel = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.ProfileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.MeetingTab.SuspendLayout();
            this.ProjectTab.SuspendLayout();
            this.UserTab.SuspendLayout();
            this.MeetingPage.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.ProjectPage.SuspendLayout();
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
            this.ProfileProjects.SelectedIndexChanged += new System.EventHandler(this.ProfileProjects_SelectedIndexChanged);
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
            this.MeetingsUpcomingBox.SelectedIndexChanged += new System.EventHandler(this.MeetingsUpcomingBox_SelectedIndexChanged);
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
            this.ProjectTab.Controls.Add(this.ProjectCurrentLabel);
            this.ProjectTab.Controls.Add(this.ProjectFormerLabel);
            this.ProjectTab.Controls.Add(this.ProjectCurrentBox);
            this.ProjectTab.Controls.Add(this.ProjectFormerBox);
            this.ProjectTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectTab.Location = new System.Drawing.Point(0, 0);
            this.ProjectTab.Name = "ProjectTab";
            this.ProjectTab.Size = new System.Drawing.Size(1264, 762);
            this.ProjectTab.TabIndex = 0;
            // 
            // ProjectCurrentLabel
            // 
            this.ProjectCurrentLabel.AutoSize = true;
            this.ProjectCurrentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectCurrentLabel.Location = new System.Drawing.Point(812, 69);
            this.ProjectCurrentLabel.Name = "ProjectCurrentLabel";
            this.ProjectCurrentLabel.Size = new System.Drawing.Size(272, 31);
            this.ProjectCurrentLabel.TabIndex = 7;
            this.ProjectCurrentLabel.Text = "Nuværende Projekter";
            // 
            // ProjectFormerLabel
            // 
            this.ProjectFormerLabel.AutoSize = true;
            this.ProjectFormerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectFormerLabel.Location = new System.Drawing.Point(198, 69);
            this.ProjectFormerLabel.Name = "ProjectFormerLabel";
            this.ProjectFormerLabel.Size = new System.Drawing.Size(234, 31);
            this.ProjectFormerLabel.TabIndex = 6;
            this.ProjectFormerLabel.Text = "Tidligere Projekter";
            // 
            // ProjectCurrentBox
            // 
            this.ProjectCurrentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectCurrentBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ProjectCurrentBox.FormattingEnabled = true;
            this.ProjectCurrentBox.ItemHeight = 20;
            this.ProjectCurrentBox.Items.AddRange(new object[] {
            "Project 1",
            "Project 2",
            "Project 3"});
            this.ProjectCurrentBox.Location = new System.Drawing.Point(684, 109);
            this.ProjectCurrentBox.MultiColumn = true;
            this.ProjectCurrentBox.Name = "ProjectCurrentBox";
            this.ProjectCurrentBox.Size = new System.Drawing.Size(535, 584);
            this.ProjectCurrentBox.TabIndex = 5;
            this.ProjectCurrentBox.SelectedIndexChanged += new System.EventHandler(this.ProjectCurrentBox_SelectedIndexChanged);
            // 
            // ProjectFormerBox
            // 
            this.ProjectFormerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectFormerBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ProjectFormerBox.FormattingEnabled = true;
            this.ProjectFormerBox.ItemHeight = 20;
            this.ProjectFormerBox.Items.AddRange(new object[] {
            "Project 1",
            "Project 2",
            "Project 3"});
            this.ProjectFormerBox.Location = new System.Drawing.Point(46, 109);
            this.ProjectFormerBox.Name = "ProjectFormerBox";
            this.ProjectFormerBox.Size = new System.Drawing.Size(535, 584);
            this.ProjectFormerBox.TabIndex = 4;
            this.ProjectFormerBox.SelectedIndexChanged += new System.EventHandler(this.ProjectFormerBox_SelectedIndexChanged);
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
            "External 1",
            "External 2",
            "External 3"});
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
            "User 1",
            "User 2",
            "User 3"});
            this.UsersCurrentBox.Location = new System.Drawing.Point(457, 109);
            this.UsersCurrentBox.MultiColumn = true;
            this.UsersCurrentBox.Name = "UsersCurrentBox";
            this.UsersCurrentBox.Size = new System.Drawing.Size(350, 584);
            this.UsersCurrentBox.TabIndex = 5;
            this.UsersCurrentBox.SelectedIndexChanged += new System.EventHandler(this.UsersCurrentBox_SelectedIndexChanged);
            // 
            // UsersFormerBox
            // 
            this.UsersFormerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersFormerBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UsersFormerBox.FormattingEnabled = true;
            this.UsersFormerBox.ItemHeight = 20;
            this.UsersFormerBox.Items.AddRange(new object[] {
            "User 1",
            "User 2",
            "User 3"});
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
            // MeetingPage
            // 
            this.MeetingPage.Controls.Add(this.MeetingAtendeeLabel);
            this.MeetingPage.Controls.Add(this.MeetingAtendeeBox);
            this.MeetingPage.Controls.Add(this.MeetingEndingTimeLabel);
            this.MeetingPage.Controls.Add(this.MeetingStartingTimeLabel);
            this.MeetingPage.Controls.Add(this.MeetingAgendaLabel);
            this.MeetingPage.Controls.Add(this.MeetingAgendaTree);
            this.MeetingPage.Controls.Add(this.MeetingDescriptionLabel);
            this.MeetingPage.Controls.Add(this.MeetingTitleLabel);
            this.MeetingPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeetingPage.Location = new System.Drawing.Point(0, 0);
            this.MeetingPage.Name = "MeetingPage";
            this.MeetingPage.Size = new System.Drawing.Size(1264, 762);
            this.MeetingPage.TabIndex = 0;
            this.MeetingPage.Visible = false;
            // 
            // MeetingAgendaLabel
            // 
            this.MeetingAgendaLabel.AutoSize = true;
            this.MeetingAgendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingAgendaLabel.Location = new System.Drawing.Point(264, 216);
            this.MeetingAgendaLabel.Name = "MeetingAgendaLabel";
            this.MeetingAgendaLabel.Size = new System.Drawing.Size(103, 24);
            this.MeetingAgendaLabel.TabIndex = 3;
            this.MeetingAgendaLabel.Text = "Dagsorden";
            // 
            // MeetingAgendaTree
            // 
            this.MeetingAgendaTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingAgendaTree.Location = new System.Drawing.Point(12, 246);
            this.MeetingAgendaTree.Name = "MeetingAgendaTree";
            treeNode2.Name = "";
            treeNode2.Text = "1. Test";
            this.MeetingAgendaTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.MeetingAgendaTree.Size = new System.Drawing.Size(617, 504);
            this.MeetingAgendaTree.TabIndex = 2;
            // 
            // MeetingDescriptionLabel
            // 
            this.MeetingDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MeetingDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MeetingDescriptionLabel.Location = new System.Drawing.Point(12, 130);
            this.MeetingDescriptionLabel.Name = "MeetingDescriptionLabel";
            this.MeetingDescriptionLabel.Size = new System.Drawing.Size(1225, 75);
            this.MeetingDescriptionLabel.TabIndex = 1;
            this.MeetingDescriptionLabel.Text = resources.GetString("MeetingDescriptionLabel.Text");
            this.MeetingDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MeetingTitleLabel
            // 
            this.MeetingTitleLabel.AutoSize = true;
            this.MeetingTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingTitleLabel.Location = new System.Drawing.Point(588, 90);
            this.MeetingTitleLabel.Name = "MeetingTitleLabel";
            this.MeetingTitleLabel.Size = new System.Drawing.Size(198, 37);
            this.MeetingTitleLabel.TabIndex = 0;
            this.MeetingTitleLabel.Text = "Meeting Title";
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
            // ProjectPage
            // 
            this.ProjectPage.Controls.Add(this.ProjectUsersLabel);
            this.ProjectPage.Controls.Add(this.ProjectUsersBox);
            this.ProjectPage.Controls.Add(this.ProjectDescription);
            this.ProjectPage.Controls.Add(this.ProfileReferatLabel);
            this.ProjectPage.Controls.Add(this.ProjectReferBox);
            this.ProjectPage.Controls.Add(this.ProjectTitleLabel);
            this.ProjectPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectPage.Location = new System.Drawing.Point(0, 0);
            this.ProjectPage.Name = "ProjectPage";
            this.ProjectPage.Size = new System.Drawing.Size(1264, 762);
            this.ProjectPage.TabIndex = 4;
            this.ProjectPage.Visible = false;
            // 
            // ProfileReferatLabel
            // 
            this.ProfileReferatLabel.AutoSize = true;
            this.ProfileReferatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ProfileReferatLabel.Location = new System.Drawing.Point(346, 204);
            this.ProfileReferatLabel.Name = "ProfileReferatLabel";
            this.ProfileReferatLabel.Size = new System.Drawing.Size(86, 24);
            this.ProfileReferatLabel.TabIndex = 2;
            this.ProfileReferatLabel.Text = "Referater";
            // 
            // ProjectReferBox
            // 
            this.ProjectReferBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectReferBox.FormattingEnabled = true;
            this.ProjectReferBox.ItemHeight = 20;
            this.ProjectReferBox.Location = new System.Drawing.Point(32, 231);
            this.ProjectReferBox.Name = "ProjectReferBox";
            this.ProjectReferBox.Size = new System.Drawing.Size(715, 504);
            this.ProjectReferBox.TabIndex = 1;
            // 
            // ProjectTitleLabel
            // 
            this.ProjectTitleLabel.AutoSize = true;
            this.ProjectTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTitleLabel.Location = new System.Drawing.Point(589, 75);
            this.ProjectTitleLabel.Name = "ProjectTitleLabel";
            this.ProjectTitleLabel.Size = new System.Drawing.Size(158, 31);
            this.ProjectTitleLabel.TabIndex = 0;
            this.ProjectTitleLabel.Text = "Projekt Titel";
            // 
            // MeetingStartingTimeLabel
            // 
            this.MeetingStartingTimeLabel.AutoSize = true;
            this.MeetingStartingTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingStartingTimeLabel.Location = new System.Drawing.Point(654, 246);
            this.MeetingStartingTimeLabel.Name = "MeetingStartingTimeLabel";
            this.MeetingStartingTimeLabel.Size = new System.Drawing.Size(107, 17);
            this.MeetingStartingTimeLabel.TabIndex = 4;
            this.MeetingStartingTimeLabel.Text = "Start tidspunkt: ";
            // 
            // MeetingEndingTimeLabel
            // 
            this.MeetingEndingTimeLabel.AutoSize = true;
            this.MeetingEndingTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingEndingTimeLabel.Location = new System.Drawing.Point(963, 246);
            this.MeetingEndingTimeLabel.Name = "MeetingEndingTimeLabel";
            this.MeetingEndingTimeLabel.Size = new System.Drawing.Size(101, 17);
            this.MeetingEndingTimeLabel.TabIndex = 5;
            this.MeetingEndingTimeLabel.Text = "Slut tidspunkt: ";
            // 
            // MeetingAtendeeBox
            // 
            this.MeetingAtendeeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingAtendeeBox.FormattingEnabled = true;
            this.MeetingAtendeeBox.ItemHeight = 20;
            this.MeetingAtendeeBox.Items.AddRange(new object[] {
            "User 1",
            "User 2",
            "User 3",
            "External 1"});
            this.MeetingAtendeeBox.Location = new System.Drawing.Point(657, 331);
            this.MeetingAtendeeBox.Name = "MeetingAtendeeBox";
            this.MeetingAtendeeBox.Size = new System.Drawing.Size(580, 404);
            this.MeetingAtendeeBox.TabIndex = 6;
            this.MeetingAtendeeBox.SelectedIndexChanged += new System.EventHandler(this.MeetingAtendeeBox_SelectedIndexChanged);
            // 
            // MeetingAtendeeLabel
            // 
            this.MeetingAtendeeLabel.AutoSize = true;
            this.MeetingAtendeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingAtendeeLabel.Location = new System.Drawing.Point(651, 293);
            this.MeetingAtendeeLabel.Name = "MeetingAtendeeLabel";
            this.MeetingAtendeeLabel.Size = new System.Drawing.Size(156, 26);
            this.MeetingAtendeeLabel.TabIndex = 7;
            this.MeetingAtendeeLabel.Text = "Mødedeltagere";
            // 
            // ProjectDescription
            // 
            this.ProjectDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProjectDescription.Location = new System.Drawing.Point(32, 121);
            this.ProjectDescription.Name = "ProjectDescription";
            this.ProjectDescription.Size = new System.Drawing.Size(1205, 61);
            this.ProjectDescription.TabIndex = 3;
            this.ProjectDescription.Text = "Dette er en beskrivelse";
            // 
            // ProjectUsersBox
            // 
            this.ProjectUsersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectUsersBox.FormattingEnabled = true;
            this.ProjectUsersBox.ItemHeight = 20;
            this.ProjectUsersBox.Location = new System.Drawing.Point(797, 406);
            this.ProjectUsersBox.Name = "ProjectUsersBox";
            this.ProjectUsersBox.Size = new System.Drawing.Size(440, 324);
            this.ProjectUsersBox.TabIndex = 4;
            // 
            // ProjectUsersLabel
            // 
            this.ProjectUsersLabel.AutoSize = true;
            this.ProjectUsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectUsersLabel.Location = new System.Drawing.Point(947, 375);
            this.ProjectUsersLabel.Name = "ProjectUsersLabel";
            this.ProjectUsersLabel.Size = new System.Drawing.Size(153, 24);
            this.ProjectUsersLabel.TabIndex = 5;
            this.ProjectUsersLabel.Text = "Projekt Deltagere";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ProjectPage);
            this.Controls.Add(this.CustomerTab);
            this.Controls.Add(this.MeetingTab);
            this.Controls.Add(this.ProjectTab);
            this.Controls.Add(this.UserTab);
            this.Controls.Add(this.ProfileTab);
            this.Controls.Add(this.LoginPage);
            this.Controls.Add(this.MeetingPage);
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
            this.ProjectTab.ResumeLayout(false);
            this.ProjectTab.PerformLayout();
            this.UserTab.ResumeLayout(false);
            this.UserTab.PerformLayout();
            this.MeetingPage.ResumeLayout(false);
            this.MeetingPage.PerformLayout();
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.ProjectPage.ResumeLayout(false);
            this.ProjectPage.PerformLayout();
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
        private System.Windows.Forms.Panel MeetingPage;
        private System.Windows.Forms.Label MeetingTitleLabel;
        private System.Windows.Forms.Label MeetingDescriptionLabel;
        private System.Windows.Forms.Label MeetingAgendaLabel;
        private System.Windows.Forms.TreeView MeetingAgendaTree;
        private System.Windows.Forms.Panel ProjectPage;
        private System.Windows.Forms.Label ProjectTitleLabel;
        private System.Windows.Forms.ListBox ProjectReferBox;
        private System.Windows.Forms.Label ProfileReferatLabel;
        private System.Windows.Forms.Label ProjectCurrentLabel;
        private System.Windows.Forms.Label ProjectFormerLabel;
        private System.Windows.Forms.ListBox ProjectCurrentBox;
        private System.Windows.Forms.ListBox ProjectFormerBox;
        private System.Windows.Forms.Label MeetingEndingTimeLabel;
        private System.Windows.Forms.Label MeetingStartingTimeLabel;
        private System.Windows.Forms.Label MeetingAtendeeLabel;
        private System.Windows.Forms.ListBox MeetingAtendeeBox;
        private System.Windows.Forms.Label ProjectDescription;
        private System.Windows.Forms.ListBox ProjectUsersBox;
        private System.Windows.Forms.Label ProjectUsersLabel;
    }
}

