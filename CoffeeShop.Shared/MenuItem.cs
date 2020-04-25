using System;
using System.Globalization;

namespace CoffeeShopHRM.Shared
{
    public class MenuItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }

        //public string LastName { get; set; }

        //public DateTime BirthDate { get; set; }

        //public string Email { get; set; }
        //public string Street { get; set; }
        //public string Zip { get; set; }
        //public string City { get; set; }
        public int CoffeeTypeID { get; set; }
        public CoffeeTypes CoffeeType { get; set; }
        //public string PhoneNumber { get; set; }
        //public bool Smoker { get; set; }
        //public MaritalStatus MaritalStatus { get; set; }
        //public Gender Gender { get; set; }
        public string Description { get; set; }
        //public DateTime? JoinedDate { get; set; }
        //public DateTime? ExitDate { get; set; }
        
        //public int JobCategoryId { get; set; }
        //public JobCategory JobCategory { get; set; }

        public double Price {  set
            { 
                PriceValue = value.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

            }
        }
        public string PriceValue { get; private set; }
        //public double Longitude { get; set; }
    }
}
