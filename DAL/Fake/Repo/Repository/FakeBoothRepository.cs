using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeBoothsRepository : FakeGenericRepository<Booths>, IBoothRepository
    {
        public FakeBoothsRepository()
            : base(new FakeBooths().MyBooths)
        {
        }

        public FakeBoothsRepository(List<Booths> myBooths)
            : base(myBooths)
        {
        }

    }
}
