using System.Collections.Generic;

namespace WinFormSolution.Models
{
    public class AgendaItem
    {
        public int ID { get; set; }
        public string Headline { get; set; }
        public string Describtion { get; set; }
        public List<Submeeting> Submeetings { get; set; }
    }
}