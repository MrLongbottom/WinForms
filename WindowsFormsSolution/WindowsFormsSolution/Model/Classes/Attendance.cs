using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WinFromsSolution.Models
{
    public class Attendance
    {
        public int ID { get; set; }
        public int MeetingID { get; set; }
        public int PersonID { get; set; }
        public Meeting Meeting { set; get; }
        public Person Person { set; get; }
        public bool Chairman { set; get; }
        public bool Referrent { set; get; }
        public bool Owner { set; get; }
    }
}
