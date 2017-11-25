using System.Collections.Generic;

namespace WindowsFormsSolution.Models
{
    public class Person
    {
       // public int ID { get; set; }
        public string Name
        {
            get { return this.Name; }
            set
            {
                if (value == null)
                {
                    throw new CantBeNullException();
                }
                Name = value;
            }
        }
        public string Email
        {
            get { return this.Email; }
            set
            {
                if (value == null)
                {
                    throw new CantBeNullException();
                }
                this.Email = value;
            }
        }
        public string PhoneNumber
        {
            get { return this.PhoneNumber; }
            set
            {
                if (value == null)
                {
                    throw new CantBeNullException();
                }
                this.PhoneNumber = value;
            }
        }
        public List<Attendance> Attendances { private set; get; }

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


        public void addAtendace(Attendance atendance)
        {
            Attendances.Add(atendance);
        }

        public void removeAtendace(Attendance attendance, User currUser)
        {
            if (!currUser.Admin && currUser != this && currUser != attendance.Meeting.Owner)
            {
                throw new InvalidAccessException();
            }
            else if (!Attendances.Contains(attendance))
            {
                throw new DoNotContainElementException();
            }
            else
            {
                if (attendance.Meeting != null)
                {
                    attendance.Meeting.removeAttendance(attendance, currUser);
                }
                Attendances.Remove(attendance);
            }
        }
    }

}

