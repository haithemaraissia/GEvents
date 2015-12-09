using System;
using System.Collections.Generic;


namespace DAL.Fake.Model.Invitations.Seller
{
    public class SellerInvitations
    {
        public List<global::Model.Invitations> Seller1Invitation;

        public SellerInvitations()
        {
            InitializeInvitationList();
        }

        public void InitializeInvitationList()
        {
            Seller1Invitation = new List<global::Model.Invitations> {
                FirstInvitation(), 
                SecondInvitation(),
                ThirdInvitation()
            };
        }

        #region Seller1
       
        public global::Model.Invitations FirstInvitation()
        {
            var firstInvitation = new global::Model.Invitations
            {
                InvitationId = 1,
                BuyerId = 1,
                SellerId = 1,
                BoothId = 1,
                Date = DateTime.Today.Date
            };
            return firstInvitation;
        }

        public global::Model.Invitations SecondInvitation()
        {
            var secondInvitation = new global::Model.Invitations
            {
                InvitationId = 2,
                BuyerId = 2,
                SellerId = 1,
                BoothId = 1,
                Date = DateTime.Today.Date
            };
            return secondInvitation;
        }

        public global::Model.Invitations ThirdInvitation()
        {
            var thirdInvitation = new global::Model.Invitations
            {
                InvitationId = 3,
                BuyerId = 2,
                SellerId = 1,
                BoothId = 2,
                Date = DateTime.Today.Date.AddMinutes(40)
            };
            return thirdInvitation;
        }

        #endregion

        ~SellerInvitations()
        {
            Seller1Invitation = null;
        }
    }
}
