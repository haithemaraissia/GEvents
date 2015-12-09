using System.Collections.Generic;
using DAL.Data.UnitofWork;
using DAL.Fake.Model.Invitations.Core.Buyer;
using DAL.Fake.Model.Invitations.Seller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Base;

namespace Test.Core.Invitations.Scenario
{

    [TestClass]
    public class InvitationScenario
    {
        #region Global

        private List<Model.Invitations> _seller1Invitation;
        private List<Model.Invitations> _buyer1Invitation;
        private UnitofWork _uow;

        #endregion

        #region Init and Simple

        [TestInitialize]
        public void Initialize()
        {
            _uow = new Uow().AllRepo();
            _seller1Invitation = new SellerInvitations().Seller1Invitation;     
            _buyer1Invitation = new BuyerInvitations().GetBuyerIncomingInvitations();
        }

        //public void IndexShouldListAllOwners()
        //{
        //    // Act
        //    var actual = Controller.Index();

        //    // Assert
        //    var viewResult = actual as ViewResult;
        //    if (viewResult == null) return;
        //    var data = viewResult.ViewData.Model as IList<Owner>;
        //    if (data != null) Assert.AreEqual(3, data.Count);
        //}

        #endregion







        [TestMethod]
        public void Test()
        {

        }


        #region Buyer Send Seller Invitation and Seller Accepted /Refuse

        //Given
        //Seller1
        //Buyer1
        //private SellerSendInvitationToBuyer();
        //private BuyerAcceptInviationSent(int invitationId);
        //private BuyerRefuseInvitationSent(int inviationId);

        #endregion

        #region Buyer Send a second Invitation to the Seller

        #endregion

        #region Buyer send an Invitation to a second Seller

        #endregion

        #region Buyer View Invitation Schedule

        #endregion

        #region Seller View Invitation Schedule

        #endregion

        #region Buyer Delete refused Invitation

        #endregion

        #region Buyer Send a new Invitation after the refused Invitation is deleted

        #endregion

        #region Buyer View Invitation Schedule

        #endregion

        #region Seller View Invitation Schedule

        #endregion





        [TestCleanup]
        public void CleanUp()
        {
            //  Controller.Dispose();
            _seller1Invitation = null;
            _buyer1Invitation = null;
            _uow = null;


        }
    }
}
