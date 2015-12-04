using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeBuyer
    {
        public List<Buyer> MyBuyer;

        public FakeBuyer()
        {
            InitializeUserTypeList();
        }

        public void InitializeUserTypeList()
        {
            MyBuyer = new List<Buyer> {
                FirstUserType(), 
                SecondUserType(),
            };
        }

        public Buyer FirstUserType()
        {

            var firstUserType = new Buyer
            {
                BuyerId = 1,
                FirstName = " ",
                LastName = "",
                CompanyId = 1,
                Photo = ""
            };
            return firstUserType;
        }

        public Buyer SecondUserType()
        {
            var secondUserType = new Buyer
            {
                TypeId = 2,
                TypeValue = Util.Buyer.Values.Buyer.ToString()
            };
            return secondUserType;
        }

        public Buyer ThirdUserType()
        {
            var thirdUserType = new Buyer
            {
                TypeId = 3,
                TypeValue = Util.Buyer.Values.Admin.ToString()
            };
            return thirdUserType;
        }
        ~FakeBuyer()
        {
            MyBuyer = null;
        }
    }
}
