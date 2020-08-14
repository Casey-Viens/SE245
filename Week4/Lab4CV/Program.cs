//Casey Viens
//Lab 4~~~Creates a private class of Person which a user can use to store contact information in.
//Makes use of Gets/Sets and validation on certain variables.
using System;

namespace Lab4CV
{
    public class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string street1;
        private string street2;
        private string city;
        private string state;
        private string zip;
        private string phone;
        private string email;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                //checks the data in contact.FirstName and removes "Poopy" if it is in the string
                firstName = value.Replace("Poopy","");
            }
        }
        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Street1
        {
            get
            {
                return street1;
            }
            set
            {
                street1 = value;
            }
        }
        public string Street2
        {
            get
            {
                return street2;
            }
            set
            {
                street2 = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        public string Zip
        {
            get
            {
                return zip;
            }
            set
            {
                //Ensures the data in contact.Zip is equal to 5 digits and therefore not an areacode
                if (value.Length == 5)
                {
                    zip = value;
                }
                else
                {
                    zip = "Invalid";
                }
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                //Removes all "-" from the data in contact.Phone
                phone = value.Replace("-","");
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                //Ensures the email entered is valid based on the 2@2.2 rule
                int atLocation = value.IndexOf("@");
                int periodLocation = value.LastIndexOf(".");
                if (value.Length >= 8 && atLocation >= 2 && (periodLocation + 2) < value.Length)
                {
                    email = value;
                }
                else
                {
                    email = "Invalid";
                }
            }
        }
        public void Print()
        {
            //Prints all of the data stored in the Person class
            Console.WriteLine($"\nFirst Name: {this.FirstName}\nMiddle Name: {this.MiddleName}\nLast Name: {this.LastName}\nStreet 1: {this.Street1}\nStreet 2: {this.Street2}\nCity: {this.City}\nState: {this.State}\nZip: {this.Zip}\nPhone: {this.Phone}\nEmail: {this.Email}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creates and instance of person
            Person contact = new Person();
            //Allows the user to add data to Person
            Console.Write("Please enter the person's first name: ");
            contact.FirstName = Console.ReadLine() + "Poopy";
            Console.Write("Please enter the person's middle name: ");
            contact.MiddleName = Console.ReadLine();
            Console.Write("Please enter the person's last name: ");
            contact.LastName = Console.ReadLine();
            Console.Write("Please enter the person's street1: ");
            contact.Street1 = Console.ReadLine();
            Console.Write("Please enter the person's street2: ");
            contact.Street2 = Console.ReadLine();
            Console.Write("Please enter the person's city: ");
            contact.City = Console.ReadLine();
            Console.Write("Please enter the person's state: ");
            contact.State = Console.ReadLine();
            Console.Write("Please enter the person's zip: ");
            contact.Zip = Console.ReadLine();
            Console.Write("Please enter the person's phone: ");
            contact.Phone = Console.ReadLine();
            Console.Write("Please enter the person's email: ");
            contact.Email = Console.ReadLine();
            //calls the print function
            contact.Print();
            //Pauses the program so the user can read the data
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
