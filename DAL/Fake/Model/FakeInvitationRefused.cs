using System;
using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeInvitationRefused
    {
        public List<InvitationsRefuseds> MyInvitationRefused;

        public FakeInvitationRefused()
        {
            InitializeInvitationsRefusedList();
        }

        public void InitializeInvitationsRefusedList()
        {
            MyInvitationRefused = new List<InvitationsRefuseds> {
                FirstInvitationsRefused(), 
                SecondInvitationsRefused(),
                ThirdInvitationsRefused()
            };
        }

        public InvitationsRefuseds FirstInvitationsRefused()
        {
            var firstInvitationsRefused = new InvitationsRefuseds
            {
                InvitationId = 1,
                BuyerId = 1,
                SellerId = 1,
                BoothId = 1,
                Date = DateTime.Today.Date
            };
            return firstInvitationsRefused;
        }

        public InvitationsRefuseds SecondInvitationsRefused()
        {
            var secondInvitationsRefused = new InvitationsRefuseds
            {
                InvitationId = 2,
                BuyerId = 1,
                SellerId = 1,
                BoothId = 1,
                Date = DateTime.Today.Date
            };
            return secondInvitationsRefused;
        }

        public InvitationsRefuseds ThirdInvitationsRefused()
        {
            var thirdInvitationsRefused = new InvitationsRefuseds
            {
                InvitationId = 3,
                BuyerId = 1,
                SellerId = 1,
                BoothId = 1,
                Date = DateTime.Today.Date
            };
            return thirdInvitationsRefused;
        }
        ~FakeInvitationRefused()
        {
            MyInvitationRefused = null;
        }
    }
}
