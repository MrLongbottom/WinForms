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
            foreach (ToolStripMenuItem item in MainMenu.Items)
            {
                item.BackColor = MainMenu.BackColor;
            }
            currPanel = toPanel;
            currPanel.Visible = true;
            toMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void ProfileMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTab(ProfileTab, ProfileMenuItem);
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
                if (email == user.Email && password == user.Password)
                {
                    currUser = user;
                    MainMenu.Visible = true;
                    ChangeTab(ProfileTab, ProfileMenuItem);
                    return;
                }
            }
            if (database.users.Count == 0)
            {
                MainMenu.Visible = true;
                SearchBar.Visible = true;
                SearchButton.Visible = true;
                ChangeTab(ProfileTab, ProfileMenuItem);
                return;
                //throw new ArgumentNullException("No users in database");
            }
            else
            {
                throw new NotImplementedException("Wrong password / username Combination");
            }
        }
    }
}
