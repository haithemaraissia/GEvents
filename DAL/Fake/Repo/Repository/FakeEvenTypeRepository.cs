using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeEventTypesRepository : FakeGenericRepository<EventTypes>, IEventTypeRepository
    {
        public FakeEventTypesRepository()
            : base(new FakeEventTypes().MyEventTypes)
        {
        }

        public FakeEventTypesRepository(List<EventTypes> myEventTypes)
            : base(myEventTypes)
        {
        }

    }
}
