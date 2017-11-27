using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSolution.Models.Classes
{
    public partial class SubmeetingPopup : Form
    {
        Database _database;
        List<CreatMeetingAgendaBuilder> _agendaBuilders = new List<CreatMeetingAgendaBuilder>();
        public SubmeetingPopup(Database database, List<CreatMeetingAgendaBuilder> agendaBuilder)
        {
            _database = database;
            _agendaBuilders = agendaBuilder;
            InitializeComponent();
            foreach (CreatMeetingAgendaBuilder agendaItem in _agendaBuilders)
            {
                HovedpunktcomboBox.Items.Add(agendaItem.Agendapoint);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _agendaBuilders.Count; i++)
            {
                if (_agendaBuilders.ElementAt<CreatMeetingAgendaBuilder>(i).Agendapoint == HovedpunktcomboBox.Text)
                {
                    _agendaBuilders.ElementAt<CreatMeetingAgendaBuilder>(i).Submeetings.Add(UnderpunktrichTextBox1.Text);
                }
            }
            this.Close();
        }

        private void AnnullereButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
