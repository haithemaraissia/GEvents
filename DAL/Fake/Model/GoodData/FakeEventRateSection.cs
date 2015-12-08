using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeEventRateSection
    {
        public List<EventRateSection> MyEventRateSection;

        public FakeEventRateSection()
        {
            InitializeSellersList();
        }

        public void InitializeSellersList()
        {
            MyEventRateSection = new List<EventRateSection> {
                FirstEventRateSection(), 
                SecondEventRateSection(),
                ThirdEventRateSection()
            };
        }

        public EventRateSection FirstEventRateSection()
        {
            var firstEventRateSection = new EventRateSection
            {
                SectionId = (int)Util.EventRateSection.Values.Events,
                SectionValue = Util.EventRateSection.Values.Events.ToString()
            };
            return firstEventRateSection;
        }

        public EventRateSection SecondEventRateSection()
        {
            var secondEventRateSection = new EventRateSection
            {
                SectionId = (int)Util.EventRateSection.Values.Organization,
                SectionValue = Util.EventRateSection.Values.Organization.ToString()
            };
            return secondEventRateSection;
        }

        public EventRateSection ThirdEventRateSection()
        {
            var thirdEventRateSection = new EventRateSection
            {
                SectionId = (int) Util.EventRateSection.Values.Staff,
                SectionValue = Util.EventRateSection.Values.Staff.ToString()
            };
            return thirdEventRateSection;
        }
        ~FakeEventRateSection()
        {
            MyEventRateSection = null;
        }
    }
}
