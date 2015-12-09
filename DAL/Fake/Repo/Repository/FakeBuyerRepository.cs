using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeBuyersRepository : FakeGenericRepository<Buyers>, IBuyerRepository
    {
        public FakeBuyersRepository()
            : base(new FakeBuyers().MyBuyers)
        {
        }

        public FakeBuyersRepository(List<Buyers> myBuyers)
            : base(myBuyers)
        {
        }

    }
}
