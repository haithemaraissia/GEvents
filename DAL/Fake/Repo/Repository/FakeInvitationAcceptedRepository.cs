using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeInvitationAcceptedsRepository : FakeGenericRepository<InvitationsAccepted>, IInvitationAcceptedRepository
    {
        public FakeInvitationAcceptedsRepository()
            : base(new FakeInvitationAccepted().MyInvitations)
        {
        }

        public FakeInvitationAcceptedsRepository(List<InvitationsAccepted> myInvitationAccepteds)
            : base(myInvitationAccepteds)
        {
        }

    }
}
