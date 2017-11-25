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
            ProfileTab.Visible = false;
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
            else
            {
                ProfileEditEmailButton.Visible = false;
                ProfileEditNameButton.Visible = false;
                ProfileEditPhoneButton.Visible = false;
                ChangeTab(ProfileTab, null);
            }
        }

        private void MeetingsMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTab(MeetingTab, MeetingsMenuItem);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login(LoginEmalBox.Text, LoginPasswordBox.Text);
        }

        private void ProjectsMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTab(ProjectTab, ProjectsMenuItem);
        }

        private void UsersMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTab(UserTab, UsersMenuItem);
        }

        private void CustomersMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTab(CustomerTab, CustomersMenuItem);
        }
















        //Controller
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
                throw new NotImplementedException("Wrong password / username Combination");
            }
        }

        private void ProfileMeetings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Selected Item #" + ProfileMeetings.SelectedIndex);
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
                ProfileName.Visible = true;
                ProfileEditNameBox.Visible = false;
                currUser.changeName(ProfileEditNameBox.Text, currUser);
                ProfileName.Text = currUser.Name;
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
                ProfileEmail.Visible = true;
                ProfileEditEmailBox.Visible = false;
                currUser.changeEmail(ProfileEditEmailBox.Text, currUser);
                ProfileEmail.Text = "Email: " + currUser.Email;
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
                ProfilePhone.Visible = true;
                ProfileEditPhoneBox.Visible = false;
                currUser.changePhonenumber(ProfileEditPhoneBox.Text, currUser);
                ProfilePhone.Text = "Tlf: " + currUser.PhoneNumber;
            }
        }
    }
}
