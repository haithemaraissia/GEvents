using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Fake.Model.Invitations.Core.Buyer;
using DAL.Fake.Model.Invitations.Seller;

namespace DAL.Fake.Model.Invitations.Core.Scenario
{
    public class InvitationScenario
    {

        public InvitationScenario()
        {
            var Seller1Invitation = new SellerInvitations().Seller1Invitation;
            var Buyer1Invitation = new BuyerInvitations().GetBuyerIncomingInvitations();
        }

//        #region Buyer Send Seller Invitation and Seller Accepted /Refuse 

//        //Given
//        //Seller1
//        //Buyer1
//        private SellerSendInvitationToBuyer();
//        private BuyerAcceptInviationSent(int invitationId);
//        private BuyerRefuseInvitationSent(int inviationId);

//        #endregion

//        #region Buyer Send a second Invitation to the Seller

//        private SellerSendInvitationToSameSeller();

//        #endregion

//        #region Buyer send an Invitation to a second Seller

//        #endregion

//        #region Buyer View Invitation Schedule

//        #endregion

//        #region Seller View Invitation Schedule

//        #endregion

//        #region Buyer Delete refused Invitation

//        #endregion

//        #region Buyer Send a new Invitation after the refused Invitation is deleted

//        #endregion

//        #region Buyer View Invitation Schedule

//        #endregion

//        #region Seller View Invitation Schedule

//        #endregion


//    }



//~publicInvitationScenario()
//{

//}

}

}
