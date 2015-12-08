using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeEventTypes
    {
        public List<EventTypes> MyEventTypes;

        public FakeEventTypes()
        {
            InitializeEventTypeList();
        }

        public void InitializeEventTypeList()
        {
            MyEventTypes = new List<EventTypes> {
                FirstEventType(), 
                SecondEventType(),
                ThirdEventType(),
                FourthEventType(),
                FifthEventType()
            };
        }

        public EventTypes FirstEventType()
        {

            var firstEventType = new EventTypes
            {
                EventTypeId = 1,
                EventTypeValue = Util.EventTypes.Values.BreakFast.ToString()
            };
            return firstEventType;
        }

        public EventTypes SecondEventType()
        {
            var secondEventType = new EventTypes
            {
                EventTypeId = 2,
                EventTypeValue = Util.EventTypes.Values.Coktail.ToString()
            };
            return secondEventType;
        }

        public EventTypes ThirdEventType()
        {
            var thirdEventType = new EventTypes
            {
                EventTypeId = 3,
                EventTypeValue = Util.EventTypes.Values.Dinner.ToString()
            };
            return thirdEventType;
        }
        public EventTypes FourthEventType()
        {
            var fourthEventType = new EventTypes
            {
                EventTypeId = 3,
                EventTypeValue = Util.EventTypes.Values.Lunch.ToString()
            };
            return fourthEventType;
        }

        public EventTypes FifthEventType()
        {
            var fifthEventType = new EventTypes
            {
                EventTypeId = 3,
                EventTypeValue = Util.EventTypes.Values.Presentation.ToString()
            };
            return fifthEventType;
        }
        ~FakeEventTypes()
        {
            MyEventTypes = null;
        }
    }
}
