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
                AgendaTitle = ""
            };
            return firstAgenda;
        }

        public Agenda SecondAgenda()
        {
            var secondAgenda = new Agenda
            {
                AgendaId = 2,
                Description = "",
                AgendaDate = DateTime.Today.Date.AddHours(2),
                Location = "",
                Photo = "",
                AgendaTitle = ""
            };
            return secondAgenda;
        }

        public Agenda ThirdAgenda()
        {
            var thirdAgenda = new Agenda
            {
                AgendaId = 3,
                Description = "",
                AgendaDate = DateTime.Today.Date.AddHours(1).AddDays(1),
                Location = "",
                Photo = "",
                AgendaTitle = ""
            };
            return thirdAgenda;
        }
        ~FakeAgenda()
        {
            MyAgenda = null;
        }
    }
}
