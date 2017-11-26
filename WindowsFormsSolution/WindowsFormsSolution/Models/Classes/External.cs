

namespace WindowsFormsSolution.Models
{
    public class External : Person
    {
        public Customer Customer { get; set; }

        public External(string _Name, string _Email, string _PhoneNumber) : base (_Name, _Email, _PhoneNumber)
        {

        } 
        public External(Customer _Customer, string _Name, string _Email, string _PhoneNumber) : base(_Name, _Email, _PhoneNumber)
        {
            Customer = _Customer;
        }
    }
}