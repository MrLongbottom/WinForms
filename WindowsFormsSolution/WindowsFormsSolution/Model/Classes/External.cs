

namespace WinFromsSolution.Models
{
    public class External : Person
    {
        public Customer Customer { get; set; }

        /*External(int _ID, string _Name, string _Email, string _PhoneNumber) : base (_ID, _Name, _Email, _PhoneNumber)
        {

        } 
        External(Customer _Customer, int _ID, string _Name, string _Email, string _PhoneNumber) : base(_ID, _Name, _Email, _PhoneNumber)
        {
            Customer = _Customer;
        }*/
    }
}