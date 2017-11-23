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
    public partial class FjordblinkMeetingProgram : Form
    {
        public FjordblinkMeetingProgram()
        {
            InitializeComponent();
            Console.WriteLine("Hello World!");
            currPanel = ProfilePage;
        }

        private Panel currPanel;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ProfileMenuItem_Click(object sender, EventArgs e)
        {
            currPanel.Visible = false;
            currPanel = ProfilePage;
            currPanel.Visible = true;
        }

        private void MeetingsMenuItem_Click(object sender, EventArgs e)
        {
            currPanel.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Index: " + listBox1.SelectedIndex);
        }
    }
}
