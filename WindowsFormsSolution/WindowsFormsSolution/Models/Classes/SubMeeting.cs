using System.Collections.Generic;
namespace WindowsFormsSolution.Models
{
    public class Submeeting
    {
        //public int ID { get; set; }
        public string Title { get; set; }
        //public string Description { get; set; }
        public string Referat { get; private set; }
//        public int ProjectID { get; set; }
  //      public int MeetingID { get; set; }
        public Meeting Meeting { get; set; }
        public Project Project { get; set; }
        public List<Attachment> Attachments { get; set; }

        public Submeeting(User currUser, string title, Meeting meeting)
        {
            Title = title;           
            Meeting = meeting;
            Meeting.AddSubmeeting(this, currUser);
        }

        public Submeeting(User currUser, string title, Meeting meeting, Project project)
        {
            Title = title;
            Meeting = meeting;
            Meeting.AddSubmeeting(this, currUser);
            Project = project;
            Project.addSubmeeting(this);
        }

        public Submeeting(User currUser, string title, string referat, Meeting meeting)
        {
            Title = title;
            Referat = referat;
            Meeting = meeting;
            Meeting.AddSubmeeting(this, currUser);
        }

        public Submeeting(User currUser, string title, string referat, Meeting meeting, Project project)
        {
            Title = title;
            Referat = referat;
            Meeting = meeting;
            Meeting.AddSubmeeting(this, currUser);
            Project = project;
            Project.addSubmeeting(this);
        }
        
        public void addProject(Project project)
        {
            Project = project;
            if (!Project.Submeetings.Contains(this))
            {
                Project.addSubmeeting(this);
            }
        }
        /*        public override string ToString()
                {

                    return $"{Title} {Description} {Meeting.Description} {Meeting.EndTime.ToString()} {Meeting.Title} {Meeting.StartTime.ToString()} ";
                }*/
    }
}