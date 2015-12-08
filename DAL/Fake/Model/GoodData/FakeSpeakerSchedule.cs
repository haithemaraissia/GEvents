using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeSpeakerSchedules
    {
        public List<SpeakerSchedules> MySpeakerSchedules;

        public FakeSpeakerSchedules()
        {
            InitializeSpeakerScheduleList();
        }

        public void InitializeSpeakerScheduleList()
        {
            MySpeakerSchedules = new List<SpeakerSchedules> {
                FirstSpeakerSchedule(), 
                SecondSpeakerSchedule(),
                ThirdSpeakerSchedule()

            };
        }

        public SpeakerSchedules FirstSpeakerSchedule()
        {
            var firstSpeakerSchedule = new SpeakerSchedules
            {
                ScheduleId = 1,
                EventId = 1
            };
            return firstSpeakerSchedule;
        }

        public SpeakerSchedules SecondSpeakerSchedule()
        {
            var secondSpeakerSchedule = new SpeakerSchedules
            {
                ScheduleId = 2,
                EventId = 2
            };
            return secondSpeakerSchedule;
        }

        public SpeakerSchedules ThirdSpeakerSchedule()
        {
            var thirdSpeakerSchedule = new SpeakerSchedules
            {
                ScheduleId = 3,
                EventId = 2
            };
            return thirdSpeakerSchedule;
        }
        ~FakeSpeakerSchedules()
        {
            MySpeakerSchedules = null;
        }
    }
}
