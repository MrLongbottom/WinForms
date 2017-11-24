using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSolution.Models
{
    class Search
    {
        public List<Project> ProjectSearch(List<Project> projects, string searchCriteria)
        {
            List<Project> result = null;
            foreach (Project project in projects)
            {
                if (project.ToString().Contains(searchCriteria))
                {
                    result.Add(project);
                }
            }
            return result;
        }

        public List<Customer> CustomerSearch(List<Customer> customers, string searchCriteria)
        {
            List<Customer> result = null;
            foreach (Customer customer in customers)
            {
                if (customer.ToString().Contains(searchCriteria))
                {
                    result.Add(customer);
                }
            }
            return result;
        }

        public List<Meeting> MeetingSearch(List<Meeting> meetings, string searchCriteria)
        {
            List<Meeting> result = null;
            foreach (Meeting meeting in meetings)
            {
                if (meeting.ToString().Contains(searchCriteria))
                {
                    result.Add(meeting);
                }
            }
            return result;
        }
    }
}
