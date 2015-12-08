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
                BoothIdentifier = "401",
                Location = "South Side"
            };
            return firstBooth;
        }

        public Booths SecondBooth()
        {
            var secondBooth = new Booths
            {
                BoothId = 2,
                BoothIdentifier = "119",
                Location = "North Side"
            };
            return secondBooth;
        }

        public Booths ThirdBooth()
        {
            var thirdBooth = new Booths
            {
                BoothId = 3,
                BoothIdentifier = "142",
                Location = "West Side"
            };
            return thirdBooth;
        }
        ~FakeBooths()
        {
            MyBooths = null;
        }
    }
}
