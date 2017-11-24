using System.Collections.Generic;

namespace WindowsFormsSolution.Models
{
    public class Person
    {
       // public int ID { get; set; }
        public string Name
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        public string PhoneNumber
        {
            get; set;
        }
        public List<Attendance> Attendances { private set; get; } = new List<Attendance>();

        public void addAttendance(Attendance attendance)
        {
            Attendances.Add(attendance);
        }
        public Person(string _Name, string _Email, string _PhoneNumber)
        {
            Name = _Name;
            Email = _Email;
            PhoneNumber = _PhoneNumber;
        }

        public void changeName(string newName, User currentUser)
        {
            if (currentUser.Admin || currentUser == this)
            {
                Name = newName;
            }
            else
                throw new InvalidAccessException();
        }
        public void changeEmail(string newEmail, User currentUser)
        {
            if (currentUser.Admin || currentUser == this)
            {
                Email = newEmail;
            }
            else
                throw new InvalidAccessException();
        }
        public void changePhonenumber(string newPhonenumber, User currentUser)
        {
            if (currentUser.Admin || currentUser == this)
            {
                PhoneNumber = newPhonenumber;
            }
            else
                throw new InvalidAccessException();
        }
    }
}
