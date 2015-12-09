using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using DAL.Fake.Model.GoodData;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeUserTypeRepository : FakeGenericRepository<UserTypes>, IUserTypeRepository
    {
        public FakeUserTypeRepository(): base(new FakeUserTypes().MyUserTypes)
        {
        }

        public FakeUserTypeRepository(List<UserTypes> myUsers)
            : base(myUsers)
        {
        }

    }
}
