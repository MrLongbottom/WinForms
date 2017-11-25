using System.Collections.Generic;

namespace WindowsFormsSolution.Models
{
    public class User : Person
    {
        public bool Admin { get; set; } = false;
        public string Password { get; set; }
        /*public string PictureAdress
        {
            get { return this.PictureAdress; }
            set
            {
                if (value == null)
                {
                    throw new CantBeNullException();
                }
                this.PictureAdress = value;
            }
        }*/
        public List<Project> Projects { get; set; }
        //public List<Attendance> Atendances { get; set; }
        public List<Attachment> Attachments { get; set; }
        public User(string _Password, string _Name, string _Email, string _PhoneNumber) : base (_Name, _Email, _PhoneNumber)
        {
            Password = _Password;
        }
        public User(string _PictureAdress, string _Password, string _Name, string _Email, string _PhoneNumber) : base(_Name, _Email, _PhoneNumber)
        {
            Password = _Password;
            //PictureAdress = _PictureAdress;
        }

        public void changeAdminstate(bool state, User currentUser)
        {
            if (currentUser.Admin && currentUser != this)
            {
                Admin = state;
            }
            else
                throw new InvalidAccessException();
        }

        public bool comparePassword(string password)
        {
            if (password == Password)
            {
                return true;
            }
            else
                return false;
        }

        public void changePassword(string newPassword, User currentUser)
        {
            if (currentUser == this || currentUser.Admin)
            {
                Password = newPassword;
            }
            else
                throw new InvalidAccessException();
        }

        /*public void changePicture(string newPicureAdress, User currentUser)
        {
            if (currentUser == this || currentUser.Admin)
            {
                PictureAdress = PictureAdress;
            }
            else
                throw new InvalidAccessException(currentUser);
        }*/

        public void addProject(Project project)
        {
            Projects.Add(project);
        } 

        public void removeProject(Project project, User currUser)
        {
            if (!currUser.Admin && !(currUser == this))
            {
                throw new InvalidAccessException();
            }
            else if (!Projects.Contains(project))
            {
                throw new DoNotContainElementException();
            }
            else
            {
                if (project.Users.Contains(this))
                {
                    project.removeUser(this, currUser);
                }
                Projects.Remove(project);
            }
        }

        public void addAttachments(Attachment attachment)
        {
            Attachments.Add(attachment);
        }

        public override string ToString()
        {
            string userString = "";
            foreach (Attendance attendance in Attendances)
            {
                userString += $" {attendance.Meeting.Description} {attendance.Meeting.EndTime.ToString()} {attendance.Meeting.StartTime.ToString()} {attendance.Meeting.Title}";
                foreach (Submeeting submeeting in attendance.Meeting.Submeetings)
                {
                    userString += $" {submeeting.Referat} {submeeting.Title} {submeeting.Project.Description} {submeeting.Project.Location} {submeeting.Project.Title}";
                }
            }
            foreach (Project project in Projects)
            {
                userString += $" {project.Customer.Address} {project.Customer.Cvr} {project.Customer.Email} {project.Customer.Name} {project.Customer.PhoneNumber} {project.Description} {project.Location} {project.Title}";
            }
            userString += $" {Email} {Name} {PhoneNumber}";
            return userString;
        }
    }
}