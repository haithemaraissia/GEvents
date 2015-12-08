using System;
using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeAgenda
    {
        public List<Agenda> MyAgenda;

        public FakeAgenda()
        {
            InitializeAgendaList();
        }

        public void InitializeAgendaList()
        {
            MyAgenda = new List<Agenda> {
                FirstAgenda(), 
                SecondAgenda(),
                ThirdAgenda()
            };
        }

        public Agenda FirstAgenda()
        {

            var firstAgenda = new Agenda
            {
                AgendaId = 1,
                Description = "Beeson & Associates, Inc.",
                AgendaDate = DateTime.Today.Date,
                Location = "1 Floor, Room 215",
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Agenda\Market.jpg",
                EventTypeId = (int)Util.EventTypes.Values.Debate,
                AgendaTitle = "Market Fundamentals: 2:00-4:30pm",
                AgendaStartTime = new TimeSpan(14, 50, 0),
                AgendaEndTime = new TimeSpan(16, 10, 0)
            };
            return firstAgenda;
        }

        public Agenda SecondAgenda()
        {
            var secondAgenda = new Agenda
            {
                AgendaId = 2,
                Description = "The opening event for each Purchasing Seminar, this year's Sunday evening cocktail party will be hosted at Sprint Festival Plaza in Union Station.",
                AgendaDate = DateTime.Today.Date.AddHours(2),
                Location = "Lobby Main Entrance",
                Photo = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\GEvents\trunk\Test\Images\Agenda\Coktail.jpg",
                AgendaTitle = "Cocktails at Union Station",
                EventTypeId = (int)Util.EventTypes.Values.Presentation,
                AgendaStartTime = new TimeSpan(14, 50, 0),
                AgendaEndTime = new TimeSpan(16, 10, 0)
            };
            return secondAgenda;
        }

        public Agenda ThirdAgenda()
        {
            var thirdAgenda = new Agenda
            {
                AgendaId = 3,
                Description = "Breakfast",
                AgendaDate = DateTime.Today.Date.AddHours(1).AddDays(1),
                Location = "Second Floor",
                Photo = "",
                EventTypeId = (int)Util.EventTypes.Values.Break,
                AgendaTitle = "Wheat and World Prospects for New Crop:",
                AgendaStartTime = new TimeSpan(9, 05, 0),
                AgendaEndTime = new TimeSpan(9, 50, 0)
            };
            return thirdAgenda;
        }
        ~FakeAgenda()
        {
            MyAgenda = null;
        }
    }
}
