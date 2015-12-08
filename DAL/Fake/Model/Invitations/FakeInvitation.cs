using System;
using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeInvitations
    {
        public List<Invitations> MyInvitations;

        public FakeInvitations()
        {
            InitializeInvitationList();
        }

        public void InitializeInvitationList()
        {
            MyInvitations = new List<Invitations> {
                FirstInvitation(), 
                SecondInvitation(),
                ThirdInvitation()
            };
        }

        public Invitations FirstInvitation()
        {
            var firstInvitation = new Invitations
            {
                InvitationId = 1,
                BuyerId = 1,
                SellerId = 1,
                BoothId = 1,
                Date = DateTime.Today.Date
            };
            return firstInvitation;
        }

        public Invitations SecondInvitation()
        {
            var secondInvitation = new Invitations
            {
                InvitationId = 2,
                BuyerId = 1,
                SellerId = 2,
                BoothId = 1,
                Date = DateTime.Today.Date
            };
            return secondInvitation;
        }

        public Invitations ThirdInvitation()
        {
            var thirdInvitation = new Invitations
            {
                InvitationId = 3,
                BuyerId = 1,
                SellerId = 3,
                BoothId = 1,
                Date = DateTime.Today.Date
            };
            return thirdInvitation;
        }
        ~FakeInvitations()
        {
            MyInvitations = null;
        }
    }
}
