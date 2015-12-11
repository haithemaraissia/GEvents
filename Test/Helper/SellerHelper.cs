using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Data.UnitofWork;
using DAL.Fake.Model.Util;
using Test.Base;

namespace Test.Helper
{
    public class SellerHelper
    {
        //Functions
        //Create Invitation

        private readonly UnitofWork _uow;

        public SellerHelper()
        {
            _uow = new Uow().AllRepo();
        }

        public SellerHelper(UnitofWork uow)
        {
            _uow = uow;
        }

        public void CreateInvitation(int buyerId, int sellerId, int boothId, DateTime date)
        {
            if (DoesInvitationExist(sellerId, buyerId)) return;
            var newInvitation = new Model.Invitations
            {
                BuyerId = buyerId,
                SellerId = sellerId,
                BoothId = boothId,
                Date = date,
                StatusId = (int) InvitationStatus.Values.Pending
            };
            _uow.InvitationsRepository.Add(newInvitation);
            _uow.Save();
        }

        private bool DoesInvitationExist(int sellerId, int buyerId)
        {
            var invitationCount = _uow.InvitationsRepository.Count(x => x.SellerId == sellerId & x.BuyerId == buyerId);
            return invitationCount >= 1;
        }


        #region Common

        private int GetInvitationCount(int sellerId)
        {
            return _uow.InvitationsRepository.Count(x => x.SellerId == sellerId);
        }

        private int GetAcceptedInvitationCount(int sellerId)
        {
            return _uow.InvitationAcceptedRepository.Count(x => x.SellerId == sellerId);
        }

        private int GetRefusedInvitationCount(int sellerId)
        {
            return _uow.InvitationRefusedRepository.Count(x => x.SellerId == sellerId);
        }

        private int GetScheduledInvitationCount(int sellerId)
        {
            return _uow.InvitationScheduleRepository.Count(x => x.SellerId == sellerId);
        }
        #endregion

    }
}
