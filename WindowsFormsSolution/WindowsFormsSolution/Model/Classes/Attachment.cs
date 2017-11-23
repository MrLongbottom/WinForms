using System;
using System.Collections.Generic;

namespace WinFormSolution.Models
{
    public class Attachment
    {
        public int ID { get; set; }
        public int OwnerID { get; set; }
        public User Owner { get; set; }
        public DateTime UploadTime { get; set; }
        public List<Comment> Comments { get; set; }
        /*public Attachment(User owner)
        {
            Owner = owner;
            UploadTime = DateTime.Now;
        }*/
    }
}
