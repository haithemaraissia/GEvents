using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeSellersRepository : FakeGenericRepository<Sellers>, ISellerRepository
    {
        public FakeSellersRepository()
            : base(new FakeSeller().MySellers)
        {
        }

        public FakeSellersRepository(List<Sellers> mySellers)
            : base(mySellers)
        {
        }

    }
}
