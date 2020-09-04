using Lab5_CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_CV
{
    public class PersonV2: Person
    {
        private string cellPhone;
        private string instagramURL;

        public string CellPhone
        {
            get
            {
                return cellPhone;
            }
            set
            {
                //Removes all "-" from the data in contact.CellPhone
                string tempCellPhone = value.Replace("-", "");
                //Ensures the cell phone number is the right number of characters
                if (tempCellPhone.Length == 10 && tempCellPhone.All(char.IsDigit))
                {
                    cellPhone = tempCellPhone;
                }
                else
                {
                    Feedback += "\nError: The cell phone number needs to be 10 digits.";
                }
            }
        }
        public string InstagramURL
        {
            get
            {
                return instagramURL;
            }
            set
            {
                if(value.Contains("instagram.com/") && value.Length > 14)
                {
                    instagramURL = value;
                }
                else
                {
                    Feedback += "\nError: The link does not lead to instagram.com";
                }
            }
        }
        //Constructor for the PersonV2 class using the Person Constructor as a base
        public PersonV2(): base()
        {
            cellPhone = "";
            instagramURL = "";
        }
    }
}
