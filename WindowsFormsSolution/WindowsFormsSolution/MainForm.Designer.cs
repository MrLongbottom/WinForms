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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("1. Test");
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
            this.MeetingPage = new System.Windows.Forms.Panel();
            this.MeetingTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.MeetingDescriptionLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginEmailLabel = new System.Windows.Forms.Label();
            this.LoginPasswordLabel = new System.Windows.Forms.Label();
            this.LoginEmalBox = new System.Windows.Forms.TextBox();
            this.LoginForgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.LoginPasswordBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginPage = new System.Windows.Forms.Panel();
            this.LoginWrong = new System.Windows.Forms.Label();
            this.CreatMeeting = new System.Windows.Forms.Panel();
            this.CreateMeetingAddexternButtom = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CreateMeetingAttendancecomboBox = new System.Windows.Forms.ComboBox();
            this.CreateMeetingAttendanceLabel = new System.Windows.Forms.Label();
            this.CreateMeetingEndtimeLabel = new System.Windows.Forms.Label();
            this.CreateMeetingEndtimeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CreateMeetingStarttimeLabel = new System.Windows.Forms.Label();
            this.CreateMeetingAddsubmeetingButtom = new System.Windows.Forms.Button();
            this.CreateMeetingFullAgendaLabel = new System.Windows.Forms.TreeView();
            this.CreateMeetingStarttimeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CreateMeetingAddAgendaItemButtom = new System.Windows.Forms.Button();
            this.CreateMeetingAgendaLabel = new System.Windows.Forms.Label();
            this.CreateMeetingDescriptionRichtextbox = new System.Windows.Forms.RichTextBox();
            this.CreateMeetingDescriptionLabel = new System.Windows.Forms.Label();
            this.CreateMeetingTitleTextbox = new System.Windows.Forms.TextBox();
            this.CreateMeetingTittleLabel = new System.Windows.Forms.Label();
            this.MeetingsCreateButtom = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.ProfileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.MeetingTab.SuspendLayout();
            this.UserTab.SuspendLayout();
            this.MeetingPage.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.CreatMeeting.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(1552, 0);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(133, 55);
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
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfileMenuItem,
            this.MeetingsMenuItem,
            this.ProjectsMenuItem,
            this.UsersMenuItem,
            this.CustomersMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(1685, 54);
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
            this.LogoutMenuItem.Size = new System.Drawing.Size(162, 32);
            this.LogoutMenuItem.Text = "Log Ud";
            this.LogoutMenuItem.Click += new System.EventHandler(this.logUdToolStripMenuItem_Click);
            // 
            // MeetingsMenuItem
            // 
            this.MeetingsMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.MeetingsMenuItem.Name = "MeetingsMenuItem";
            this.MeetingsMenuItem.Size = new System.Drawing.Size(133, 50);
            this.MeetingsMenuItem.Text = "Møder";
            this.MeetingsMenuItem.Click += new System.EventHandler(this.MeetingsMenuItem_Click);
            // 
            // ProjectsMenuItem
            // 
            this.ProjectsMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.ProjectsMenuItem.Name = "ProjectsMenuItem";
            this.ProjectsMenuItem.Size = new System.Drawing.Size(168, 50);
            this.ProjectsMenuItem.Text = "Projekter";
            this.ProjectsMenuItem.Click += new System.EventHandler(this.ProjectsMenuItem_Click);
            // 
            // UsersMenuItem
            // 
            this.UsersMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.UsersMenuItem.Name = "UsersMenuItem";
            this.UsersMenuItem.Size = new System.Drawing.Size(150, 50);
            this.UsersMenuItem.Text = "Brugere";
            this.UsersMenuItem.Click += new System.EventHandler(this.UsersMenuItem_Click);
            // 
            // CustomersMenuItem
            // 
            this.CustomersMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.CustomersMenuItem.Name = "CustomersMenuItem";
            this.CustomersMenuItem.Size = new System.Drawing.Size(140, 50);
            this.CustomersMenuItem.Text = "Kunder";
            this.CustomersMenuItem.Click += new System.EventHandler(this.CustomersMenuItem_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.Location = new System.Drawing.Point(1211, 9);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBar.MaxLength = 300;
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(332, 36);
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
            this.ProfileTab.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileTab.Name = "ProfileTab";
            this.ProfileTab.Size = new System.Drawing.Size(1685, 938);
            this.ProfileTab.TabIndex = 7;
            // 
            // ProfileEditPhoneBox
            // 
            this.ProfileEditPhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileEditPhoneBox.Location = new System.Drawing.Point(125, 398);
            this.ProfileEditPhoneBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileEditPhoneBox.Name = "ProfileEditPhoneBox";
            this.ProfileEditPhoneBox.Size = new System.Drawing.Size(199, 34);
            this.ProfileEditPhoneBox.TabIndex = 13;
            this.ProfileEditPhoneBox.Visible = false;
            this.ProfileEditPhoneBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProfileEditPhoneBox_KeyDown);
            // 
            // ProfileEditEmailBox
            // 
            this.ProfileEditEmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileEditEmailBox.Location = new System.Drawing.Point(124, 354);
            this.ProfileEditEmailBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileEditEmailBox.Name = "ProfileEditEmailBox";
            this.ProfileEditEmailBox.Size = new System.Drawing.Size(199, 34);
            this.ProfileEditEmailBox.TabIndex = 12;
            this.ProfileEditEmailBox.Visible = false;
            this.ProfileEditEmailBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProfileEditEmailBox_KeyDown);
            // 
            // ProfileEditNameBox
            // 
            this.ProfileEditNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileEditNameBox.Location = new System.Drawing.Point(125, 299);
            this.ProfileEditNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileEditNameBox.Name = "ProfileEditNameBox";
            this.ProfileEditNameBox.Size = new System.Drawing.Size(199, 34);
            this.ProfileEditNameBox.TabIndex = 11;
            this.ProfileEditNameBox.Visible = false;
            this.ProfileEditNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProfileEditNameBox_KeyDown);
            // 
            // ProfileEditPhoneButton
            // 
            this.ProfileEditPhoneButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfileEditPhoneButton.BackgroundImage")));
            this.ProfileEditPhoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileEditPhoneButton.Location = new System.Drawing.Point(81, 401);
            this.ProfileEditPhoneButton.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileEditPhoneButton.Name = "ProfileEditPhoneButton";
            this.ProfileEditPhoneButton.Size = new System.Drawing.Size(31, 28);
            this.ProfileEditPhoneButton.TabIndex = 10;
            this.ProfileEditPhoneButton.UseVisualStyleBackColor = true;
            this.ProfileEditPhoneButton.Click += new System.EventHandler(this.ProfileEditPhoneButton_Click);
            // 
            // ProfileEditEmailButton
            // 
            this.ProfileEditEmailButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfileEditEmailButton.BackgroundImage")));
            this.ProfileEditEmailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileEditEmailButton.Location = new System.Drawing.Point(81, 358);
            this.ProfileEditEmailButton.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileEditEmailButton.Name = "ProfileEditEmailButton";
            this.ProfileEditEmailButton.Size = new System.Drawing.Size(31, 28);
            this.ProfileEditEmailButton.TabIndex = 9;
            this.ProfileEditEmailButton.UseVisualStyleBackColor = true;
            this.ProfileEditEmailButton.Click += new System.EventHandler(this.ProfileEditEmailButton_Click);
            // 
            // ProfileEditNameButton
            // 
            this.ProfileEditNameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfileEditNameButton.BackgroundImage")));
            this.ProfileEditNameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileEditNameButton.Location = new System.Drawing.Point(81, 303);
            this.ProfileEditNameButton.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileEditNameButton.Name = "ProfileEditNameButton";
            this.ProfileEditNameButton.Size = new System.Drawing.Size(31, 28);
            this.ProfileEditNameButton.TabIndex = 8;
            this.ProfileEditNameButton.UseVisualStyleBackColor = true;
            this.ProfileEditNameButton.Click += new System.EventHandler(this.ProfileEditNameButton_Click);
            // 
            // ProfileProjectsLabel
            // 
            this.ProfileProjectsLabel.AutoSize = true;
            this.ProfileProjectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileProjectsLabel.Location = new System.Drawing.Point(1176, 111);
            this.ProfileProjectsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProfileProjectsLabel.Name = "ProfileProjectsLabel";
            this.ProfileProjectsLabel.Size = new System.Drawing.Size(236, 39);
            this.ProfileProjectsLabel.TabIndex = 7;
            this.ProfileProjectsLabel.Text = "Mine Projekter";
            // 
            // ProfileProjects
            // 
            this.ProfileProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileProjects.FormattingEnabled = true;
            this.ProfileProjects.ItemHeight = 25;
            this.ProfileProjects.Items.AddRange(new object[] {
            "Project 1",
            "Project 2",
            "Project 3"});
            this.ProfileProjects.Location = new System.Drawing.Point(1063, 160);
            this.ProfileProjects.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileProjects.Name = "ProfileProjects";
            this.ProfileProjects.Size = new System.Drawing.Size(480, 629);
            this.ProfileProjects.TabIndex = 6;
            // 
            // ProfileMeetingsLabel
            // 
            this.ProfileMeetingsLabel.AutoSize = true;
            this.ProfileMeetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileMeetingsLabel.Location = new System.Drawing.Point(632, 111);
            this.ProfileMeetingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProfileMeetingsLabel.Name = "ProfileMeetingsLabel";
            this.ProfileMeetingsLabel.Size = new System.Drawing.Size(196, 39);
            this.ProfileMeetingsLabel.TabIndex = 5;
            this.ProfileMeetingsLabel.Text = "Mine Møder";
            // 
            // ProfileMeetings
            // 
            this.ProfileMeetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileMeetings.FormattingEnabled = true;
            this.ProfileMeetings.ItemHeight = 25;
            this.ProfileMeetings.Items.AddRange(new object[] {
            "Meeting 1",
            "Meeting 2",
            "Meeting 3"});
            this.ProfileMeetings.Location = new System.Drawing.Point(497, 160);
            this.ProfileMeetings.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileMeetings.Name = "ProfileMeetings";
            this.ProfileMeetings.Size = new System.Drawing.Size(480, 629);
            this.ProfileMeetings.TabIndex = 4;
            this.ProfileMeetings.SelectedIndexChanged += new System.EventHandler(this.ProfileMeetings_SelectedIndexChanged);
            // 
            // ProfilePhone
            // 
            this.ProfilePhone.AutoSize = true;
            this.ProfilePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfilePhone.Location = new System.Drawing.Point(120, 400);
            this.ProfilePhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProfilePhone.Name = "ProfilePhone";
            this.ProfilePhone.Size = new System.Drawing.Size(47, 29);
            this.ProfilePhone.TabIndex = 3;
            this.ProfilePhone.Text = "Tlf.";
            // 
            // ProfileEmail
            // 
            this.ProfileEmail.AutoSize = true;
            this.ProfileEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileEmail.Location = new System.Drawing.Point(120, 354);
            this.ProfileEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProfileEmail.Name = "ProfileEmail";
            this.ProfileEmail.Size = new System.Drawing.Size(74, 29);
            this.ProfileEmail.TabIndex = 2;
            this.ProfileEmail.Text = "Email";
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ProfilePicture.Image = global::WindowsFormsSolution.Properties.Resources._123;
            this.ProfilePicture.Location = new System.Drawing.Point(124, 111);
            this.ProfilePicture.Margin = new System.Windows.Forms.Padding(4);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(200, 185);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 1;
            this.ProfilePicture.TabStop = false;
            // 
            // ProfileName
            // 
            this.ProfileName.AutoSize = true;
            this.ProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileName.Location = new System.Drawing.Point(120, 299);
            this.ProfileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(78, 29);
            this.ProfileName.TabIndex = 0;
            this.ProfileName.Text = "Name";
            // 
            // MeetingTab
            // 
            this.MeetingTab.Controls.Add(this.MeetingsCreateButtom);
            this.MeetingTab.Controls.Add(this.MeetingsUpcomingLabel);
            this.MeetingTab.Controls.Add(this.MeetingsFormerLabel);
            this.MeetingTab.Controls.Add(this.MeetingsUpcomingBox);
            this.MeetingTab.Controls.Add(this.MeetingsFormerBox);
            this.MeetingTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeetingTab.Location = new System.Drawing.Point(0, 0);
            this.MeetingTab.Margin = new System.Windows.Forms.Padding(4);
            this.MeetingTab.Name = "MeetingTab";
            this.MeetingTab.Size = new System.Drawing.Size(1685, 938);
            this.MeetingTab.TabIndex = 0;
            // 
            // MeetingsUpcomingLabel
            // 
            this.MeetingsUpcomingLabel.AutoSize = true;
            this.MeetingsUpcomingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingsUpcomingLabel.Location = new System.Drawing.Point(1133, 111);
            this.MeetingsUpcomingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MeetingsUpcomingLabel.Name = "MeetingsUpcomingLabel";
            this.MeetingsUpcomingLabel.Size = new System.Drawing.Size(296, 39);
            this.MeetingsUpcomingLabel.TabIndex = 3;
            this.MeetingsUpcomingLabel.Text = "Kommende Møder";
            // 
            // MeetingsFormerLabel
            // 
            this.MeetingsFormerLabel.AutoSize = true;
            this.MeetingsFormerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingsFormerLabel.Location = new System.Drawing.Point(279, 111);
            this.MeetingsFormerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MeetingsFormerLabel.Name = "MeetingsFormerLabel";
            this.MeetingsFormerLabel.Size = new System.Drawing.Size(254, 39);
            this.MeetingsFormerLabel.TabIndex = 2;
            this.MeetingsFormerLabel.Text = "Tidligere Møder";
            // 
            // MeetingsUpcomingBox
            // 
            this.MeetingsUpcomingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingsUpcomingBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MeetingsUpcomingBox.FormattingEnabled = true;
            this.MeetingsUpcomingBox.ItemHeight = 25;
            this.MeetingsUpcomingBox.Items.AddRange(new object[] {
            "Meeting 1",
            "Meeting 2",
            "Meeting 3"});
            this.MeetingsUpcomingBox.Location = new System.Drawing.Point(912, 160);
            this.MeetingsUpcomingBox.Margin = new System.Windows.Forms.Padding(4);
            this.MeetingsUpcomingBox.MultiColumn = true;
            this.MeetingsUpcomingBox.Name = "MeetingsUpcomingBox";
            this.MeetingsUpcomingBox.Size = new System.Drawing.Size(712, 704);
            this.MeetingsUpcomingBox.TabIndex = 1;
            // 
            // MeetingsFormerBox
            // 
            this.MeetingsFormerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingsFormerBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MeetingsFormerBox.FormattingEnabled = true;
            this.MeetingsFormerBox.ItemHeight = 25;
            this.MeetingsFormerBox.Items.AddRange(new object[] {
            "Meeting 1",
            "Meeting 2",
            "Meeting 3"});
            this.MeetingsFormerBox.Location = new System.Drawing.Point(61, 160);
            this.MeetingsFormerBox.Margin = new System.Windows.Forms.Padding(4);
            this.MeetingsFormerBox.Name = "MeetingsFormerBox";
            this.MeetingsFormerBox.Size = new System.Drawing.Size(712, 704);
            this.MeetingsFormerBox.TabIndex = 0;
            // 
            // ProjectTab
            // 
            this.ProjectTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectTab.Location = new System.Drawing.Point(0, 0);
            this.ProjectTab.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectTab.Name = "ProjectTab";
            this.ProjectTab.Size = new System.Drawing.Size(1685, 938);
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
            this.UserTab.Margin = new System.Windows.Forms.Padding(4);
            this.UserTab.Name = "UserTab";
            this.UserTab.Size = new System.Drawing.Size(1685, 938);
            this.UserTab.TabIndex = 0;
            // 
            // UsersExternalsLabel
            // 
            this.UsersExternalsLabel.AutoSize = true;
            this.UsersExternalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersExternalsLabel.Location = new System.Drawing.Point(1189, 85);
            this.UsersExternalsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsersExternalsLabel.Name = "UsersExternalsLabel";
            this.UsersExternalsLabel.Size = new System.Drawing.Size(387, 39);
            this.UsersExternalsLabel.TabIndex = 9;
            this.UsersExternalsLabel.Text = "Eksterne Mødedeltagere";
            // 
            // UsersExternalsBox
            // 
            this.UsersExternalsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersExternalsBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UsersExternalsBox.FormattingEnabled = true;
            this.UsersExternalsBox.ItemHeight = 25;
            this.UsersExternalsBox.Items.AddRange(new object[] {
            "External 1",
            "External 2",
            "External 3"});
            this.UsersExternalsBox.Location = new System.Drawing.Point(1159, 134);
            this.UsersExternalsBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsersExternalsBox.MultiColumn = true;
            this.UsersExternalsBox.Name = "UsersExternalsBox";
            this.UsersExternalsBox.Size = new System.Drawing.Size(465, 704);
            this.UsersExternalsBox.TabIndex = 8;
            // 
            // UsersCurrentLabel
            // 
            this.UsersCurrentLabel.AutoSize = true;
            this.UsersCurrentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersCurrentLabel.Location = new System.Drawing.Point(673, 85);
            this.UsersCurrentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsersCurrentLabel.Name = "UsersCurrentLabel";
            this.UsersCurrentLabel.Size = new System.Drawing.Size(319, 39);
            this.UsersCurrentLabel.TabIndex = 7;
            this.UsersCurrentLabel.Text = "Nuværende Ansatte";
            // 
            // UsersFormerLabel
            // 
            this.UsersFormerLabel.AutoSize = true;
            this.UsersFormerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersFormerLabel.Location = new System.Drawing.Point(149, 85);
            this.UsersFormerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsersFormerLabel.Name = "UsersFormerLabel";
            this.UsersFormerLabel.Size = new System.Drawing.Size(273, 39);
            this.UsersFormerLabel.TabIndex = 6;
            this.UsersFormerLabel.Text = "Tidligere Ansatte";
            // 
            // UsersCurrentBox
            // 
            this.UsersCurrentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersCurrentBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UsersCurrentBox.FormattingEnabled = true;
            this.UsersCurrentBox.ItemHeight = 25;
            this.UsersCurrentBox.Items.AddRange(new object[] {
            "User 1",
            "User 2",
            "User 3"});
            this.UsersCurrentBox.Location = new System.Drawing.Point(609, 134);
            this.UsersCurrentBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsersCurrentBox.MultiColumn = true;
            this.UsersCurrentBox.Name = "UsersCurrentBox";
            this.UsersCurrentBox.Size = new System.Drawing.Size(465, 704);
            this.UsersCurrentBox.TabIndex = 5;
            this.UsersCurrentBox.SelectedIndexChanged += new System.EventHandler(this.UsersCurrentBox_SelectedIndexChanged);
            // 
            // UsersFormerBox
            // 
            this.UsersFormerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersFormerBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UsersFormerBox.FormattingEnabled = true;
            this.UsersFormerBox.ItemHeight = 25;
            this.UsersFormerBox.Items.AddRange(new object[] {
            "User 1",
            "User 2",
            "User 3"});
            this.UsersFormerBox.Location = new System.Drawing.Point(61, 134);
            this.UsersFormerBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsersFormerBox.Name = "UsersFormerBox";
            this.UsersFormerBox.Size = new System.Drawing.Size(465, 704);
            this.UsersFormerBox.TabIndex = 4;
            // 
            // CustomerTab
            // 
            this.CustomerTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerTab.Location = new System.Drawing.Point(0, 0);
            this.CustomerTab.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerTab.Name = "CustomerTab";
            this.CustomerTab.Size = new System.Drawing.Size(1685, 938);
            this.CustomerTab.TabIndex = 0;
            // 
            // MeetingPage
            // 
            this.MeetingPage.Controls.Add(this.MeetingTitleLabel);
            this.MeetingPage.Controls.Add(this.label1);
            this.MeetingPage.Controls.Add(this.treeView1);
            this.MeetingPage.Controls.Add(this.MeetingDescriptionLabel);
            this.MeetingPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeetingPage.Location = new System.Drawing.Point(0, 0);
            this.MeetingPage.Margin = new System.Windows.Forms.Padding(4);
            this.MeetingPage.Name = "MeetingPage";
            this.MeetingPage.Size = new System.Drawing.Size(1685, 938);
            this.MeetingPage.TabIndex = 0;
            this.MeetingPage.Visible = false;
            // 
            // MeetingTitleLabel
            // 
            this.MeetingTitleLabel.AutoSize = true;
            this.MeetingTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingTitleLabel.Location = new System.Drawing.Point(784, 111);
            this.MeetingTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MeetingTitleLabel.Name = "MeetingTitleLabel";
            this.MeetingTitleLabel.Size = new System.Drawing.Size(247, 46);
            this.MeetingTitleLabel.TabIndex = 0;
            this.MeetingTitleLabel.Text = "Meeting Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dagsorden";
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(16, 303);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "";
            treeNode1.Text = "1. Test";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(821, 285);
            this.treeView1.TabIndex = 2;
            // 
            // MeetingDescriptionLabel
            // 
            this.MeetingDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MeetingDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MeetingDescriptionLabel.Location = new System.Drawing.Point(16, 160);
            this.MeetingDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MeetingDescriptionLabel.Name = "MeetingDescriptionLabel";
            this.MeetingDescriptionLabel.Size = new System.Drawing.Size(1633, 92);
            this.MeetingDescriptionLabel.TabIndex = 1;
            this.MeetingDescriptionLabel.Text = resources.GetString("MeetingDescriptionLabel.Text");
            this.MeetingDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(785, 320);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(112, 39);
            this.LoginLabel.TabIndex = 17;
            this.LoginLabel.Text = "Log In";
            // 
            // LoginEmailLabel
            // 
            this.LoginEmailLabel.AutoSize = true;
            this.LoginEmailLabel.Location = new System.Drawing.Point(708, 400);
            this.LoginEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginEmailLabel.Name = "LoginEmailLabel";
            this.LoginEmailLabel.Size = new System.Drawing.Size(46, 17);
            this.LoginEmailLabel.TabIndex = 16;
            this.LoginEmailLabel.Text = "Email:";
            // 
            // LoginPasswordLabel
            // 
            this.LoginPasswordLabel.AutoSize = true;
            this.LoginPasswordLabel.Location = new System.Drawing.Point(708, 448);
            this.LoginPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginPasswordLabel.Name = "LoginPasswordLabel";
            this.LoginPasswordLabel.Size = new System.Drawing.Size(66, 17);
            this.LoginPasswordLabel.TabIndex = 15;
            this.LoginPasswordLabel.Text = "Kodeord:";
            // 
            // LoginEmalBox
            // 
            this.LoginEmalBox.Location = new System.Drawing.Point(712, 420);
            this.LoginEmalBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginEmalBox.Name = "LoginEmalBox";
            this.LoginEmalBox.Size = new System.Drawing.Size(265, 22);
            this.LoginEmalBox.TabIndex = 1;
            // 
            // LoginForgotPasswordLink
            // 
            this.LoginForgotPasswordLink.AutoSize = true;
            this.LoginForgotPasswordLink.Location = new System.Drawing.Point(876, 506);
            this.LoginForgotPasswordLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginForgotPasswordLink.Name = "LoginForgotPasswordLink";
            this.LoginForgotPasswordLink.Size = new System.Drawing.Size(103, 17);
            this.LoginForgotPasswordLink.TabIndex = 4;
            this.LoginForgotPasswordLink.TabStop = true;
            this.LoginForgotPasswordLink.Text = "Glemt Kodeord";
            // 
            // LoginPasswordBox
            // 
            this.LoginPasswordBox.Location = new System.Drawing.Point(712, 468);
            this.LoginPasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPasswordBox.Name = "LoginPasswordBox";
            this.LoginPasswordBox.Size = new System.Drawing.Size(265, 22);
            this.LoginPasswordBox.TabIndex = 2;
            this.LoginPasswordBox.UseSystemPasswordChar = true;
            this.LoginPasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginPasswordBox_KeyDown);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(712, 500);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(100, 28);
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
            this.LoginPage.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Size = new System.Drawing.Size(1685, 938);
            this.LoginPage.TabIndex = 11;
            // 
            // LoginWrong
            // 
            this.LoginWrong.AutoSize = true;
            this.LoginWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginWrong.ForeColor = System.Drawing.Color.Red;
            this.LoginWrong.Location = new System.Drawing.Point(720, 369);
            this.LoginWrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginWrong.Name = "LoginWrong";
            this.LoginWrong.Size = new System.Drawing.Size(229, 20);
            this.LoginWrong.TabIndex = 14;
            this.LoginWrong.Text = "Wrong Username / Password";
            this.LoginWrong.Visible = false;
            // 
            // CreatMeeting
            // 
            this.CreatMeeting.Controls.Add(this.CreateMeetingAddexternButtom);
            this.CreatMeeting.Controls.Add(this.richTextBox1);
            this.CreatMeeting.Controls.Add(this.CreateMeetingAttendancecomboBox);
            this.CreatMeeting.Controls.Add(this.CreateMeetingAttendanceLabel);
            this.CreatMeeting.Controls.Add(this.CreateMeetingEndtimeLabel);
            this.CreatMeeting.Controls.Add(this.CreateMeetingEndtimeDatePicker);
            this.CreatMeeting.Controls.Add(this.CreateMeetingStarttimeLabel);
            this.CreatMeeting.Controls.Add(this.CreateMeetingAddsubmeetingButtom);
            this.CreatMeeting.Controls.Add(this.CreateMeetingFullAgendaLabel);
            this.CreatMeeting.Controls.Add(this.CreateMeetingStarttimeDatePicker);
            this.CreatMeeting.Controls.Add(this.CreateMeetingAddAgendaItemButtom);
            this.CreatMeeting.Controls.Add(this.CreateMeetingAgendaLabel);
            this.CreatMeeting.Controls.Add(this.CreateMeetingDescriptionRichtextbox);
            this.CreatMeeting.Controls.Add(this.CreateMeetingDescriptionLabel);
            this.CreatMeeting.Controls.Add(this.CreateMeetingTitleTextbox);
            this.CreatMeeting.Controls.Add(this.CreateMeetingTittleLabel);
            this.CreatMeeting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreatMeeting.Location = new System.Drawing.Point(0, 0);
            this.CreatMeeting.Name = "CreatMeeting";
            this.CreatMeeting.Size = new System.Drawing.Size(1685, 938);
            this.CreatMeeting.TabIndex = 4;
            // 
            // CreateMeetingAddexternButtom
            // 
            this.CreateMeetingAddexternButtom.Location = new System.Drawing.Point(1501, 223);
            this.CreateMeetingAddexternButtom.Name = "CreateMeetingAddexternButtom";
            this.CreateMeetingAddexternButtom.Size = new System.Drawing.Size(123, 22);
            this.CreateMeetingAddexternButtom.TabIndex = 15;
            this.CreateMeetingAddexternButtom.Text = "Tilføj ekstern";
            this.CreateMeetingAddexternButtom.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1183, 257);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(441, 333);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // CreateMeetingAttendancecomboBox
            // 
            this.CreateMeetingAttendancecomboBox.FormattingEnabled = true;
            this.CreateMeetingAttendancecomboBox.Location = new System.Drawing.Point(1185, 223);
            this.CreateMeetingAttendancecomboBox.Name = "CreateMeetingAttendancecomboBox";
            this.CreateMeetingAttendancecomboBox.Size = new System.Drawing.Size(304, 24);
            this.CreateMeetingAttendancecomboBox.TabIndex = 13;
            // 
            // CreateMeetingAttendanceLabel
            // 
            this.CreateMeetingAttendanceLabel.AutoSize = true;
            this.CreateMeetingAttendanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMeetingAttendanceLabel.Location = new System.Drawing.Point(1180, 194);
            this.CreateMeetingAttendanceLabel.Name = "CreateMeetingAttendanceLabel";
            this.CreateMeetingAttendanceLabel.Size = new System.Drawing.Size(140, 25);
            this.CreateMeetingAttendanceLabel.TabIndex = 12;
            this.CreateMeetingAttendanceLabel.Text = "Møde Deltager";
            // 
            // CreateMeetingEndtimeLabel
            // 
            this.CreateMeetingEndtimeLabel.AutoSize = true;
            this.CreateMeetingEndtimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMeetingEndtimeLabel.Location = new System.Drawing.Point(1419, 102);
            this.CreateMeetingEndtimeLabel.Name = "CreateMeetingEndtimeLabel";
            this.CreateMeetingEndtimeLabel.Size = new System.Drawing.Size(97, 25);
            this.CreateMeetingEndtimeLabel.TabIndex = 11;
            this.CreateMeetingEndtimeLabel.Text = "End TIme";
            // 
            // CreateMeetingEndtimeDatePicker
            // 
            this.CreateMeetingEndtimeDatePicker.Location = new System.Drawing.Point(1424, 130);
            this.CreateMeetingEndtimeDatePicker.Name = "CreateMeetingEndtimeDatePicker";
            this.CreateMeetingEndtimeDatePicker.Size = new System.Drawing.Size(200, 22);
            this.CreateMeetingEndtimeDatePicker.TabIndex = 10;
            // 
            // CreateMeetingStarttimeLabel
            // 
            this.CreateMeetingStarttimeLabel.AutoSize = true;
            this.CreateMeetingStarttimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMeetingStarttimeLabel.Location = new System.Drawing.Point(1180, 102);
            this.CreateMeetingStarttimeLabel.Name = "CreateMeetingStarttimeLabel";
            this.CreateMeetingStarttimeLabel.Size = new System.Drawing.Size(102, 25);
            this.CreateMeetingStarttimeLabel.TabIndex = 9;
            this.CreateMeetingStarttimeLabel.Text = "Start Time";
            this.CreateMeetingStarttimeLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // CreateMeetingAddsubmeetingButtom
            // 
            this.CreateMeetingAddsubmeetingButtom.Location = new System.Drawing.Point(822, 99);
            this.CreateMeetingAddsubmeetingButtom.Name = "CreateMeetingAddsubmeetingButtom";
            this.CreateMeetingAddsubmeetingButtom.Size = new System.Drawing.Size(170, 33);
            this.CreateMeetingAddsubmeetingButtom.TabIndex = 8;
            this.CreateMeetingAddsubmeetingButtom.Text = "Tilføj Dagsordenspunkt";
            this.CreateMeetingAddsubmeetingButtom.UseVisualStyleBackColor = true;
            // 
            // CreateMeetingFullAgendaLabel
            // 
            this.CreateMeetingFullAgendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMeetingFullAgendaLabel.Location = new System.Drawing.Point(546, 139);
            this.CreateMeetingFullAgendaLabel.Name = "CreateMeetingFullAgendaLabel";
            this.CreateMeetingFullAgendaLabel.Size = new System.Drawing.Size(446, 462);
            this.CreateMeetingFullAgendaLabel.TabIndex = 7;
            // 
            // CreateMeetingStarttimeDatePicker
            // 
            this.CreateMeetingStarttimeDatePicker.Location = new System.Drawing.Point(1185, 130);
            this.CreateMeetingStarttimeDatePicker.Name = "CreateMeetingStarttimeDatePicker";
            this.CreateMeetingStarttimeDatePicker.Size = new System.Drawing.Size(200, 22);
            this.CreateMeetingStarttimeDatePicker.TabIndex = 6;
            // 
            // CreateMeetingAddAgendaItemButtom
            // 
            this.CreateMeetingAddAgendaItemButtom.Location = new System.Drawing.Point(712, 99);
            this.CreateMeetingAddAgendaItemButtom.Name = "CreateMeetingAddAgendaItemButtom";
            this.CreateMeetingAddAgendaItemButtom.Size = new System.Drawing.Size(101, 32);
            this.CreateMeetingAddAgendaItemButtom.TabIndex = 5;
            this.CreateMeetingAddAgendaItemButtom.Text = "Tilføj Emne";
            this.CreateMeetingAddAgendaItemButtom.UseVisualStyleBackColor = true;
            // 
            // CreateMeetingAgendaLabel
            // 
            this.CreateMeetingAgendaLabel.AutoSize = true;
            this.CreateMeetingAgendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMeetingAgendaLabel.Location = new System.Drawing.Point(541, 99);
            this.CreateMeetingAgendaLabel.Name = "CreateMeetingAgendaLabel";
            this.CreateMeetingAgendaLabel.Size = new System.Drawing.Size(108, 25);
            this.CreateMeetingAgendaLabel.TabIndex = 4;
            this.CreateMeetingAgendaLabel.Text = "Dagsorden";
            this.CreateMeetingAgendaLabel.Click += new System.EventHandler(this.CreateMeetingAgendaLabel_Click);
            // 
            // CreateMeetingDescriptionRichtextbox
            // 
            this.CreateMeetingDescriptionRichtextbox.Location = new System.Drawing.Point(22, 232);
            this.CreateMeetingDescriptionRichtextbox.Name = "CreateMeetingDescriptionRichtextbox";
            this.CreateMeetingDescriptionRichtextbox.Size = new System.Drawing.Size(400, 97);
            this.CreateMeetingDescriptionRichtextbox.TabIndex = 3;
            this.CreateMeetingDescriptionRichtextbox.Text = "";
            // 
            // CreateMeetingDescriptionLabel
            // 
            this.CreateMeetingDescriptionLabel.AutoSize = true;
            this.CreateMeetingDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMeetingDescriptionLabel.Location = new System.Drawing.Point(17, 203);
            this.CreateMeetingDescriptionLabel.Name = "CreateMeetingDescriptionLabel";
            this.CreateMeetingDescriptionLabel.Size = new System.Drawing.Size(167, 25);
            this.CreateMeetingDescriptionLabel.TabIndex = 2;
            this.CreateMeetingDescriptionLabel.Text = "Møde Beskrivelse";
            this.CreateMeetingDescriptionLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // CreateMeetingTitleTextbox
            // 
            this.CreateMeetingTitleTextbox.Location = new System.Drawing.Point(22, 139);
            this.CreateMeetingTitleTextbox.Name = "CreateMeetingTitleTextbox";
            this.CreateMeetingTitleTextbox.Size = new System.Drawing.Size(406, 22);
            this.CreateMeetingTitleTextbox.TabIndex = 1;
            this.CreateMeetingTitleTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CreateMeetingTittleLabel
            // 
            this.CreateMeetingTittleLabel.AutoSize = true;
            this.CreateMeetingTittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMeetingTittleLabel.Location = new System.Drawing.Point(17, 107);
            this.CreateMeetingTittleLabel.Name = "CreateMeetingTittleLabel";
            this.CreateMeetingTittleLabel.Size = new System.Drawing.Size(104, 25);
            this.CreateMeetingTittleLabel.TabIndex = 0;
            this.CreateMeetingTittleLabel.Text = "Møde Titel";
            // 
            // MeetingsCreateButtom
            // 
            this.MeetingsCreateButtom.Location = new System.Drawing.Point(1501, 107);
            this.MeetingsCreateButtom.Name = "MeetingsCreateButtom";
            this.MeetingsCreateButtom.Size = new System.Drawing.Size(123, 42);
            this.MeetingsCreateButtom.TabIndex = 4;
            this.MeetingsCreateButtom.Text = "Opret møde";
            this.MeetingsCreateButtom.UseVisualStyleBackColor = true;
            this.MeetingsCreateButtom.Click += new System.EventHandler(this.MeetingsCreateButtom_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 938);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MeetingTab);
            this.Controls.Add(this.ProjectTab);
            this.Controls.Add(this.UserTab);
            this.Controls.Add(this.ProfileTab);
            this.Controls.Add(this.LoginPage);
            this.Controls.Add(this.MeetingPage);
            this.Controls.Add(this.CreatMeeting);
            this.Controls.Add(this.CustomerTab);
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.MeetingPage.ResumeLayout(false);
            this.MeetingPage.PerformLayout();
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.CreatMeeting.ResumeLayout(false);
            this.CreatMeeting.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel CreatMeeting;
        private System.Windows.Forms.TextBox CreateMeetingTitleTextbox;
        private System.Windows.Forms.Label CreateMeetingTittleLabel;
        private System.Windows.Forms.Label CreateMeetingDescriptionLabel;
        private System.Windows.Forms.Label CreateMeetingAgendaLabel;
        private System.Windows.Forms.RichTextBox CreateMeetingDescriptionRichtextbox;
        private System.Windows.Forms.Label CreateMeetingStarttimeLabel;
        private System.Windows.Forms.Button CreateMeetingAddsubmeetingButtom;
        private System.Windows.Forms.TreeView CreateMeetingFullAgendaLabel;
        private System.Windows.Forms.DateTimePicker CreateMeetingStarttimeDatePicker;
        private System.Windows.Forms.Button CreateMeetingAddAgendaItemButtom;
        private System.Windows.Forms.Button CreateMeetingAddexternButtom;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox CreateMeetingAttendancecomboBox;
        private System.Windows.Forms.Label CreateMeetingAttendanceLabel;
        private System.Windows.Forms.Label CreateMeetingEndtimeLabel;
        private System.Windows.Forms.DateTimePicker CreateMeetingEndtimeDatePicker;
        private System.Windows.Forms.Button MeetingsCreateButtom;
    }
}

