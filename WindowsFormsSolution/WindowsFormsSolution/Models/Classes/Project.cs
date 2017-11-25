using System.Collections.Generic;

namespace WindowsFormsSolution.Models
{
    public class Project
    {
       // public int ID { get; set; }
        public List<Submeeting> Submeetings { get; private set; }
        public List<Attachment> Attachments { get; private set; }
        //We might need to make an attendee kinda role for project
        public List<User> Users { get; private set; }
        public User Owner { get; private set; }
        public string Title { get; set; }
        public Customer Customer { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public Project(User currUser, string tittle, Customer customer, string location, string description, List<User> users, List<Attachment> attachments)
        {
            Owner = currUser;
            Title = tittle;
            Customer = customer;
            Location = location;
            Description = description;
            Users = users;
            Attachments = attachments;
        }

        public void addSubmeeting(Submeeting submeeting)
        {
            Submeetings.Add(submeeting);
        }

        public void removeSubmeeting(Submeeting submeeting, User currUser)
        {
            if (currUser != submeeting.Meeting.Owner && !currUser.Admin)
            {
                throw new InvalidAccessException();
            }
            else if (!Submeetings.Contains(submeeting))
            {
                throw new DoNotContainElementException();
            }
            else
                Submeetings.Remove(submeeting);
        }

        public void addAttachment(Attachment attachment, User currUser)
        {
            if (currUser.Admin || Users.Contains(currUser))
            {
                Attachments.Add(attachment);
            }
            else throw new InvalidAccessException();
        }

        public void removeAttachment(Attachment attachment, User currUser)
        {
            if (!currUser.Admin && !Users.Contains(currUser))
            {
                throw new InvalidAccessException();
            }
            else if (!Attachments.Contains(attachment))
            {
                throw new DoNotContainElementException();
            }
            else Attachments.Remove(attachment);
        }

        public void addUser(User newUser, User currUser)
        {
            if (currUser.Admin || Users.Contains(currUser))
            {
                Users.Add(newUser);
            }
            else throw new InvalidAccessException();
        }

        public void removeUser(User user, User currUser)
        {
            if (!currUser.Admin && !Users.Contains(currUser))
            {
                throw new InvalidAccessException();
            }
            else if (!Users.Contains(user))
            {
                throw new DoNotContainElementException();
            }
            else Users.Remove(user);                                                        
        }

        public override string ToString()
        {
            string submeetingString = "";
            foreach (Submeeting submeeting in Submeetings)
            {
                submeetingString += $" {submeeting.Referat} {submeeting.Description} {submeeting.Title} {submeeting.Meeting.Description} {submeeting.Meeting.EndTime.ToString()} {submeeting.Meeting.Owner} {submeeting.Meeting.StartTime.ToString()} {submeeting.Meeting.Title}";
                foreach (Attendance person in submeeting.Meeting.Attendances)
                {
                    submeetingString += $"{person.Person.Name} {person.Person.Email} {person.Person.PhoneNumber}";
                }
            }
            return $"{Title} {Location} {Description} {Customer.Address} {Customer.Cvr} {Customer.Email} {Customer.Name} {Customer.PhoneNumber} {submeetingString}";
        }
    }
}