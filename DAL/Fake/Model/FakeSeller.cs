using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeUserTypes
    {
        public List<UserTypes> MyUserTypes;

        public FakeUserTypes()
        {
            InitializeUserTypeList();
        }

        public void InitializeUserTypeList()
        {
            MyUserTypes = new List<UserTypes> {
                FirstUserType(), 
                SecondUserType(),
            };
        }

        public UserTypes FirstUserType()
        {

            var firstUserType = new UserTypes
            {
                TypeId = 1,
                TypeValue = Util.UserTypes.Values.Seller.ToString()
            };
            return firstUserType;
        }

        public UserTypes SecondUserType()
        {
            var secondUserType = new UserTypes
            {
                TypeId = 2,
                TypeValue = Util.UserTypes.Values.Buyer.ToString()
            };
            return secondUserType;
        }

        public UserTypes ThirdUserType()
        {
            var thirdUserType = new UserTypes
            {
                TypeId = 3,
                TypeValue = Util.UserTypes.Values.Admin.ToString()
            };
            return thirdUserType;
        }
        ~FakeUserTypes()
        {
            MyUserTypes = null;
        }
    }
}
