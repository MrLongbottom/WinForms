using System.Collections.Generic;

namespace WindowsFormsSolution.Models
{
    public class AgendaItem
    {
        //public int ID { get; set; }
        public string Headline { get; private set; }
        public string Describtion { get; private set; }
        public List<Submeeting> Submeetings { get; private set; } = new List<Submeeting>();

        public AgendaItem(string headline, string description)
        {
            Headline = headline;
            Describtion = description;
        }

        public void changeDescription(string description)
        {
            Describtion = description;
        }

        public void changeHeadline(string headline)
        {
            Headline = headline;
        }

        public void addSubmeeting(Submeeting newSubmeeting)
        {
            Submeetings.Add(newSubmeeting);
        }

        public void removeSubmeeting(Submeeting submeeting)
        {
            Submeetings.Remove(submeeting);
        }
    }
}