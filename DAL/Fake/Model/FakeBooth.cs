using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeBooth
    {
        public List<Booth> MyBooth;

        public FakeBooth()
        {
            InitializeUserTypeList();
        }

        public void InitializeUserTypeList()
        {
            MyBooth = new List<Booth> {
                FirstUserType(), 
                SecondUserType(),
            };
        }

        public Booth FirstUserType()
        {

            var firstUserType = new Booth
            {
                BoothId = 1,
                BoothIdentifier = "A1",
                Location = ""
            };
            return firstUserType;
        }

        public Booth SecondUserType()
        {
            var secondUserType = new Booth
            {
                BoothId = 2,
                BoothIdentifier = "9",
                Location = ""
            };
            return secondUserType;
        }

        public Booth ThirdUserType()
        {
            var thirdUserType = new Booth
            {
                BoothId = 3,
                BoothIdentifier = "B1",
                Location = ""
            };
            return thirdUserType;
        }
        ~FakeBooth()
        {
            MyBooth = null;
        }
    }
}
