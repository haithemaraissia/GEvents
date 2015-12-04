using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeBuyers
    {
        public List<Buyers> MyBuyers;

        public FakeBuyers()
        {
            InitializeUserTypeList();
        }

        public void InitializeUserTypeList()
        {
            MyBuyers = new List<Buyers> {
                FirstUserType(), 
                SecondUserType(),
            };
        }

        public Buyers FirstUserType()
        {

            var firstUserType = new Buyers
            {
                BuyerId = 1,
                FirstName = " ",
                LastName = "",
                CompanyId = 1,
                Photo = ""
            };
            return firstUserType;
        }

        public Buyers SecondUserType()
        {
            var secondUserType = new Buyers
            {
                BuyerId = 2,
                FirstName = " ",
                LastName = "",
                CompanyId = 1,
                Photo = ""
            };
            return secondUserType;
        }

        public Buyers ThirdUserType()
        {
            var thirdUserType = new Buyers
            {
                BuyerId = 3,
                FirstName = " ",
                LastName = "",
                CompanyId = 1,
                Photo = ""
            };
            return thirdUserType;
        }
        ~FakeBuyers()
        {
            MyBuyers = null;
        }
    }
}
