using System.Collections.Generic;

namespace WindowsFormsSolution.Models
{
    public class AgendaItem
    {
        //public int ID { get; set; }
        public string Headline { get; private set; }
       // public string Describtion { get; private set; }
        public List<Submeeting> Submeetings { get; private set; }
        public Meeting Meeting { get; private set; }

        public AgendaItem(string headline, User currUser, Meeting meeting)//, string description)
        {
            Headline = headline;
            Meeting = meeting;
           // Describtion = description;
        }

        public AgendaItem(string headline, List<string> submeetings, User currUser, Meeting meeting)//, string description)
        {
            Headline = headline;
            Meeting = meeting;
            foreach (string submeeting in submeetings)
            {
                Submeetings.Add(new Submeeting(currUser, submeeting, meeting));
            }
           // Describtion = description;
        }

        /*public void changeDescription(string description)
        {
            Describtion = description;
        }*/

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