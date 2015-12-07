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
                ThirdEventType()
            };
        }

        public EventTypes FirstEventType()
        {

            var firstEventType = new EventTypes
            {
                EventTypeId = 1,
                EventTypeValue = ""
            };
            return firstEventType;
        }

        public EventTypes SecondEventType()
        {
            var secondEventType = new EventTypes
            {
                EventTypeId = 2,
                EventTypeValue = ""
            };
            return secondEventType;
        }

        public EventTypes ThirdEventType()
        {
            var thirdEventType = new EventTypes
            {
                EventTypeId = 3,
                EventTypeValue = ""
            };
            return thirdEventType;
        }
        ~FakeEventTypes()
        {
            MyEventTypes = null;
        }
    }
}
