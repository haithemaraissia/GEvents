using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeBooths
    {
        public List<Booths> MyBooths;

        public FakeBooths()
        {
            InitializeBoothList();
        }

        public void InitializeBoothList()
        {
            MyBooths = new List<Booths> {
                FirstBooth(), 
                SecondBooth(),
                ThirdBooth()
            };
        }

        public Booths FirstBooth()
        {

            var firstBooth = new Booths
            {
                BoothId = 1,
                BoothIdentifier = "A1",
                Location = ""
            };
            return firstBooth;
        }

        public Booths SecondBooth()
        {
            var secondBooth = new Booths
            {
                BoothId = 2,
                BoothIdentifier = "9",
                Location = ""
            };
            return secondBooth;
        }

        public Booths ThirdBooth()
        {
            var thirdBooth = new Booths
            {
                BoothId = 3,
                BoothIdentifier = "B1",
                Location = ""
            };
            return thirdBooth;
        }
        ~FakeBooths()
        {
            MyBooths = null;
        }
    }
}
