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
            currPanel = ProfilePage;
        }

        private Models.Database database { get; }
        private Models.User currUser { get; }
        private Panel currPanel;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ProfileMenuItem_Click(object sender, EventArgs e)
        {
            currPanel.Visible = false;
            currPanel.BackColor = MainMenu.BackColor;
            currPanel = ProfilePage;
            currPanel.Visible = true;
            currPanel.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void MeetingsMenuItem_Click(object sender, EventArgs e)
        {
            currPanel.Visible = false;
        }


















        //Controller
        private void login(string email, string password)
        {
            foreach ( Models.User user in database.users)
            {
                if (email == user.Email)
                {
                    if (password == user.Password)
                    {
                        //makeHomescreenUI(currUser);
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
                    break;
                }
            }
        }


    }
}
