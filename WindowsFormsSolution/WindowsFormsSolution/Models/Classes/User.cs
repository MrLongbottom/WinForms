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
        public List<Project> Projects { get; set; } = new List<Project>();
        public List<Attachment> Attachments { get; set; } = new List<Attachment>();
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

        public void addAttendace(Attendance attendance)
        {
            Attendances.Add(attendance);
        }

        public void addAttachments(Attachment attachment)
        {
            Attachments.Add(attachment);
        }
    }
}