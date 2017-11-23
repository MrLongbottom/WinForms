using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSolution.Model
{
    public class Database
    {
        public List<Project> projects { private set; get; }
        public List<Meeting> meetings { private set; get; }
        public List<SubMeeting> submeetings { private set; get; }
        public List<User> users { private set; get; }
        public List<Customer> customers { private set; get; }
        public List<Attachment> attachments { private set; get; }

        public void addProject(Project project)
        {
            projects.Add(project);
        }

        public void addMeeting(Meeting meeting)
        {
            meetings.Add(meeting);
        }

        public void addSubmeeting(SubMeeting submeeting)
        {
            submeetings.Add(submeeting);
        }

        public void addUser(User user)
        {
            users.Add(user);
        }

        public void addCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void addAttachment(Attachment attachment)
        {
            attachments.Add(attachment);
        }
        public void deleteProject(Project project, User currentUser)
        {
            if (currentUser.Admin)
            {
                projects.Remove(project);
            }
            else
                throw new notAdminException(currentUser);
        }

        public void deleteMeeting(Meeting meeting, User currentUser)
        {
            if (currentUser.Admin)
            {
                meetings.Remove(meeting);
            }
            else
                throw new notAdminException(currentUser);
        }

        public void deleteSubmeeting(SubMeeting submeeting, User currentrUser)
        {
            if (currentrUser.Admin)//needs to allow atendee roles
            {
                submeetings.Remove(submeeting);
            }
            else
                throw new notAdminException(currentrUser);
        }
        public void deleteUser(User user, User currentrUser)
        {
            if (currentrUser.Admin && user != currentrUser)
            {
                users.Remove(user);
            }
            else
                throw new notAdminException(currentrUser);
        }

        public void deleteCustomer(Customer customer, User currentUser)
        {
            if (currentUser.Admin)
            {
                customers.Remove(customer);
            }
            else
                throw new notAdminException(currentUser);
        }
        public void deleteAttachment(Attachment attachment, User currentUser)
        {
            if (currentUser == attachment.owner || currentUser.Admin)
            {
                attachments.Remove(attachment);
            }
            else
                throw new notAdminException(currentUser);
        }
    }
}
