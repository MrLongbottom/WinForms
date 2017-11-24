using System.Collections.Generic;

namespace WindowsFormsSolution.Models
{
    public class Project
    {
       // public int ID { get; set; }
        public List<Submeeting> Submeetings { get; set; }
        public List<Attachment> Attachments { get; set; }
        //We might need to make an attendee kinda role for project
        //public List<User> Users { get; set; }
        public string Title { get; set; }
        public Customer Customer { get; set; }
        public int CustomerID { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        /*public override string ToString()
        {
            return Title + Location + Description;
        }*/
    }
}