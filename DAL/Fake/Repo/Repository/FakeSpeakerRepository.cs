using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeSpeakersRepository : FakeGenericRepository<Speakers>, ISpeakerRepository
    {
        public FakeSpeakersRepository()
            : base(new FakeSpeakers().MySpeakers)
        {
        }

        public FakeSpeakersRepository(List<Speakers> mySpeakers)
            : base(mySpeakers)
        {
        }

    }
}
