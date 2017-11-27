using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSolution.Models
{
    public partial class CreateUserPopup : Form
    {
        Database database;
        public CreateUserPopup(Database _database)
        {
            database = _database;
            InitializeComponent();
        }

        private void CreateExternCreate_Click(object sender, EventArgs e)
        {
            database.addUser(new User(PasswordBox.Text, CreateExternNameBox.Text, CreatExternEmailBox.Text, CreateExternTLFBOx.Text));
            this.Close();
        }

        private void CreateExternCancelButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
