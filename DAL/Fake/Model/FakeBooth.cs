using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeBooths
    {
        public List<Booths> MyBooths;

        public FakeBooths()
        {
            InitializeUserTypeList();
        }

        public void InitializeUserTypeList()
        {
            MyBooths = new List<Booths> {
                FirstUserType(), 
                SecondUserType(),
            };
        }

        public Booths FirstUserType()
        {

            var firstUserType = new Booths
            {
                BoothId = 1,
                BoothIdentifier = "A1",
                Location = ""
            };
            return firstUserType;
        }

        public Booths SecondUserType()
        {
            var secondUserType = new Booths
            {
                BoothId = 2,
                BoothIdentifier = "9",
                Location = ""
            };
            return secondUserType;
        }

        public Booths ThirdUserType()
        {
            var thirdUserType = new Booths
            {
                BoothId = 3,
                BoothIdentifier = "B1",
                Location = ""
            };
            return thirdUserType;
        }
        ~FakeBooths()
        {
            MyBooths = null;
        }
    }
}
