using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeBuyers
    {
        public List<Buyers> MyBuyers;

        public FakeBuyers()
        {
            InitializeBuyerList();
        }

        public void InitializeBuyerList()
        {
            MyBuyers = new List<Buyers> {
                FirstBuyer(), 
                SecondBuyer(),
                ThirdBuyer()
            };
        }

        public Buyers FirstBuyer()
        {

            var firstBuyer = new Buyers
            {
                BuyerId = 1,
                FirstName = " ",
                LastName = "",
                CompanyId = 1,
                Photo = ""
            };
            return firstBuyer;
        }

        public Buyers SecondBuyer()
        {
            var secondBuyer = new Buyers
            {
                BuyerId = 2,
                FirstName = " ",
                LastName = "",
                CompanyId = 1,
                Photo = ""
            };
            return secondBuyer;
        }

        public Buyers ThirdBuyer()
        {
            var thirdBuyer = new Buyers
            {
                BuyerId = 3,
                FirstName = " ",
                LastName = "",
                CompanyId = 1,
                Photo = ""
            };
            return thirdBuyer;
        }
        ~FakeBuyers()
        {
            MyBuyers = null;
        }
    }
}
