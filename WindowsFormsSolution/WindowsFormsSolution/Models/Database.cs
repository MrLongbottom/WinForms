﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSolution.Models
{
    public class Database
    {
        public List<Project> projects { private set; get; } = new List<Project>();
        public List<Meeting> meetings { private set; get; } = new List<Meeting>();
        public List<Submeeting> submeetings { private set; get; } = new List<Submeeting>();
        public List<User> users { private set; get; } = new List<User>();
        public List<Customer> customers { private set; get; } = new List<Customer>();
        public List<Attachment> attachments { private set; get; } = new List<Attachment>();

        //I hate git
        public Database()
        {
            users.Add(new User("password", "Børge Børgesen", "Børge@Børgesen.dk", "12345678"));
            customers.Add(new Customer("Frelsen's chokolade", "Frelsen@Chokolade", "Algade 27 9000 Aalborg", "+45 Brev due", "76378162783612783"));
            projects.Add(new Project(users.First(), "Frelsensvandrør", customers.First(), "Algade 27 9000 Aalborg", "Fix frelsens vandrør", null, null));
        }

        public void addExtern(External external)
        {
            externals.Add(external);
        }

        public void removeExternal(External external)
        {
            externals.Remove(external);
        }
        public void addProject(Project project)
        {
            projects.Add(project);
        }

        public void addMeeting(Meeting meeting)
        {
            meetings.Add(meeting);
        }

        public void addSubmeeting(Submeeting submeeting)
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
                throw new InvalidAccessException();
        }

        public void deleteMeeting(Meeting meeting, User currentUser)
        {
            if (currentUser.Admin)
            {
                meetings.Remove(meeting);
            }
            else
                throw new InvalidAccessException();
        }

        public void deleteSubmeeting(Submeeting submeeting, User currentrUser)
        {
            if (currentrUser.Admin || submeeting.Meeting.Owner == currentrUser)//needs to allow atendee roles
            {
                submeetings.Remove(submeeting);
            }
            else
                throw new InvalidAccessException();
        }
        public void deleteUser(User user, User currentrUser)
        {
            if (currentrUser.Admin && user != currentrUser)
            {
                users.Remove(user);
            }
            else
                throw new InvalidAccessException();
        }

        public void deleteCustomer(Customer customer, User currentUser)
        {
            if (currentUser.Admin)
            {
                customers.Remove(customer);
            }
            else
                throw new InvalidAccessException();
        }
        public void deleteAttachment(Attachment attachment, User currentUser)
        {
            if (currentUser == attachment.Owner || currentUser.Admin)
            {
                attachments.Remove(attachment);
            }
            else
                throw new InvalidAccessException();
        }

        public User GetUser(string email)
        {
            foreach(User user in users)
            {
                if (user.Email == email)
                { return user; }
            }
            throw new Exception("No user with the email: " + email);
        }
    }
}
