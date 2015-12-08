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
                ThirdUser(),
                FourthUser(),
                FifthUser(),
                SixthUser()
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
                Photo  = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Users\Sammy.jpg"
            };
            return firstUser;
        }

        public Users SecondUser()
        {
            var secondUser = new Users
            {
                UserId = 2, 
                UserTypeId  = (int) Util.UserTypes.Values.Buyer, 
                FirstName  = "Thomas", 
                LastName  = "Jeffery", 
                CompanyId  = 1, 
                Photo  = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Users\Robert.jpg"
            };
            return secondUser;
        }

        public Users ThirdUser()
        {
            var thirdUser = new Users
            {
                UserId = 3, 
                UserTypeId  = (int) Util.UserTypes.Values.Seller, 
                FirstName  = "Robert", 
                LastName  = "Denise", 
                CompanyId  = 2, 
                Photo  = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Users\Mike.jpg"
            };
            return thirdUser;
        }

        public Users FourthUser()
        {
            var fourthUser = new Users
            {
                UserId = 4,
                UserTypeId = (int)Util.UserTypes.Values.Buyer,
                FirstName = "Lona",
                LastName = "Douglas",
                CompanyId = 3,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Users\Linda.jpg"
            };
            return fourthUser;
        }


        public Users FifthUser()
        {
            var fifthUser = new Users
            {
                UserId = 5,
                UserTypeId = (int)Util.UserTypes.Values.Speaker,
                FirstName = "Youssef",
                LastName = "Raz",
                CompanyId = 2,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Users\James.jpg"
            };
            return fifthUser;
        }
        public Users SixthUser()
        {
            var sixthUser = new Users
            {
                UserId = 6,
                UserTypeId = (int)Util.UserTypes.Values.Mediator,
                FirstName = "Maria",
                LastName = "Garcia",
                CompanyId = 3,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Users\Bob.jpg"
            };
            return sixthUser;
        }

        ~FakeUsers()
        {
            MyUsers = null;
        }
    }
}
