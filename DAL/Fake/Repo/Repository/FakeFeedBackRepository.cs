using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeFeedBacksRepository : FakeGenericRepository<FeedBacks>, IFeedbackRepository
    {
        public FakeFeedBacksRepository()
            : base(new FakeFeedBacks().MyFeedBacks)
        {
        }

        public FakeFeedBacksRepository(List<FeedBacks> myFeedBacks)
            : base(myFeedBacks)
        {
        }

    }
}
