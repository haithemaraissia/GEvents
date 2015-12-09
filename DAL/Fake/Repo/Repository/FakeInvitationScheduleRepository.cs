using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeInvitationSchedulesRepository : FakeGenericRepository<InvitationSchedules>, IInvitationScheduleRepository
    {
        public FakeInvitationSchedulesRepository()
            : base(new FakeInvitationSchedules().MyInvitationSchedules)
        {
        }

        public FakeInvitationSchedulesRepository(List<InvitationSchedules> myInvitationSchedules)
            : base(myInvitationSchedules)
        {
        }

    }
}
