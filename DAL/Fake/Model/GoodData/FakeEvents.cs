using System;
using System.Collections.Generic;
using System.Globalization;
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
            string dateString = "Tue 16 Jun 8:30 AM 2008"; // <-- Never existed!
            string format = "ddd dd MMM h:mm tt yyyy";
        //  DateTime dateTime = DateTime.ParseExact(dateString,format, CultureInfo.InvariantCulture);

            var firstEvent = new Events
            {
                EventId = 1,
                Description = "ADM Investor Services, Inc.",
                EventDate = DateTime.Today.Date,
                Location = "West Conference",
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Events\Grains.jpg",
                EventTitle = "Grains and the Global Food Demand",
                EventTypeId = (int) Util.EventTypes.Values.Presentation,
                EventStartTime = new TimeSpan(12,40,0),
                EventEndTime = new TimeSpan(13, 40, 0)
            };
            return firstEvent;
        }

        public Events SecondEvent()
        {
            var secondEvent = new Events
            {
                EventId = 2,
                Description = "Foresight Commodity Services, Inc.",
                EventDate = DateTime.Today.Date,
                Location = "Main Conference",
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Events\Market.jpg",
                EventTitle = "World Weather and the Impact on Markets",
                EventTypeId = (int)Util.EventTypes.Values.Presentation,
                EventStartTime = new TimeSpan(14, 50, 0),
                EventEndTime = new TimeSpan(16, 10, 0)
            };
            return secondEvent;
        }

        public Events ThirdEvent()
        {
            var thirdEvent = new Events
            {
                EventId = 3,
                Description = "Beeson & Associates, Inc.",
                EventDate = DateTime.Today.Date,
                Location = "Main Conference",
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Events\Oil.jpg",
                EventTitle = "Edible Oils and Shortening",
                EventTypeId = (int)Util.EventTypes.Values.Presentation,
                EventStartTime = new TimeSpan(10, 20, 0),
                EventEndTime = new TimeSpan(12, 10, 0)
            };
            return thirdEvent;
        }


        ~FakeEvents()
        {
            MyEvents = null;
        }
    }
}
