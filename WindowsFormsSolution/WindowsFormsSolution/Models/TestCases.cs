using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSolution.Models
{
    class TestCases
    {
        private List<Person> allTestPerson = new List<Person>();
        private List<User> allTestUser = new List<User>();
		public TestCases(Database database)
        {

			//Add test Users
            database.addUser(new User("password", "Børge Børgesen", "Børge@Børgesen.dk", "12345678"));
            database.addUser(new User("123", "Martin Martinsen", "admin", "Nokia"));
            database.addUser(new User("password", "Jens Jensen", "mail@email.dk", "12345678"));
            database.addUser(new User("password", "Lars Larsen", "mail@email.dk", "12345678"));
            database.addUser(new User("password", "Poul Poulsen", "mail@email.dk", "12345678"));
            foreach (User user in database.users)
            {
                allTestPerson.Add(user);
                allTestUser.Add(user);
            }
            
            //add test customers
            database.addCustomer(new Customer("Frelsens", "Frelsen@mail.dk", "Algade 27 9000 Aalborg", "+45 123245678", "763781627836127"));
            database.addCustomer(new Customer("Hotel Hankat", "hotel@hankat.dk", "Vestrebro 73 8000 Aarhus", "12312340", "9852478315"));
            database.addCustomer(new Customer("Firmanavn", "Firma@email.dk", "Vejnavn hus nr postnr by", "Firma telefon nr", "Firma cvr"));
            database.addCustomer(new Customer("Tarm Svømmehal", "tarmsvøm@mail.dk", "Tarm 2880", "12345678", "12432154"));

            //add test eksterns
            database.addExtern(new External("Klaus Klausen", "Klaus@mail.dk", "87654321"));
            database.addExtern(new External(database.customers.ElementAt<Customer>(1), "Peter Petersen", "peter@mail.dk", "12345678"));
            database.addExtern(new External(database.customers.ElementAt<Customer>(2), "Firma ansat", "Fimaansat@mail.dk", "Firma ansats tlfnr"));
            foreach (External external in database.externals)
            {
                allTestPerson.Add(external);
            }
            //add test Project
            database.addProject(new Project(database.users.First<User>(), "Aalborg Pool", database.customers.ElementAt<Customer>(0), database.customers.ElementAt<Customer>(0).Address, "Problemer med vandrensningssystem.", new List<User>(), new List<Attachment>()), allTestUser);
            database.addProject(new Project(database.users.First<User>(), "Wellness center", database.customers.ElementAt<Customer>(1), database.customers.ElementAt<Customer>(1).Address, "Hotel hankat vil have bygget en wellness område tæt på deres pool", new List<User>(), new List<Attachment>()), allTestUser);
            database.addProject(new Project(database.users.Last<User>(), "Project Title", database.customers.Last<Customer>(), database.customers.Last<Customer>().Address, "Project is about this", new List<User>(), new List<Attachment>()), allTestUser);
            database.addProject(new Project(database.users.First(), "Frelsens vandrør", database.customers.First(), "Algade 27 9000 Aalborg", "Fix frelsens vandrør", new List<User>(), new List<Attachment>()), allTestUser);

            //add test meeting

            database.addMeeting(new Meeting("bestyrelsesmøde 47", database.users.First<User>(), DateTime.Now, DateTime.Now, "Standard fredags møde", new List<Person>(), new List<CreatMeetingAgendaBuilder>()), allTestPerson);
            database.addSubmeeting(new Submeeting(database.users.First<User>(), "Hankats svimmingpool", "Vi starter på tirsdag", database.meetings.First<Meeting>(), database.projects.First<Project>()));
            database.meetings[0].AddAttendance(new Attendance(database.meetings[0], database.users[0], false, false, false));

            database.addMeeting(new Meeting("Fredagsmøde 24-11-2017", database.users.First<User>(), DateTime.Now, DateTime.Now, "Standard fredags møde", new List<Person>(), new List<CreatMeetingAgendaBuilder>()), allTestPerson);
            database.meetings[1].AddAgendaItem(new AgendaItem("1. Gennemgang af igangværende projekter", database.users[0], database.meetings[1]), database.users[0]);
            database.meetings[1].AddAgendaItem(new AgendaItem("2. Inkomende Ordrer", database.users[0], database.meetings[1]), database.users[0]);
            database.meetings[1].AgendaItems[0].addSubmeeting(new Submeeting(database.users[0], "Frank Kruhoffer", "En pumpe skal udskiftes.", database.meetings[1], database.projects[3]));
            database.meetings[1].AgendaItems[0].addSubmeeting(new Submeeting(database.users[0], "OKN", "Vandrensningsanlæg mangler skruer.", database.meetings[1]));
            database.meetings[1].AgendaItems[1].addSubmeeting(new Submeeting(database.users[0], "Vanding A/S", "Projektet forsætter som planlagt.", database.meetings[1]));
            database.addSubmeeting(new Submeeting(database.users[0], "Frank Kruhoffer 2", "En pumpe skal udskiftes. 2", database.meetings[1]));

        }
    }
}
