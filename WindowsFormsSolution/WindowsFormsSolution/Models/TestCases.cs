using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSolution.Models
{
    class TestCases
    {
		public TestCases(Database database)
        {

			//Add test Users
            database.addUser(new User("password", "Børge Børgesen", "Børge@Børgesen.dk", "+45 12 34 56 78"));
            database.addUser(new User("123", "admin user name", "admin", "+45 12 34 56 78"));
            database.addUser(new User("password", "Firstname Lastname", "mail@email.dk", "+45 12 34 56 78"));
            database.addUser(new User("anden", "Anders Hansen", "anders@hansen.dk", "+45 12 34 56 78"));
            database.users[1].Admin = true;

			//add test customers
            database.addCustomer(new Customer("Frelsen's chokolade", "Frelsen@Chokolade.dk", "Algade 27, 9000 Aalborg", "+45 12 34 56 78", "76378162783612783"));
            database.addCustomer(new Customer("Hotel Trivago", "hotel@trivago.dk", "Vestrebro 73, 8000 Aarhus", "+45 12 34 56 78", "9852478315"));
            database.addCustomer(new Customer("Firmanavn", "Firma@email.dk", "Vejnavn hus nr., post nr. by", "+45 12 34 56 78", "21543264343"));

            //add test eksterns
            database.addExtern(new External("Anders Andersen", "mail@mail.dk", "+45 12 34 56 78"));
            database.addExtern(new External(database.customers.ElementAt<Customer>(1), "Jens Hansen", "mail@mail.dk", "+45 12 34 56 78"));
            database.addExtern(new External(database.customers.ElementAt<Customer>(2), "Troels Islev", "mail@mail.dk", "+45 12 34 56 78"));

            //add test Project
            database.addProject(new Project(database.GetUserByEmail("admin"), "Trivargo svimmingpool", database.customers.ElementAt<Customer>(1), database.customers.ElementAt<Customer>(1).Address, "Hotel hankat skal have en sømme pool insatllert i loftet", new List<User>(), new List<Attachment>()));
            database.addProject(new Project(database.GetUserByEmail("admin"), "Wellness center", database.customers.ElementAt<Customer>(1), database.customers.ElementAt<Customer>(1).Address, "Hotel hankat vil have bygget en wellness område tæt på deres pool", new List<User>(), new List<Attachment>()));
            database.addProject(new Project(database.users.Last<User>(), "Project Title", database.customers.Last<Customer>(), database.customers.Last<Customer>().Address, "Project is about this", new List<User>(), new List<Attachment>()));
            database.addProject(new Project(database.users.First(), "Frelsens vandrør", database.customers.First(), "Algade 27 9000 Aalborg", "Fix frelsens vandrør", new List<User>(), new List<Attachment>()));

            //add test meeting
            database.addMeeting(new Meeting("Test Møde", database.users.First<User>(), DateTime.Now, DateTime.Now, "Dette er en beskrivelse til et møde"));
            database.addMeeting(new Meeting("Fredags Møde 28/11", database.GetUserByEmail("admin"), DateTime.Now, DateTime.Now, "Fredagsmødet finder sted for alle fjorblinks ansatte d. 27/11/2017."));

            //add test agenda items
            database.meetings[0].AddAgendaItem(new AgendaItem("Første Dagsordenspunkt", "lots of stuff"), database.GetUserByEmail("admin"));
            database.meetings[0].AddAgendaItem(new AgendaItem("Andet Dagsordenspunkt", "lots of stuff"), database.GetUserByEmail("admin"));
            database.meetings[0].AddAgendaItem(new AgendaItem("Tredje Dagsordenspunkt", "lots of stuff"), database.GetUserByEmail("admin"));
            database.meetings[1].AddAgendaItem(new AgendaItem("Gennemgang af igangværende projekter", "lots of stuff"), database.GetUserByEmail("admin"));
            database.meetings[1].AddAgendaItem(new AgendaItem("Inkomne / forventede ordre", "lots of stuff"), database.GetUserByEmail("admin"));

            //add test submeetings
            database.addSubmeeting(new Submeeting(database.GetUserByEmail("admin"), "Trivago svimmingpool", "Vi starter på tirsdag", database.meetings[1], database.projects[0]));
            database.addSubmeeting(new Submeeting(database.GetUserByEmail("admin"), "Welness center", "Aftaler kører efter planen og fortsætter til uge 4.", database.meetings[1], database.projects[1]));
            database.addSubmeeting(new Submeeting(database.GetUserByEmail("admin"), "Trivago minipool", "Mangler betaling", database.meetings[1], database.projects[1]));
            database.addSubmeeting(new Submeeting(database.GetUserByEmail("admin"), "Trivago vandrenser", "Forsætter som planlagt.", database.meetings[1], database.projects[1]));

            database.meetings[1].AgendaItems[0].addSubmeeting(database.submeetings[0]);
            database.meetings[1].AgendaItems[0].addSubmeeting(database.submeetings[1]);
            database.meetings[1].AgendaItems[1].addSubmeeting(database.submeetings[2]);
            database.meetings[1].AgendaItems[1].addSubmeeting(database.submeetings[3]);
            database.meetings[0].AgendaItems[0].addSubmeeting(database.submeetings[0]);
            database.meetings[0].AgendaItems[0].addSubmeeting(database.submeetings[1]);
            database.meetings[0].AgendaItems[1].addSubmeeting(database.submeetings[2]);
            database.meetings[0].AgendaItems[1].addSubmeeting(database.submeetings[3]);

            //add test attendances
            database.meetings[0].AddAttendance(new Attendance(database.meetings[0], database.users[0], false, false, false));
            database.meetings[0].AddAttendance(new Attendance(database.meetings[0], database.users[1], false, false, false));
            database.meetings[0].AddAttendance(new Attendance(database.meetings[0], database.users[2], false, false, false));
            database.meetings[1].AddAttendance(new Attendance(database.meetings[1], database.users[0], false, false, false));
            database.meetings[1].AddAttendance(new Attendance(database.meetings[1], database.users[1], false, false, false));
            database.meetings[1].AddAttendance(new Attendance(database.meetings[1], database.users[2], false, false, false));
        }
    }
}
