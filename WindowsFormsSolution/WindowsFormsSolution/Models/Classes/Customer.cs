using System.Collections.Generic;

namespace WindowsFormsSolution.Models
{
    public class Customer
    {
//public int ID { get; set; }
        public List<Project> Projects { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Cvr { get; set; }

        public Customer(string name, string email, string address, string phoneNumber, string cvr, params Project[] projects)
        {
            Name = name;
            Email = email;
            Address = address;
            PhoneNumber = phoneNumber;
            Cvr = cvr;
            foreach (Project project in projects)
            {
                Projects.Add(project);
            }
        }

        public override string ToString()
        {
            string customerString = "";
            foreach (Project project in Projects)
            {
                customerString += $" {project.ToString()}";
            }
            return $"{customerString}";
        }
    }
}