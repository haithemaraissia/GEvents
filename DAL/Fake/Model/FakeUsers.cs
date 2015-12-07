using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeUsers
    {
        public List<Users> MyUsers;

        public FakeUsers()
        {
            InitializeUsersList();
        }

        public void InitializeUsersList()
        {
            MyUsers = new List<Users> {
                FirstUser(), 
                SecondUser(),
                ThirdUser()
            };
        }

        public Users FirstUser()
        {

            var firstUser = new Users
            {
                UserId = 1, 
                UserTypeId  = (int) Util.UserTypes.Values.Seller, 
                FirstName  = "Mike", 
                LastName  = "Smith", 
                CompanyId  = 1, 
                Photo  = ""
            };
            return firstUser;
        }

        public Users SecondUser()
        {
            var secondUser = new Users
            {
                UserId = 1, 
                UserTypeId  = (int) Util.UserTypes.Values.Seller, 
                FirstName  = "Mike", 
                LastName  = "Smith", 
                CompanyId  = 1, 
                Photo  = ""
            };
            return secondUser;
        }

        public Users ThirdUser()
        {
            var thirdUser = new Users
            {
                UserId = 1, 
                UserTypeId  = (int) Util.UserTypes.Values.Seller, 
                FirstName  = "Mike", 
                LastName  = "Smith", 
                CompanyId  = 1, 
                Photo  = ""
            };
            return thirdUser;
        }
        ~FakeUsers()
        {
            MyUsers = null;
        }
    }
}
