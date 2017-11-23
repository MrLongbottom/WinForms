using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormSolution.Models
{
    [Table("submeetings")]
    public class Submeeting
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ProjectID { get; set; }
        public int MeetingID { get; set; }
        public Meeting Meeting { get; set; }
        public Project Project { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}