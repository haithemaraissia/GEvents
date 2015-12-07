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
                Description = "",
                AgendaDate = DateTime.Today.Date,
                Location = "",
                Photo = "",
                AgendaTitle = "Market Fundamentals: 2:00-4:30pm"
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
                Location = "",
                Photo = "",
                AgendaTitle = "Cocktails at Union Station"
            };
            return secondAgenda;
        }

        public Agenda ThirdAgenda()
        {
            var thirdAgenda = new Agenda
            {
                AgendaId = 3,
                Description = "Paul Meyers, Chief Agricultural Economist.",
                AgendaDate = DateTime.Today.Date.AddHours(1).AddDays(1),
                Location = "",
                Photo = "",
                AgendaTitle = "Wheat and World Prospects for New Crop: 9:05 - 9:50am"
            };
            return thirdAgenda;
        }
        ~FakeAgenda()
        {
            MyAgenda = null;
        }
    }
}
