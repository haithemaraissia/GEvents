using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeEventsRepository : FakeGenericRepository<Events>, IEventRepository
    {
        public FakeEventsRepository(): base(new FakeEvents().MyEvents)
        {
        }

        public FakeEventsRepository(List<Events> myEvents): base(myEvents)
        {
        }

    }
}
