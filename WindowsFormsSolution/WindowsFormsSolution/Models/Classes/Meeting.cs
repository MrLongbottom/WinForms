﻿using System.Collections.Generic;
using System;

namespace WindowsFormsSolution.Models
{
    public class Meeting
    {
        //public int ID { get; set; }
        public string Title { get; set; }
        public User Owner { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public List<Attendance> Attendances { get; set; }
        public List<Submeeting> Submeetings { get; set; }
        public List<AgendaItem> AgendaItems { get; set; }
        public List<Attachment> Attachments { get; set; }

        public void addAttendance(Attendance attendance)
        {
            Attendances.Add(attendance);
        }

        public Meeting(string title, User user, DateTime startTime, TimeSpan duration, string description, params Attendance[] attendances)
        {
            Title = title;
            Owner = user;
            StartTime = startTime;
            Description = description;
            foreach (Attendance attendance in attendances)
            {
                
            }
        }

        public void ChangeDescription(string description, User currUser)
        {
            if (currUser != Owner && !currUser.Admin)
            {
                throw new InvalidAccessException();
            }
            else
            {
                Description = description;
            }
        }

        public void AddAttendance(Attendance attendance)
        {
            if (attendance == null)
            {
                throw new CantBeNullException();
            }
            else if (!Attendances.Contains(attendance))
            {
                throw new DoNotContainElementException();
            }
            else
            {
                Attendances.Add(attendance);
            }
        }

        public void DeleteAttendance(Attendance attendance)
        {
            if (attendance == null)
            {
                throw new CantBeNullException();
            }

            Attendances.Remove(attendance);
        }

        public void AddAgendaItem(AgendaItem agendaItem, User currUser)
        {
            if (agendaItem == null)
            {
                throw new CantBeNullException();
            }
            else if (currUser != this.Owner && !currUser.Admin)
            {
                throw new InvalidAccessException();
            }
            else
            {
                AgendaItems.Add(agendaItem);
            }
        }

        public void AddSubmeeting(Submeeting submeeting, User currUser)
        {
            if (submeeting == null)
            {
                throw new CantBeNullException();
            }
            else if (currUser != this.Owner && !currUser.Admin)
            {
                throw new InvalidAccessException();
            }
            else
            {
                Submeetings.Add(submeeting);
            }
        }

        /*public void ChangeAttendeeRole(Attendance attendee, Attendance attendeeRole)
        {
            throw new System.NotImplementedException();
        }

        public SoundFile BeginRecordSound()
        {
            throw new System.NotImplementedException();
        }

        public SoundFile StopRecordSound()
        {
            throw new System.NotImplementedException();
        }*/
        
        public void RemoveAgendaItem(AgendaItem agendaItem, User currUser)
        {
            if (agendaItem == null)
            {
                throw new CantBeNullException();
            }
            else if (currUser != this.Owner && !currUser.Admin)
            {
                throw new InvalidAccessException();
            }
            else
            {
                AgendaItems.Remove(agendaItem);
            }
        }

        public void RemoveSubmeeting(Submeeting submeeting, User currUser)
        {
            if (submeeting == null)
            {
                throw new CantBeNullException();
            }
            else if (currUser != this.Owner && !currUser.Admin)
            {
                throw new InvalidAccessException();
            }
            else
            {
                Submeetings.Remove(submeeting);
            }
        }

        public override string ToString()
        {
            string meetingString = "";
            foreach (Submeeting submeeting in Submeetings)
            {
                //meetingString += submeeting.Project.ToString();
                meetingString += $" {submeeting.Project.Customer.Address} {submeeting.Project.Customer.Cvr} {submeeting.Project.Customer.Email} {submeeting.Project.Customer.Name} {submeeting.Project.Customer.PhoneNumber} {submeeting.Project.Description} {submeeting.Project.Location} {submeeting.Project.Title}";
            }
            foreach (Attendance attendance in Attendances)
            {
                meetingString += $"{attendance.Person.Email} {attendance.Person.Name} {attendance.Person.PhoneNumber}";
            }
            meetingString += $"{Title} {Description} {StartTime.ToString()} {EndTime.ToString()} {Owner.Email} {Owner.PhoneNumber} {Owner.Name}";
            return meetingString;
        }
    }
}