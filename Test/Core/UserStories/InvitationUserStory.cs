using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DAL.Data.UnitofWork;
using DAL.Fake.Model.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Test.Base;
using Test.Helper;

namespace Test.Core.UserStories
{
    [TestClass]
    public class InvitationUserStory
    {
        #region Variables

        private UnitofWork _uow;
        private BuyerHelper _mikeBuyer;
        private BuyerHelper _saraBuyer;
        private SellerHelper _jeffSeller;
        private SellerHelper _candiSeller;

        #region Mike Counts
        public int MikeInvitationCount;
        public int MikeInvitationAcceptedCount;
        public int MikeInvitationRefusedCount;
        public int MikeInvitationScheduledCount;
        #endregion

        #region Sara Counts
        public int SaraInvitationCount;
        public int SaraInvitationAcceptedCount;
        public int SaraInvitationRefusedCount;
        public int SaraInvitationScheduledCount;
        #endregion

        #region Jeff Counts
        public int JeffInvitationCount;
        public int JeffInvitationAcceptedCount;
        public int JeffInvitationRefusedCount;
        public int JeffInvitationScheduledCount;
        #endregion

        #region Candi Counts
        public int CandiInvitationCount;
        public int CandiInvitationAcceptedCount;
        public int CandiInvitationRefusedCount;
        public int CandiInvitationScheduledCount;
        #endregion
        #endregion

        [TestInitialize]
        public void InvitationUserStoryInit()
        {

            #region Buyer / Seller
            _uow = new Uow().AllRepo();
            var firstBuyer = _uow.BuyerRepository.All.First();
            _mikeBuyer = new BuyerHelper(_uow, firstBuyer);
            var secondBuyer = _uow.BuyerRepository.All.Skip(1).First();
            _saraBuyer = new BuyerHelper(_uow, secondBuyer);

            var firstSeller = _uow.SellerRepository.All.First();
            _jeffSeller = new SellerHelper(_uow, firstSeller);
            var secondSeller = _uow.SellerRepository.All.Skip(1).First();
            _candiSeller = new SellerHelper(_uow, secondSeller);
            #endregion

            #region Init Counts
            #region Mike
            MikeInvitationCount = _mikeBuyer.GetInvitationCount();
            MikeInvitationAcceptedCount = _mikeBuyer.GetAcceptedInvitationCount();
            MikeInvitationRefusedCount = _mikeBuyer.GetRefusedInvitationCount();
            MikeInvitationScheduledCount = _mikeBuyer.GetScheduledInvitationCount();
            #endregion

            #region Sara
            SaraInvitationCount = _saraBuyer.GetInvitationCount();
            SaraInvitationAcceptedCount = _saraBuyer.GetAcceptedInvitationCount();
            SaraInvitationRefusedCount = _saraBuyer.GetRefusedInvitationCount();
            SaraInvitationScheduledCount = _saraBuyer.GetScheduledInvitationCount();
            #endregion

            #region Jeff
            JeffInvitationCount = _jeffSeller.GetInvitationCount();
            JeffInvitationAcceptedCount = _jeffSeller.GetAcceptedInvitationCount();
            JeffInvitationRefusedCount = _jeffSeller.GetRefusedInvitationCount();
            JeffInvitationScheduledCount = _jeffSeller.GetScheduledInvitationCount();
            #endregion

            #region Candi
            CandiInvitationCount = _candiSeller.GetInvitationCount();
            CandiInvitationAcceptedCount = _candiSeller.GetAcceptedInvitationCount();
            CandiInvitationRefusedCount = _candiSeller.GetRefusedInvitationCount();
            CandiInvitationScheduledCount = _candiSeller.GetScheduledInvitationCount();
            #endregion
            #endregion
        }

        [TestMethod]
        public void InvitationsCases()
        {

            #region InitCountVerification
            #region Mike
            Assert.AreEqual(1, MikeInvitationCount);
            Assert.AreEqual(0, MikeInvitationAcceptedCount);
            Assert.AreEqual(0, MikeInvitationRefusedCount);
            Assert.AreEqual(0, MikeInvitationScheduledCount);
            #endregion

            #region Sara
            Assert.AreEqual(1, SaraInvitationCount);
            Assert.AreEqual(0, SaraInvitationAcceptedCount);
            Assert.AreEqual(2, SaraInvitationRefusedCount);
            Assert.AreEqual(3, SaraInvitationScheduledCount);
            #endregion

            #region Jeff
            Assert.AreEqual(3, JeffInvitationCount);
            Assert.AreEqual(0, JeffInvitationAcceptedCount);
            Assert.AreEqual(0, JeffInvitationRefusedCount);
            Assert.AreEqual(0, JeffInvitationScheduledCount);
            #endregion

            #region Candi
            Assert.AreEqual(0, CandiInvitationCount);
            Assert.AreEqual(0, CandiInvitationAcceptedCount);
            Assert.AreEqual(3, CandiInvitationRefusedCount);
            Assert.AreEqual(3, CandiInvitationScheduledCount);
            #endregion
            #endregion

            #region AcceptInvitation
            //Accept
            var jeffInvitation = _jeffSeller.CreateInvitation(_mikeBuyer.Buyer.BuyerId, 5, DateTime.Today.AddHours(3));
            _mikeBuyer.AcceptInvitation(jeffInvitation);
            Assert.AreEqual(4, JeffInvitationCount);
            Assert.AreEqual(1, JeffInvitationScheduledCount);
            Assert.AreEqual(1, MikeInvitationAcceptedCount);
            #endregion

            #region RefuseInvitation
            //Refuse
            var candiInvitation = _candiSeller.CreateInvitation(_mikeBuyer.Buyer.BuyerId, 5, DateTime.Today.AddHours(10));
            _mikeBuyer.RefuseInvitation(candiInvitation);
            Assert.AreEqual(1, candiInvitation);
            Assert.AreEqual(1, MikeInvitationRefusedCount);
            #endregion

            #region ClearRefusedInvitation
            //Clear Refused
            _mikeBuyer.ClearRefusedInvitation(candiInvitation);
            Assert.AreEqual(0, MikeInvitationRefusedCount);
            Assert.AreEqual(0, MikeInvitationCount);
            #endregion

            #region AcceptInvitationAfterClearRefused
            //Accepted after Clear Refused
            var candiSecondInvitation = _candiSeller.CreateInvitation(_mikeBuyer.Buyer.BuyerId, 10, DateTime.Today.AddHours(14));
            _mikeBuyer.AcceptInvitation(candiSecondInvitation);
            Assert.AreEqual(4, CandiInvitationScheduledCount);
            Assert.AreEqual(2, MikeInvitationAcceptedCount);
            #endregion

            #region AnotherSellerInvitation
            //Another Seller
            var jeffSecondInvitation = _jeffSeller.CreateInvitation(_saraBuyer.Buyer.BuyerId, 15, DateTime.Today.AddHours(3));
            _saraBuyer.AcceptInvitation(jeffSecondInvitation);
            Assert.AreEqual(5, JeffInvitationCount);
            Assert.AreEqual(2, JeffInvitationScheduledCount);
            Assert.AreEqual(1, SaraInvitationAcceptedCount);
            #endregion
        }
    }
}
