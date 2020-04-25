using CoffeeShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWebsite.Pages
{
    public class MenuOverviewBase : ComponentBase
    {
        //[Parameter]
        //public string ItemId { get; set; }
        //public MenuItem MenuItem { get; set; } = new  MenuItem();

        protected override Task OnInitializedAsync()
        {

            //InitializeCountries();
            InitializeCoffeeType();
            InitializeMenuItems();

            //MenuItem = MenuItems.FirstOrDefault(e => e.ItemId == int.Parse(ItemId));


            return base.OnInitializedAsync();
        }

        #region Mock Data
        public IEnumerable<MenuItem> MenuItems { get; set; }

        //private List<Country> Countries { get; set; }

        private List<CoffeeTypes> CoffeeType { get; set; }

        private void InitializeCoffeeType()
        {
            CoffeeType = new List<CoffeeTypes>()
            {
                new CoffeeTypes{ TypeId = 1,  TypeName = "Cafe Latte"},
                new CoffeeTypes{ TypeId = 2,  TypeName = "Cappuccino"},
                new CoffeeTypes{ TypeId = 3,  TypeName = "Machiato"},
                new CoffeeTypes{ TypeId = 4,  TypeName = "Store staff"},
                new CoffeeTypes{ TypeId = 5,  TypeName = "Finance"},
                new CoffeeTypes{ TypeId = 6,  TypeName = "QA"},

            };
        }

        //private void InitializeCountries()
        //{
        //    Countries = new List<Country>
        //    {
        //        new Country {CountryId = 1, Name = "Belgium"},
        //        new Country {CountryId = 2, Name = "Netherlands"},
        //        new Country {CountryId = 3, Name = "USA"},
        //        new Country {CountryId = 4, Name = "Japan"},
        //        new Country {CountryId = 5, Name = "China"},
        //        new Country {CountryId = 6, Name = "UK"},
        //        new Country {CountryId = 7, Name = "France"},
        //        new Country {CountryId = 8, Name = "Brazil"}
        //    };
        //}

        private void InitializeMenuItems()
        {
            var e1 = new MenuItem
            {
                CoffeeTypeID = 1,
                //MaritalStatus = MaritalStatus.Single,
                //BirthDate = new DateTime(1989, 3, 11),
                //City = "Brussels",
                //Email = "bethany@bethanyspieshop.com",
                ItemId = 1,
                ItemName = "Arusha",
                //LastName = "Smith",
                //Gender = Gender.Female,
                //PhoneNumber = "324777888773",
                //Smoker = false,
                //Street = "Grote Markt 1",
                //Zip = "1000",
                //JobCategoryId = 1,
                Description = "Organic plunger pot acerbic espresso skinny spoon arabica barista trifecta. Dripper, dark seasonal macchiato mug, seasonal aged arabica caffeine aftertaste coffee. Qui, bar, id decaffeinated strong eu java to go.",
                Price = 32,
                //ExitDate = null,
                //JoinedDate = new DateTime(2015, 3, 1)
            };

            var e2 = new MenuItem
            {
                CoffeeTypeID = 2,
                //MaritalStatus = MaritalStatus.Married,
                //BirthDate = new DateTime(1979, 1, 16),
                //City = "Antwerp",
                //Email = "gill@bethanyspieshop.com",
                ItemId = 2,
                ItemName = "Catimor",
                //LastName = "Cleeren",
                //Gender = Gender.Female,
                //PhoneNumber = "33999909923",
                //Smoker = false,
                //Street = "New Street",
                //Zip = "2000",
                //JobCategoryId = 1,
                Description = "Plunger pot crema ut mazagran, body redeye dark aromatic arabica breve. Barista java crema ristretto strong half and half sugar",
                Price = 10,
                //ExitDate = null,
                //JoinedDate = new DateTime(2017, 12, 24)
            };
            MenuItems = new List<MenuItem> { e1, e2 };
        } 
        #endregion
    }
}
