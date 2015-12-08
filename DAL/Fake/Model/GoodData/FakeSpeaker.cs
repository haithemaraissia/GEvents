using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeSpeakers
    {
        public List<Speakers> MySpeakers;

        public FakeSpeakers()
        {
            InitializeUserTypeList();
        }

        public void InitializeUserTypeList()
        {
            MySpeakers = new List<Speakers> {
                FirstSpeaker(), 
                SecondSpeaker(),
                ThirdSpeaker()
            };
        }

        public Speakers FirstSpeaker()
        {
            var firstSpeaker = new Speakers
            {
                SpeakerId = 1,
                FirstName = "Alan",
                LastName = "Douglas",
                Title = "Vice President",
                CompanyId = 2,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Speaker\Robert.jpg",
                Bio = @"Mr. Morley is principal of Global Risk Management Corporation, an independent consulting firm that provides purchasing resources, risk management strategies and training to the food and feed industries.",
                ScheduleId = 1
            };
            return firstSpeaker;
        }

        public Speakers SecondSpeaker()
        {
            var secondSpeaker = new Speakers
            {
                SpeakerId = 1,
                FirstName = "Brian",
                LastName = "Shinnig",
                Title = "President",
                CompanyId = 3,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Speaker\Jeff.jpg",
                Bio = @"Mr. Freymond is the vice-president of cocoa, North America for Barry Callebaut. In this role, he is responsible for the company’s North American cocoa business, including leadership of the sales team and financial performance of the business.",
                ScheduleId = 2
            };
            return secondSpeaker;
        }

        public Speakers ThirdSpeaker()
        {
            var thirdSpeaker = new Speakers
            {
                SpeakerId = 2,
                FirstName = "Thomas",
                LastName = "Gravin",
                Title = "Owner",
                CompanyId = 1,
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Speaker\Mike.jpg",
                Bio = @"Mr. Broad represents the third generation of his family in the egg business. In addition to sales and marketing of egg products, Bender Goodman has provided its domestic and international customers with egg market information and forecasts for more than 85 years. A graduate of Harvard College, Mr. Broad received a fellowship to the University of the Andes in Bogota, Colombia. He is a longtime resident of New York City.",
                ScheduleId = 3
            };
            return thirdSpeaker;
        }
        ~FakeSpeakers()
        {
            MySpeakers = null;
        }
    }
}
