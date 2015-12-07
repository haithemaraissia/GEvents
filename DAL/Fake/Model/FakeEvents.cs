using System;
using System.Collections.Generic;
using DAL.Fake.Model.Util;
using Model;

namespace DAL.Fake.Model
{
    public class FakeEvents
    {
        public List<Events> MyEvents;

        public FakeEvents()
        {
            InitializeEventList();
        }

        public void InitializeEventList()
        {
            MyEvents = new List<Events> {
                FirstEvent(), 
                SecondEvent(),
                ThirdEvent()
            };
        }

        public Events FirstEvent()
        {
            var firstEvent = new Events
            {
                EventId = 1,
                Description = "",
                EventDate = DateTime.Today.Date,
                Location = "",
                Photo = "",
                EventTitle = "",
                EventTypeId = 1
            };
            return firstEvent;
        }

        public Events SecondEvent()
        {
            var secondEvent = new Events
            {
                EventId = 1,
                Description = "",
                EventDate = DateTime.Today.Date,
                Location = "",
                Photo = "",
                EventTitle = "",
                EventTypeId = 1
            };
            return secondEvent;
        }

        public Events ThirdEvent()
        {
            var thirdEvent = new Events
            {
                EventId = 1,
                Description = "",
                EventDate = DateTime.Today.Date,
                Location = "",
                Photo = "",
                EventTitle = "",
                EventTypeId = 1
            };
            return thirdEvent;
        }


        ~FakeEvents()
        {
            MyEvents = null;
        }
    }
}
