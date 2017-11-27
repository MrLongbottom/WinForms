using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSolution.Models.Classes
{
    public class CreatMeetingAgendaBuilder
    {
        public string Agendapoint { get; set; }
        public List<string> Submeetings { get; set; } = new List<string>();

        public CreatMeetingAgendaBuilder(string agendapoint)
        {
            Agendapoint = agendapoint;
        }

        public override string ToString()
        {
            return Agendapoint;
        }
    }
}
