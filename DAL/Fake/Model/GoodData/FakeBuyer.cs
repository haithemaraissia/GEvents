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
                FirstName = "Tim",
                LastName = "Yang",
                CompanyId = 4,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Buyer\Company\Company_logo4.png"
            };
            return firstBuyer;
        }

        public Buyers SecondBuyer()
        {
            var secondBuyer = new Buyers
            {
                BuyerId = 2,
                FirstName = "John",
                LastName = "Smith",
                CompanyId = 5,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Buyer\Company\Company_logo5.gif"
            };
            return secondBuyer;
        }

        public Buyers ThirdBuyer()
        {
            var thirdBuyer = new Buyers
            {
                BuyerId = 3,
                FirstName = "Stephanie",
                LastName = "Lobna",
                CompanyId = 6,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Buyer\Company\Company_logo6.png"
            };
            return thirdBuyer;
        }
        ~FakeBuyers()
        {
            MyBuyers = null;
        }
    }
}
