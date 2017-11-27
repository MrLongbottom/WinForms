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
            database.addUser(new User("password", "Børge Børgesen", "Børge@Børgesen.dk", "12345678"));
            database.addUser(new User("123", "Adminium Coolio", "admin", "Nokia"));
            database.addUser(new User("password", "Firstname Lastname", "mail@email.dk", "Telephone number"));

			//add test customers
            database.addCustomer(new Customer("Frelsen's chokolade", "Frelsen@Chokolade.dk", "Algade 27 9000 Aalborg", "+45 Brev due", "76378162783612783"));
            database.addCustomer(new Customer("Hotel Hankat", "hotel@hankat.dk", "Vestrebro 73 8000 Aarhus", "12312340", "9852478315"));
            database.addCustomer(new Customer("Firmanavn", "Firma@email.dk", "Vejnavn hus nr postnr by", "Firma telefon nr", "FIrma cvr"));

            //add test eksterns
            database.addExtern(new External("Byggeman bob", "Bob@byggeman.dk", "87654321"));
            database.addExtern(new External(database.customers.ElementAt<Customer>(1), "Mr Hankat", "Mr@Hankat", "mew mew"));
            database.addExtern(new External(database.customers.ElementAt<Customer>(2), "Firma ansat", "Fimaansats@email.dk", "Firma ansats tlfnr"));

            //add test Project
            database.addProject(new Project(database.users.First<User>(), "Hankats svimmingpool", database.customers.ElementAt<Customer>(1), database.customers.ElementAt<Customer>(1).Address, "Hotel hankat skal have en sømme pool insatllert i loftet", new List<User>(), new List<Attachment>()));
            database.addProject(new Project(database.users.First<User>(), "Hankats wellness", database.customers.ElementAt<Customer>(1), database.customers.ElementAt<Customer>(1).Address, "Hotel hankat vil have bygget en wellness område tæt på deres pool", new List<User>(), new List<Attachment>()));
            database.addProject(new Project(database.users.Last<User>(), "Project Tittle", database.customers.Last<Customer>(), database.customers.Last<Customer>().Address, "Project is about this", new List<User>(), new List<Attachment>()));
            database.addProject(new Project(database.users.First(), "Frelsensvandrør", database.customers.First(), "Algade 27 9000 Aalborg", "Fix frelsens vandrør", new List<User>(), new List<Attachment>()));

            //add test meeting
            database.addMeeting(new Meeting("Fredags møde 47", database.users.First<User>(), DateTime.Now, DateTime.Now, "Standard fredags møde", new List<Person>(), new List<Classes.CreatMeetingAgendaBuilder>()));
            database.addSubmeeting(new Submeeting(database.users.First<User>(), "Hankats svimmingpool", "Vi starter på tirsdag", database.meetings.First<Meeting>(), database.projects.First<Project>()));
            database.meetings[0].AddAttendance(new Attendance(database.meetings[0], database.users[0], false, false, false));


        }
    }
}
