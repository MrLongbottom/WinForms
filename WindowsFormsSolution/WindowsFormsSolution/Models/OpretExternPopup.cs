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
    public partial class OpretExternPopup : Form
    {
        Database database;
        public OpretExternPopup(Database _database)
        {
            database = _database;
            InitializeComponent();
        }

        private void CreateExternCreate_Click(object sender, EventArgs e)
        {
            database.addExtern(new External(CreateExternNameBox.Text, CreatExternEmailBox.Text, CreateExternTLFBOx.Text));
            this.Close();
        }

        private void CreateExternCancelButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
