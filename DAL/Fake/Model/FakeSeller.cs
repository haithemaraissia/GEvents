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
                FirstName = "",
                LastName = "",
                CompanyId = 1,
                Photo = ""
            };
            return firstSeller;
        }

        public Sellers SecondSeller()
        {
            var secondSeller = new Sellers
            {
                SellerId = 1,
                FirstName = "",
                LastName = "",
                CompanyId = 1,
                Photo = ""
            };
            return secondSeller;
        }

        public Sellers ThirdSeller()
        {
            var thirdSeller = new Sellers
            {
                SellerId = 1,
                FirstName = "",
                LastName = "",
                CompanyId = 1,
                Photo = ""
            };
            return thirdSeller;
        }
        ~FakeSeller()
        {
            MySellers = null;
        }
    }
}
