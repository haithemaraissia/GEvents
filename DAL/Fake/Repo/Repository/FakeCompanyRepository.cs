using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeCompanysRepository : FakeGenericRepository<Companies>, ICompanyRepository
    {
        public FakeCompanysRepository()
            : base(new FakeCompanies().MyCompanies)
        {
        }

        public FakeCompanysRepository(List<Companies> myCompanys)
            : base(myCompanys)
        {
        }

    }
}
