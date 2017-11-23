using System.Collections.Generic;
using System;

namespace WinFromsSolution.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public List<Attendance> Attendances { get; set; }
        public List<Submeeting> Submeetings { get; set; }
        public List<AgendaItem> AgendaItems { get; set; }
        public List<Attachment> Attachments { get; set; }

        /*public Meeting(int id, string title, User user, DateTime startTime, TimeSpan duration, string description, List<int> attendances)
        {
            ID = id;
            Title = title;
            Owner = user;
            StartTime = startTime;
            Description = description;
        }

        public void ChangeDescription(string description)
        {
            if (CurrentUser.ID != Owner && !CurrentUser.Attendance.Admin)
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
            else if (!Attendances.Contains(attendance.ID))
            {
                throw new DoNotContainElementException();
            }
            else
            {
                Attendances.Add(attendance.ID);
            }
        }

        public void DeleteAttendance(Attendance attendance)
        {
            if (attendance == null)
            {
                throw new CantBeNullException();
            }

            Attendances.Remove(attendance.ID);
        }

        public void AddAgendaItem(AgendaItem agendaItem)
        {
            if (agendaItem == null)
            {
                throw new CantBeNullException();
            }
            else if (CurrentUser.ID != this.Owner && !CurrentUser.Attendance.Admin)
            {
                throw new InvalidAccessException();
            }
            else
            {
                AgendaItems.Add(agendaItem.ID);
            }
        }

        public void AddSubmeeting(Submeeting submeeting)
        {
            if (submeeting == null)
            {
                throw new CantBeNullException();
            }
            else if (CurrentUser.ID != this.Owner && !CurrentUser.Attendance.Admin)
            {
                throw new InvalidAccessException();
            }
            else
            {
                Submeetings.Add(submeeting.ID);
            }
        }

        public void ChangeAttendeeRole(Attendance attendee, Attendance.AttendanceRole attendeeRole)
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
        }
        
        public void RemoveAgendaItem(AgendaItem agendaItem)
        {
            if (agendaItem == null)
            {
                throw new CantBeNullException();
            }
            else if (CurrentUser.ID != this.Owner && !CurrentUser.Attendance.Admin)
            {
                throw new InvalidAccessException();
            }
            else
            {
                AgendaItems.Remove(agendaItem.ID);
            }
        }

        public void RemoveSubmeeting(Submeeting submeeting)
        {
            if (submeeting == null)
            {
                throw new CantBeNullException();
            }
            else if (CurrentUser.ID != this.Owner && !CurrentUser.Attendance.Admin)
            {
                throw new InvalidAccessException();
            }
            else
            {
                Submeetings.Remove(submeeting.ID);
            }
        }*/
    }
}