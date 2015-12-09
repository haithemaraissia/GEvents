using System.Collections.Generic;
using DAL.Data.Repo.IRepository;
using DAL.Fake.Generic;
using DAL.Fake.Model;
using Model;

namespace DAL.Fake.Repo.Repository
{
    public class FakeInvitationsRepository : FakeGenericRepository<Invitations>, IInvitationRepository
    {
        public FakeInvitationsRepository()
            : base(new FakeInvitations().MyInvitations)
        {
        }

        public FakeInvitationsRepository(List<Invitations> myInvitationss)
            : base(myInvitationss)
        {
        }

    }
}
