using System;
using System.Collections.Generic;
using Model;

namespace DAL.Fake
{
    public class FakeInvitationAccepted
    {
        public List<InvitationsAccepted> MyInvitations;

        public FakeInvitationAccepted()
        {
            InitializeInvitationList();
        }

        public void InitializeInvitationList()
        {
            MyInvitations = new List<InvitationsAccepted> {
                FirstInvitation(), 
                SecondInvitation(),
                ThirdInvitation()
            };
        }

        public InvitationsAccepted FirstInvitation()
        {
            var firstInvitation = new InvitationsAccepted
            {
                InvitationId = 1,
                BuyerId = 1,
                SellerId = 1,
                BoothId = 1,
                Date = DateTime.Today.Date
            };
            return firstInvitation;
        }

        public InvitationsAccepted SecondInvitation()
        {
            var secondInvitation = new InvitationsAccepted
            {
                InvitationId = 2,
                BuyerId = 1,
                SellerId = 2,
                BoothId = 1,
                Date = DateTime.Today.Date
            };
            return secondInvitation;
        }

        public InvitationsAccepted ThirdInvitation()
        {
            var thirdInvitation = new InvitationsAccepted
            {
                InvitationId = 3,
                BuyerId = 1,
                SellerId = 3,
                BoothId = 1,
                Date = DateTime.Today.Date
            };
            return thirdInvitation;
        }
        ~FakeInvitationAccepted()
        {
            MyInvitations = null;
        }
    }
}
