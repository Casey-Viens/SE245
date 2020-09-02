using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_CV
{
    public class Customer: PersonV2
    {
        private DateTime customerSince;
        private Double totalPurchases;
        private bool discountMember;
        private int rewardsEarned;

        public DateTime CustomerSince
        {
            get
            {
                return customerSince;
            }
            set
            {
                //Ensures the date is in the past, or the current date
                if(value > DateTime.Now)
                {
                    Feedback += "\nError: Date cannot be in the future.";
                }
                else
                {
                    customerSince = value;
                }
            }
        }
        public Double TotalPurchases
        {
            get
            {
                return totalPurchases;
            }
            set
            {
                //Ensures there are purchases
                if(value >= 0)
                {
                    totalPurchases = value;
                }
                else
                {
                    Feedback += "\nError: The data for total purchases needs to be a positive number";
                }
            }
        }
        public bool DiscountMember
        {
            get
            {
                return discountMember;
            }
            set
            {
                discountMember = value;
            }
        }
        public int RewardsEarned
        {
            get
            {
                return rewardsEarned;
            }
            set
            {
                //Ensures there are rewards
                if (value >= 0)
                {
                    rewardsEarned = value;
                }
                else
                {
                    Feedback += "\nError: The data for rewardsEarned needs to be a positive number";
                }
            }
        }

        public Customer(): base()
        {
            customerSince = DateTime.Now;
            totalPurchases = 0.0;
            discountMember = false;
            rewardsEarned = 0;
        }
    }
}
