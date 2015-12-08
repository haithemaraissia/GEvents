using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeSeller
    {
        public List<Sellers> MySellers;

        public FakeSeller()
        {
            InitializeSellersList();
        }

        public void InitializeSellersList()
        {
            MySellers = new List<Sellers> {
                FirstSeller(), 
                SecondSeller(),
                ThirdSeller()
            };
        }

        public Sellers FirstSeller()
        {
            var firstSeller = new Sellers
            {
                SellerId = 1,
                FirstName = "Mike",
                LastName = "Douglas",
                CompanyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Seller\Company\business-company-logo.jpg"
            };
            return firstSeller;
        }

        public Sellers SecondSeller()
        {
            var secondSeller = new Sellers
            {
                SellerId = 2,
                FirstName = "Robert",
                LastName = "Smith",
                CompanyId = 2,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Seller\Company\Company3_Logo.png"
            };
            return secondSeller;
        }

        public Sellers ThirdSeller()
        {
            var thirdSeller = new Sellers
            {
                SellerId = 3,
                FirstName = "Louna",
                LastName = "Gomez",
                CompanyId = 3,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Seller\Company\Company2_logo.jpg"
            };
            return thirdSeller;
        }
        ~FakeSeller()
        {
            MySellers = null;
        }
    }
}
