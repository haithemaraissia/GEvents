using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeUserRepository : FakeGenericRepository<Users>, IUserRepository
    {
        public FakeUserRepository(): base(new FakeUsers().MyUsers)
        {
        }

        public FakeUserRepository(List<Users> myUsers) : base(myUsers)
        {
        }

    }
}
