using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSolution
{
    public partial class MainForm : Form
    {
        public MainForm(Models.Database data)
        {
            database = data;
            InitializeComponent();
            Console.WriteLine("Hello World!");
            currPanel = LoginPage;
            LoginPage.Visible = true;
            CustomerTab.Visible = false;
            UserTab.Visible = false;
            ProjectTab.Visible = false;
            ProfileTab.Visible = false;
            MeetingTab.Visible = false;
            MeetingPage.Visible = false;
        }

        private Models.Database database { get; }
        private Models.User currUser { set; get; }
        private Panel currPanel;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChangeTab (Panel toPanel, ToolStripMenuItem toMenuItem)
        {
            currPanel.Visible = false;
            currPanel = toPanel;
            currPanel.Visible = true;
            if (toMenuItem != null)
            {
                foreach (ToolStripMenuItem item in MainMenu.Items)
                {
                    item.BackColor = MainMenu.BackColor;
                }
                toMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            }
        }

        private void ProfileMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserWindow(currUser);
        }

        //user is not stored, so changing information is hard
        public void LoadUserWindow(Models.User user)
        {
            ProfileMeetings.Items.Clear();
            foreach (Models.Attendance att in user.Attendances)
            {
                ProfileMeetings.Items.Add(att.Meeting.Title);
            }
            ProfileProjects.Items.Clear();
            foreach (Models.Project pro in user.Projects)
            {
                ProfileProjects.Items.Add(pro.Title);
            }
            ProfileName.Text = user.Name;
            ProfileEmail.Text = "Email: " + user.Email;
            ProfilePhone.Text = "Tlf: " + user.PhoneNumber;
            if (user == currUser)
            {
                ProfileEditEmailButton.Visible = true;
                ProfileEditNameButton.Visible = true;
                ProfileEditPhoneButton.Visible = true;
                ChangeTab(ProfileTab, ProfileMenuItem);
            }
            else if (currUser.Admin)
            {
                ProfileEditEmailButton.Visible = true;
                ProfileEditNameButton.Visible = true;
                ProfileEditPhoneButton.Visible = true;
                ChangeTab(ProfileTab, UsersMenuItem);
            }
            else
            {
                ProfileEditEmailButton.Visible = false;
                ProfileEditNameButton.Visible = false;
                ProfileEditPhoneButton.Visible = false;
                ChangeTab(ProfileTab, UsersMenuItem);
            }
        }

        private void MeetingsMenuItem_Click(object sender, EventArgs e)
        {
            MeetingsUpcomingBox.Items.Clear();
            MeetingsFormerBox.Items.Clear();
            foreach (Models.Attendance att in currUser.Attendances)
            {
                if (att.Meeting.StartTime <= DateTime.Now)
                {
                    MeetingsFormerBox.Items.Add(att.Meeting.Title);
                }
                else
                {
                    MeetingsUpcomingBox.Items.Add(att.Meeting.Title);
                }
            }
            ChangeTab(MeetingTab, MeetingsMenuItem);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login(LoginEmalBox.Text, LoginPasswordBox.Text);
        }

        private void ProjectsMenuItem_Click(object sender, EventArgs e)
        {
            ProjectFormerBox.Items.Clear();
            ProjectCurrentBox.Items.Clear();
            foreach(Models.Project pro in currUser.Projects)
            {
                ProjectCurrentBox.Items.Add(pro.Title);
            }
            ChangeTab(ProjectTab, ProjectsMenuItem);
        }

        private void UsersMenuItem_Click(object sender, EventArgs e)
        {
            UsersFormerBox.Items.Clear();
            foreach (Models.User user in database.users)
            {
                //UsersCurrentBox.Items.Add(user.Name);
            }
            UsersCurrentBox.Items.Clear();
            foreach (Models.User user in database.users)
            {
                UsersCurrentBox.Items.Add(user.Name);
            }
            UsersExternalsBox.Items.Clear();
            foreach (Models.External ext in database.externals)
            {
                UsersExternalsBox.Items.Add(ext.Name);
            }
            ChangeTab(UserTab, UsersMenuItem);
        }

        private void CustomersMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTab(CustomerTab, CustomersMenuItem);
        }

        private void Login(string email, string password)
        {
            foreach ( Models.User user in database.users)
            {
                if (email.ToLower() == user.Email.ToLower() && password == user.Password)
                {
                    currUser = user;
                    MainMenu.Visible = true;
                    SearchBar.Visible = true;
                    SearchButton.Visible = true;
                    SearchButton.BringToFront();
                    SearchBar.BringToFront();
                    ProfileMenuItem_Click(null, null);
                    return;
                }
            }
            if (database.users.Count == 0)
            {
                throw new ArgumentNullException("No users in database");
            }
            else
            {
                LoginWrong.Visible = true;
                LoginEmalBox.Clear();
                LoginPasswordBox.Clear();
            }
        }

        private void ProfileMeetings_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMeetingWindow(database.GetMeetingByTitle(ProfileMeetings.SelectedItem.ToString()));
        }

        private void LoginPasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { LoginButton_Click(sender, e); }
        }

        private void ProfileEditNameButton_Click(object sender, EventArgs e)
        {
            if (ProfileName.Visible)
            {
                ProfileEditNameBox.Visible = true;
                ProfileName.Visible = false;
            }
            else
            {
                Models.User user = database.GetUserByEmail(ProfileEmail.Text.Substring(7));
                ProfileName.Visible = true;
                ProfileEditNameBox.Visible = false;
                user.changeName(ProfileEditNameBox.Text, user);
                ProfileName.Text = user.Name;
            }
        }

        private void ProfileEditEmailButton_Click(object sender, EventArgs e)
        {
            if (ProfileEmail.Visible)
            {
                ProfileEditEmailBox.Visible = true;
                ProfileEmail.Visible = false;
            }
            else
            {
                Models.User user = database.GetUserByEmail(ProfileEmail.Text.Substring(7));
                ProfileEmail.Visible = true;
                ProfileEditEmailBox.Visible = false;
                user.changeEmail(ProfileEditEmailBox.Text, user);
                ProfileEmail.Text = "Email: " + user.Email;
            }
        }

        private void ProfileEditPhoneButton_Click(object sender, EventArgs e)
        {
            if (ProfilePhone.Visible)
            {
                ProfileEditPhoneBox.Visible = true;
                ProfilePhone.Visible = false;
            }
            else
            {
                Models.User user = database.GetUserByEmail(ProfileEmail.Text.Substring(7));
                ProfilePhone.Visible = true;
                ProfileEditPhoneBox.Visible = false;
                user.changePhonenumber(ProfileEditPhoneBox.Text, user);
                ProfilePhone.Text = "Tlf: " + user.PhoneNumber;
            }
        }

        private void logUdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTab(LoginPage, null);
            MainMenu.Visible = false;
            SearchBar.Visible = false;
            SearchButton.Visible = false;
            LoginWrong.Visible = false;
            LoginEmalBox.Clear();
            LoginPasswordBox.Clear();
        }

        private void ProfileEditNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            ProfileEditNameButton_Click(sender, e);
        }

        private void ProfileEditEmailBox_KeyDown(object sender, KeyEventArgs e)
        {
            ProfileEditEmailButton_Click(sender, e);
        }

        private void ProfileEditPhoneBox_KeyDown(object sender, KeyEventArgs e)
        {
            ProfileEditPhoneBox_KeyDown(sender, e);
        }

        private void UsersCurrentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (database.GetUserByName(UsersCurrentBox.SelectedItem.ToString()) != null)
            {
                LoadUserWindow(database.GetUserByName(UsersCurrentBox.SelectedItem.ToString()));
            }
        }

        private void LoadMeetingWindow(Models.Meeting meeting)
        {
            MeetingTitleLabel.Text = meeting.Title;
            MeetingDescriptionLabel.Text = meeting.Description;
            MeetingStartingTimeLabel.Text = "Start tidspunkt: " + meeting.StartTime.ToString();
            MeetingEndingTimeLabel.Text = "Slut tidspunkt: " + meeting.EndTime.ToString();
            //Mødedeltager Setup
            MeetingAtendeeBox.Items.Clear();
            foreach(Models.Attendance att in meeting.Attendances)
            {
                MeetingAtendeeBox.Items.Add(att.Person.Name);
            }
            //Dagsorden Setup
            MeetingAgendaTree.Nodes.Clear();
            foreach (Models.AgendaItem agen in meeting.AgendaItems)
            {
                List<TreeNode> children = new List<TreeNode>();
                foreach(Models.Submeeting sub in agen.Submeetings)
                {
                    children.Add(new TreeNode(sub.Title));
                }
                MeetingAgendaTree.Nodes.Add(new TreeNode(agen.Headline, children.ToArray()));
            }

            ChangeTab(MeetingPage, MeetingsMenuItem);
        }

        private void LoadProjectWindow(Models.Project pro)
        {
            ProjectTitleLabel.Text = pro.Title;
            ProjectReferBox.Items.Clear();
            foreach(Models.Submeeting sub in pro.Submeetings)
            {
                ProjectReferBox.Items.Add(sub.Title + ": " + sub.Referat);
            }
            ProjectUsersBox.Items.Clear();
            foreach(Models.User use in pro.Users)
            {
                ProjectUsersBox.Items.Add(use.Name);
            }
            ChangeTab(ProjectPage, ProjectsMenuItem);
        }

        private void MeetingsUpcomingBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (database.GetMeetingByTitle(MeetingsUpcomingBox.SelectedItem.ToString()) != null)
            {
                LoadMeetingWindow(database.GetMeetingByTitle(MeetingsUpcomingBox.SelectedItem.ToString()));
            }
        }

        private void MeetingAtendeeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (database.GetUserByName(MeetingAtendeeBox.SelectedItem.ToString()) != null)
            {
                LoadUserWindow(database.GetUserByName(MeetingAtendeeBox.SelectedItem.ToString()));
            }
        }

        private void ProfileProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (database.GetProjectByTitle(ProfileProjects.SelectedItem.ToString()) != null)
            {
                LoadProjectWindow(database.GetProjectByTitle(ProfileProjects.SelectedItem.ToString()));
            }
        }

        private void ProjectCurrentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (database.GetProjectByTitle(ProjectCurrentBox.SelectedItem.ToString()) != null)
            {
                LoadProjectWindow(database.GetProjectByTitle(ProjectCurrentBox.SelectedItem.ToString()));
            }
        }

        private void ProjectFormerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (database.GetProjectByTitle(ProjectFormerBox.SelectedItem.ToString()) != null)
            {
                LoadProjectWindow(database.GetProjectByTitle(ProjectFormerBox.SelectedItem.ToString()));
            }
        }
    }
}
