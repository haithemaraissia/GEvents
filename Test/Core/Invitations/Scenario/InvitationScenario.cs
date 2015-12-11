using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using DAL.Data.UnitofWork;
using DAL.Fake.Model.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Test.Base;

namespace Test.Core.Invitations.Scenario
{

    [TestClass]
    public class InvitationScenario
    {
        #region Done

        #region Global

        private UnitofWork _uow;

        #endregion

        #region Init and Simple

        [TestInitialize]
        public void Initialize()
        {
            _uow = new Uow().AllRepo();
        }

        #endregion



        [TestMethod]
        public void Integration()
        {
            #region Seller Send Buyer Invitation and Seller Accept /Refuse

            Assert.AreEqual(0, GetCurrentSellerScheduledInvitationCount());
            Assert.AreEqual(0, GetCurrentBuyerScheduledInvitationCount());
            Assert.AreEqual(3, GetCurrentSellerInvitationCount());
            Assert.AreEqual(1, GetCurrentBuyerInvitationCount());

            if (!DoesInvitationExist(1, 4))
            {
                var newInvitation = new Model.Invitations
                {
                    BuyerId = 4,
                    SellerId = 1,
                    BoothId = 4,
                    Date = DateTime.Today.Date,
                    StatusId = (int)InvitationStatus.Values.Pending
                };
                _uow.InvitationsRepository.Add(newInvitation);
                _uow.Save();
                Assert.AreEqual(4, GetCurrentSellerInvitationCount());
                Assert.AreEqual(1, GetCurrentBuyerInvitationCount());
            }

            #endregion

            #region BuyerAcceptOrRefuseInvitation

            Assert.AreEqual(0, GetCurrentSellerAcceptedInvitationCount());
            Assert.AreEqual(0, GetCurrentBuyerAcceptedInvitationCount());
            BuyerAcceptInvitation();
            Assert.AreEqual(1, GetCurrentSellerAcceptedInvitationCount());
            Assert.AreEqual(1, GetCurrentBuyerAcceptedInvitationCount());

            BuyerRefuseInvitation();
            Assert.AreEqual(1, GetCurrentSellerAcceptedInvitationCount());
            Assert.AreEqual(1, GetCurrentBuyerAcceptedInvitationCount());
            Assert.AreEqual(1, GetCurrentSellerRefusedInvitationCount());
            Assert.AreEqual(1, GetCurrentBuyerRefusedInvitationCount());
            #endregion

            #region Seller Send a second Invitation to the Buyer, it won't be added because the invitation does exist

            Assert.AreEqual(4, GetCurrentSellerInvitationCount());
            Assert.AreEqual(1, GetCurrentBuyerInvitationCount());
            if (!DoesInvitationExist(1, 4))
            {
                var newSecondInvitation = new Model.Invitations
                {
                    BuyerId = 4,
                    SellerId = 1,
                    BoothId = 4,
                    Date = DateTime.Today.Date,
                    StatusId = (int)InvitationStatus.Values.Pending
                };
                _uow.InvitationsRepository.Add(newSecondInvitation);
                _uow.Save();
            }
            Assert.AreEqual(4, GetCurrentSellerInvitationCount());
            Assert.AreEqual(1, GetCurrentBuyerInvitationCount());


            #endregion

            #region Seller send an Invitation to a second Buyer

            Assert.AreEqual(4, GetCurrentSellerInvitationCount());
            Assert.AreEqual(1, GetCurrentBuyerInvitationCount());
            if (!DoesInvitationExist(1, 5))
            {
                var newThirdInvitation = new Model.Invitations
                {
                    BuyerId = 5,
                    SellerId = 1,
                    BoothId = 4,
                    Date = DateTime.Today.Date,
                    StatusId = (int)InvitationStatus.Values.Pending
                };
                _uow.InvitationsRepository.Add(newThirdInvitation);
                _uow.Save();
                Assert.AreEqual(5, GetCurrentSellerInvitationCount());
                Assert.AreEqual(1, GetCurrentBuyerInvitationCount());
            }

            #endregion

            #region Buyer View Invitation Schedule
            Assert.AreEqual(1, GetCurrentBuyerScheduledInvitationCount());

            #endregion

            #region Seller View Invitation Schedule
            Assert.AreEqual(1, GetCurrentSellerScheduledInvitationCount());
            #endregion

            #region Buyer Delete refused Invitation

            Assert.AreEqual(1, GetCurrentSellerRefusedInvitationCount());
            Assert.AreEqual(1, GetCurrentBuyerRefusedInvitationCount());
            var refusedInvitation = _uow.InvitationRefusedRepository.FindBy(x => x.BuyerId == BuyerId).LastOrDefault();
         
            if (refusedInvitation != null)
            {   
                int refusedInvitationid = refusedInvitation.InvitationId;
                _uow.InvitationRefusedRepository.Delete(refusedInvitation);
                _uow.Save();
                Assert.AreEqual(0, GetCurrentSellerRefusedInvitationCount());
                Assert.AreEqual(0, GetCurrentBuyerRefusedInvitationCount());

                #region Seller Send a new Invitation after the refused Invitation is deleted

                UpdateInvitation(refusedInvitationid, (int)InvitationStatus.Values.Pending);
                BuyerAcceptInvitation(refusedInvitationid);

                #region Buyer View Invitation Schedule
                Assert.AreEqual(1, GetCurrentBuyerScheduledInvitationCount());

                #endregion

                #region Seller View Invitation Schedule
                Assert.AreEqual(1, GetCurrentSellerScheduledInvitationCount());
                #endregion

                #endregion

            }



            #endregion

        }





        #endregion




























        #region Common

        #region Buyer Actions Accept/Refuse Invitations

        private void BuyerAcceptInvitation()
        {
            //Last Invitation: Buyer Accept
            var lastInvitation = _uow.InvitationsRepository.FindBy(x => x.BuyerId == BuyerId && x.SellerId == SellerId).LastOrDefault();
            if (lastInvitation != null)
            {
                var lastInvitationId = lastInvitation.InvitationId;
                UpdateInvitation(lastInvitationId, (int)InvitationStatus.Values.Accepted);
            }
        }

        private void BuyerAcceptInvitation(int invitationId)
        {
            var invitation = GetInvitationById(invitationId);
            if (invitation != null)
            {
                var acceptedInvitation = new InvitationsAccepted
                {
                    BuyerId = invitation.BuyerId,
                    SellerId = invitation.SellerId,
                    BoothId = invitation.BoothId,
                    Date = invitation.Date,
                    InvitationId = invitation.InvitationId
                };
                _uow.InvitationAcceptedRepository.Add(acceptedInvitation);
                CreateInvitationSchedule(acceptedInvitation);
                _uow.Save();
            }
        }

        private void BuyerRefuseInvitation()
        {
            //First Invitation: Buyer Refuse
            var firstInvitation = _uow.InvitationsRepository.FindBy(x => x.BuyerId == BuyerId && x.SellerId == SellerId).FirstOrDefault();
            if (firstInvitation != null)
            {
                var firstInvitationId = firstInvitation.InvitationId;
                UpdateInvitation(firstInvitationId, (int)InvitationStatus.Values.Refused);
            }
        }

        private void BuyerRefuseInvitation(int invitationId)
        {
            var invitation = GetInvitationById(invitationId);
            if (invitation != null)
            {
                var exisitingInvitationRefused =
                    _uow.InvitationRefusedRepository.FindBy(x => x.InvitationId == invitationId).FirstOrDefault();
                if (exisitingInvitationRefused == null)
                {
                                    var refusedInvitation = new InvitationsRefuseds
                {
                    BuyerId = invitation.BuyerId,
                    SellerId = invitation.SellerId,
                    BoothId = invitation.BoothId,
                    Date = invitation.Date,
                    InvitationId = invitation.InvitationId
                };
                _uow.InvitationRefusedRepository.Add(refusedInvitation);
                _uow.Save();
                }

            }
        }

        #endregion

        #region Common Methods

        #region Seller

        private const int SellerId = 1;

        private int GetCurrentSellerInvitationCount()
        {
            return _uow.InvitationsRepository.Count(x => x.SellerId == SellerId);
        }

        private int GetCurrentSellerAcceptedInvitationCount()
        {
            return _uow.InvitationAcceptedRepository.Count(x => x.SellerId == SellerId);
        }

        private int GetCurrentSellerRefusedInvitationCount()
        {
            return _uow.InvitationRefusedRepository.Count(x => x.SellerId == SellerId);
        }

        private int GetCurrentSellerScheduledInvitationCount()
        {
            return _uow.InvitationScheduleRepository.Count(x => x.SellerId == SellerId);
        }

        #endregion

        #region Buyer

        private const int BuyerId = 1;

        private int GetCurrentBuyerInvitationCount()
        {
            return _uow.InvitationsRepository.Count(x => x.BuyerId == BuyerId);
        }

        private int GetCurrentBuyerAcceptedInvitationCount()
        {
            return _uow.InvitationAcceptedRepository.Count(x => x.BuyerId == BuyerId);
        }

        private int GetCurrentBuyerRefusedInvitationCount()
        {
            return _uow.InvitationRefusedRepository.Count(x => x.BuyerId == BuyerId);
        }

        private int GetCurrentBuyerScheduledInvitationCount()
        {
            return _uow.InvitationScheduleRepository.Count(x => x.BuyerId == BuyerId);
        }

        #endregion

        #region Invitation

        private bool DoesInvitationExist(int sellerId, int buyerId)
        {
            var invitationCount = _uow.InvitationsRepository.Count(x => x.SellerId == sellerId & x.BuyerId == buyerId);
            return invitationCount >= 1;
        }

        private Model.Invitations GetInvitationById(int invitationId)
        {
            return _uow.InvitationsRepository.FindBy(x => x.InvitationId == invitationId).FirstOrDefault();
        }

        private void UpdateInvitation(int invitationId, int invitationStatus)
        {

            switch (invitationStatus)
            {
                case (int)InvitationStatus.Values.Accepted:
                    UpdateInviationsStatus(invitationId, invitationStatus);
                    BuyerAcceptInvitation(invitationId);
                    break;
                case (int)InvitationStatus.Values.Refused:
                    UpdateInviationsStatus(invitationId, invitationStatus);
                    BuyerRefuseInvitation(invitationId);
                    break;
                default:
                    break;

            }
        }

        private void UpdateInviationsStatus(int invitationId, int invitationStatus)
        {
            var currentinvitation = GetInvitationById(invitationId);
            if (currentinvitation != null)
            {
                currentinvitation.StatusId = invitationStatus;
            }
            _uow.Save();
        }

        private void CreateInvitationSchedule(InvitationsAccepted invitationAccepted)
        {
            var existingInvitationCount =
                _uow.InvitationScheduleRepository.Count(
                    x => x.BuyerId == invitationAccepted.BuyerId && x.SellerId == invitationAccepted.SellerId);

            if (existingInvitationCount == 0)
            {
                var newScheduledInvitation = new InvitationSchedules
                {
                    BuyerId = invitationAccepted.BuyerId,
                    SellerId = invitationAccepted.SellerId,
                    BoothId = invitationAccepted.BoothId,
                    Date = invitationAccepted.Date,
                    InvitationId = invitationAccepted.InvitationId
                };
                _uow.InvitationScheduleRepository.Add(newScheduledInvitation);
            }
        }
        #endregion

        #endregion

        #endregion

        [TestCleanup]
        public void CleanUp()
        {
            _uow = null;
        }
    }
}
