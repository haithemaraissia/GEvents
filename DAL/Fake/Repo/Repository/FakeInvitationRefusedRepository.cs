using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeInvitationRefusedsRepository : FakeGenericRepository<InvitationsRefuseds>, IInvitationRefusedRepository
    {
        public FakeInvitationRefusedsRepository()
            : base(new FakeInvitationRefused().MyInvitationRefused)
        {
        }

        public FakeInvitationRefusedsRepository(List<InvitationsRefuseds> myInvitationRefuseds)
            : base(myInvitationRefuseds)
        {
        }

    }
}
