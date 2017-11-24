using System.Collections.Generic;
namespace WindowsFormsSolution.Models
{
    public class Submeeting
    {
        //public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Referat { get; private set; }
        public int ProjectID { get; set; }
        public int MeetingID { get; set; }
        public Meeting Meeting { get; set; }
        public Project Project { get; set; }
        public List<Attachment> Attachments { get; set; }

/*        public override string ToString()
        {
            
            return $"{Title} {Description} {Meeting.Description} {Meeting.EndTime.ToString()} {Meeting.Title} {Meeting.StartTime.ToString()} ";
        }*/
    }
}