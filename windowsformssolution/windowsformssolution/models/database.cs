using System;
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
        public List<External> externals { private set; get; } = new List<External>();
        public List<Customer> customers { private set; get; } = new List<Customer>();
        public List<Attachment> attachments { private set; get; } = new List<Attachment>();
        public List<Attendance> Attendances { get; private set; } = new List<Attendance>();

        //Fix

        public Database()
        {
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
            for (int i = 0; i < users.Count; i++)
            {
                if (project.Users.Contains(users.ElementAt<User>(i)))
                {
                    users.ElementAt<User>(i).Projects.Add(projects.Last<Project>());
                }
            }
        }

        public void addMeeting(Meeting meeting, List<Person> attendances)
        {
            meetings.Add(meeting);
            for (int i = 0; i < users.Count; i++)
            {
                if (attendances.Contains(users.ElementAt<User>(i)))
                {
                    if (attendances.First<Person>() == users.ElementAt<User>(i))
                    {
                        Attendances.Add(new Attendance(meetings.Last<Meeting>(), users.ElementAt<User>(i), false, false, true));
                    }
                    else
                    {
                        Attendances.Add(new Attendance(meetings.Last<Meeting>(), users.ElementAt<User>(i), false, false, false));
                    }
                }
            }
            for (int i = 0; i < externals.Count; i++)
            {
                if (attendances.Contains(externals.ElementAt<External>(i)))
                {
                    Attendances.Add(new Attendance(meetings.Last<Meeting>(), externals.ElementAt<External>(i), false, false, false));
                }
            }
           /* for (int i = 0; i < users.Count; i++)
            {
                foreach (Attendance attendance in meetings.Last<Meeting>().Attendances)
                {
                    if (attendance.Person.Email == users.ElementAt<User>(i).Email)
                    {
                        if (attendance.Person.Email == meetings.Last<Meeting>().Attendances.First<Attendance>().Person.Email)
                        {
                            users.ElementAt<User>(i).addAtendace(new Attendance(meetings.Last<Meeting>(), users.ElementAt<User>(i), false, false, true));
                        }
                        else
                        {
                            users.ElementAt<User>(i).addAtendace(new Attendance(meetings.Last<Meeting>(), users.ElementAt<User>(i), false, false, false));
                        }
                    }
                }
            }*/
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

        public User GetUserByEmail(string email)
        {
            foreach(User user in users)
            {
                if (user.Email == email)
                { return user; }
            }
            throw new Exception("No user with the email: " + email);
        }

        public User GetUserByName(string name)
        {
            foreach (User user in users)
            {
                if (user.Name == name)
                { return user; }
            }
            throw new Exception("No user with the name: " + name);
        }

        public Person GetPersonByName(string name)
        {
            foreach (Person person in users)
            {
                if (person.Name == name)
                { return person; }
            }
            foreach (Person person in externals)
            {
                if (person.Name == name)
                { return person; }
            }
            throw new Exception("No person with the name: " + name);
        }
        public Customer GetCustomerByName(string name)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Name == name)
                { return customer; }
            }
            throw new Exception("No user with the name: " + name);
        }

        internal Meeting GetMeetingByTitle(string title)
        {
            foreach (Meeting meet in meetings)
            {
                if (meet.Title == title)
                { return meet; }
            }
            throw new Exception("No meeting with the title: " + title);
        }

        internal Project GetProjectByTitle(string title)
        {
            foreach (Project pro in projects)
            {
                if (pro.Title == title)
                { return pro; }
            }
            throw new Exception("No meeting with the title: " + title);
        }
    }
}
