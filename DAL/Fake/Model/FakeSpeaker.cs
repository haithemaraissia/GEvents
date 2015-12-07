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
                FirstName = "",
                LastName = "",
                Title = "",
                Company = "",
                Photo = "",
                Bio = "",
                ScheduleId = 1
            };
            return firstSpeaker;
        }

        public Speakers SecondSpeaker()
        {
            var secondSpeaker = new Speakers
            {
                SpeakerId = 1,
                FirstName = "",
                LastName = "",
                Title = "",
                Company = "",
                Photo = "",
                Bio = "",
                ScheduleId = 1
            };
            return secondSpeaker;
        }

        public Speakers ThirdSpeaker()
        {
            var thirdSpeaker = new Speakers
            {
                SpeakerId = 1,
                FirstName = "",
                LastName = "",
                Title = "",
                Company = "",
                Photo = "",
                Bio = "",
                ScheduleId = 1
            };
            return thirdSpeaker;
        }
        ~FakeSpeakers()
        {
            MySpeakers = null;
        }
    }
}
