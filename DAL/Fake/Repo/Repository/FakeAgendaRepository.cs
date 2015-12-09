using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeAgendasRepository : FakeGenericRepository<Agenda>, IAgendaRepository
    {
        public FakeAgendasRepository()
            : base(new FakeAgenda().MyAgenda)
        {
        }

        public FakeAgendasRepository(List<Agenda> myAgendas)
            : base(myAgendas)
        {
        }

    }
}
