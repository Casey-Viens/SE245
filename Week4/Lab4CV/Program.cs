using System;

namespace Lab4CV
{
    public class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string street1;
        public string street2;
        public string city;
        public string state;
        public string zip;
        public string phone;
        public string email;

        public void Print()
        {
            Console.WriteLine($"\nFirst Name: {this.firstName}\nMiddle Name: {this.middleName}\nLast Name: {this.lastName}\nStreet 1: {this.street1}\nStreet 2: {this.street2}\nCity: {this.city}\nState: {this.state}\nZip: {this.zip}\nPhone: {this.phone}\nEmail: {this.email}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person contact = new Person();
            
            Console.Write("Please enter the person's first name: ");
            contact.firstName = Console.ReadLine() + "Poopy";
            Console.Write("Please enter the person's middle name: ");
            contact.middleName = Console.ReadLine();
            Console.Write("Please enter the person's last name: ");
            contact.lastName = Console.ReadLine();
            Console.Write("Please enter the person's street1: ");
            contact.street1 = Console.ReadLine();
            Console.Write("Please enter the person's street2: ");
            contact.street2 = Console.ReadLine();
            Console.Write("Please enter the person's city: ");
            contact.city = Console.ReadLine();
            Console.Write("Please enter the person's state: ");
            contact.state = Console.ReadLine();
            Console.Write("Please enter the person's zip: ");
            contact.zip = Console.ReadLine();
            Console.Write("Please enter the person's phone: ");
            contact.phone = Console.ReadLine();
            Console.Write("Please enter the person's email: ");
            contact.email = Console.ReadLine();

            contact.Print();
        }
    }
}
