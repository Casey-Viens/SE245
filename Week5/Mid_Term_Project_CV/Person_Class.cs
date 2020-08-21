using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Term_Project_CV
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
        private string feedback = "";

        public string Feedback
        {
            get
            {
                return feedback;
            }
            set
            {
                feedback = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
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
                if (value.Length == 2)
                {
                    state = value;
                }
                else
                {
                    Feedback = "Error: The State needs to be abbreviated.";
                }
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
                    Feedback = "Error: The zipcode needs to be 5 digits.";
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
                phone = value.Replace("-", "");
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
                    Feedback = "Error: The email entered does not meet the 2@2.2 format.";
                }
            }
        }
    }
}
