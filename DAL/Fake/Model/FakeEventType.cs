using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeEventTypes
    {
        public List<EventTypes> MyEventTypes;

        public FakeEventTypes()
        {
            InitializeUserTypeList();
        }

        public void InitializeUserTypeList()
        {
            MyEventTypes = new List<EventTypes> {
                FirstUserType(), 
                SecondUserType(),
            };
        }

        public EventTypes FirstUserType()
        {

            var firstUserType = new EventTypes
            {
                EventTypeId = 1,
                EventTypeValue = ""
            };
            return firstUserType;
        }

        public EventTypes SecondUserType()
        {
            var secondUserType = new EventTypes
            {
                EventTypeId = 2,
                EventTypeValue = ""
            };
            return secondUserType;
        }

        public EventTypes ThirdUserType()
        {
            var thirdUserType = new EventTypes
            {
                EventTypeId = 3,
                EventTypeValue = ""
            };
            return thirdUserType;
        }
        ~FakeEventTypes()
        {
            MyEventTypes = null;
        }
    }
}
