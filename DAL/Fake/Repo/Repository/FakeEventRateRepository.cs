using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeEventRatesRepository : FakeGenericRepository<EventRateSection>, IEventRateSectionRepository
    {
        public FakeEventRatesRepository()
            : base(new FakeEventRateSection().MyEventRateSection)
        {
        }

        public FakeEventRatesRepository(List<EventRateSection> myEventRates)
            : base(myEventRates)
        {
        }

    }
}
