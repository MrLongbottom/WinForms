using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WinFromsSolution.Models
{
    public class Attendance
    {
        //public int ID { get; set; }
        //public int MeetingID { get; set; }
        //public int PersonID { get; set; }
        public Meeting Meeting { private set; get; }
        public Person Person { private set; get; }
        public bool Chairman { private set; get; }
        public bool Referrent { private set; get; }

        public Attendance(Meeting meeting, Person person, bool chairman, bool referrent, bool owner)
        {
            Meeting = meeting;
            Person = person;
            Chairman = chairman;
            Referrent = referrent;
            Meeting.addAttendance(this);
            Person.addAttendance(this);
        }

        public void setChairman(bool state)
        {
            Chairman = state;
        }

        public void setReferrent(bool state)
        {
            Chairman = state;
        }
    }
}
