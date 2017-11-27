using System.Collections.Generic;

namespace WindowsFormsSolution.Models
{
    public class Project
    {
        // public int ID { get; set; }
        public List<Submeeting> Submeetings { get; private set; } = new List<Submeeting>();
        public List<Attachment> Attachments { get; private set; } = new List<Attachment>();
        //We might need to make an attendee kinda role for project
        public List<User> Users { get; private set; } = new List<User>();
        public User Owner { get; private set; }
        public string Title { get; private set; }
        public Customer Customer { get; private set; }
        public string Location { get; private set; }
        public string Description { get; private set; }

        public Project(User currUser, string tittle, Customer customer, string location, string description, List<User> users, List<Attachment> attachments)
        {
            Owner = currUser;
            Title = tittle;
            Customer = customer;
            Location = location;
            Description = description;
            Users = users;
            Users.Add(currUser);
            Attachments = attachments;
            Customer.addProject(this);
            foreach (User user in users)
            {
                user.addProject(this);
            }
        }
        public void changeCostumer(Customer customer, User currUser)
        {
            if (currUser.Admin || Users.Contains(currUser))
            {
                Customer = customer;
            }
            else throw new InvalidAccessException();
        }

        public void changeDescription(string newDescription, User currUser)
        {
            if (currUser.Admin || Users.Contains(currUser))
            {
                Description = newDescription;
            }
            else throw new InvalidAccessException();
        }

        public void changeLocation(string newLocation, User currUser)
        {
            if (currUser.Admin || Users.Contains(currUser))
            {
                Location = newLocation;
            }
            else throw new InvalidAccessException();
        }

        public void changeTitle(string newTittle, User currUser)
        {
            if (currUser.Admin || Users.Contains(currUser))
            {
                Title = newTittle;
            }
            else throw new InvalidAccessException();
        }

        public void changeOwner(User newOwner, User currUser)
        {
            if (currUser.Admin || currUser == Owner)
            {
                Owner = newOwner;
                if (!Users.Contains(Owner))
                {
                    Users.Add(Owner);
                    Owner.addProject(this);
                }
            }
            else throw new InvalidAccessException();
        }

        public void addSubmeeting(Submeeting submeeting)
        {
            Submeetings.Add(submeeting);
            if (submeeting.Project != this)
            {
                submeeting.addProject(this);
            }
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
            else
            {
                if (user.Projects.Contains(this))
                {
                    user.removeProject(this, currUser);
                }
                Users.Remove(user);
            }
        }

        public override string ToString()
        {
            string submeetingString = "";
            foreach (Submeeting submeeting in Submeetings)
            {
                submeetingString += $" {submeeting.Referat} {submeeting.Title} {submeeting.Meeting.Description} {submeeting.Meeting.EndTime.ToString()} {submeeting.Meeting.Owner} {submeeting.Meeting.StartTime.ToString()} {submeeting.Meeting.Title}";
                foreach (Attendance person in submeeting.Meeting.Attendances)
                {
                    submeetingString += $"{person.Person.Name} {person.Person.Email} {person.Person.PhoneNumber}";
                }
            }
            return $"{Title} {Location} {Description} {Customer.Address} {Customer.Cvr} {Customer.Email} {Customer.Name} {Customer.PhoneNumber} {submeetingString}";
        }
    }
}