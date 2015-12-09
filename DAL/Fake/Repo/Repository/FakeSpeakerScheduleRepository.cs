using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeSpeakerSchedulesRepository : FakeGenericRepository<SpeakerSchedules>, ISpeakerScheduleRepository
    {
        public FakeSpeakerSchedulesRepository()
            : base(new FakeSpeakerSchedules().MySpeakerSchedules)
        {
        }

        public FakeSpeakerSchedulesRepository(List<SpeakerSchedules> mySpeakerSchedules)
            : base(mySpeakerSchedules)
        {
        }

    }
}
