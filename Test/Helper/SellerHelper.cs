using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Data.UnitofWork;
using DAL.Fake.Model.Util;
using Model;
using Test.Base;

namespace Test.Helper
{
    public class SellerHelper
    {
        //Functions
        //Create Invitation

        private readonly UnitofWork _uow;
        public readonly Sellers Seller;

        public SellerHelper()
        {
            _uow = new Uow().AllRepo();
            Seller = new Sellers();
        }

        public SellerHelper(UnitofWork uow,  Sellers s)
        {
            _uow = uow;
            Seller = s;
        }

        public int CreateInvitation(int buyerId, int boothId, DateTime date)
        {
            if (DoesInvitationExist(Seller.SellerId, buyerId)) return 0;
            var newInvitation = new Model.Invitations
            {
                BuyerId = buyerId,
                SellerId = Seller.SellerId,
                BoothId = boothId,
                Date = date,
                StatusId = (int) InvitationStatus.Values.Pending
            };
            _uow.InvitationsRepository.Add(newInvitation);
            _uow.Save();
            return (newInvitation.InvitationId);
        }

        private bool DoesInvitationExist(int sellerId, int buyerId)
        {
            var invitationCount = _uow.InvitationsRepository.Count(x => x.SellerId == sellerId & x.BuyerId == buyerId);
            return invitationCount >= 1;
        }


        #region Common
        public List<Invitations> GetInvitations()
        {
            return _uow.InvitationsRepository.FindBy(x => x.SellerId == Seller.SellerId).ToList();
        }
        public int GetInvitationCount()
        {
            return _uow.InvitationsRepository.Count(x => x.SellerId == Seller.SellerId);
        }

        public List<InvitationsAccepted> GetAcceptedInvitations()
        {
            return _uow.InvitationAcceptedRepository.FindBy(x => x.SellerId == Seller.SellerId).ToList();
        }
        public int GetAcceptedInvitationCount()
        {
            return _uow.InvitationAcceptedRepository.Count(x => x.SellerId == Seller.SellerId);
        }

        public List<InvitationsRefuseds> GetRefusedInvitations()
        {
            return _uow.InvitationRefusedRepository.FindBy(x => x.SellerId == Seller.SellerId).ToList();
        }
        public int GetRefusedInvitationCount()
        {
            return _uow.InvitationRefusedRepository.Count(x => x.SellerId == Seller.SellerId);
        }

        public List<InvitationSchedules> GetScheduledInvitations()
        {
            return _uow.InvitationScheduleRepository.FindBy(x => x.SellerId == Seller.SellerId).ToList();
        }
        public int GetScheduledInvitationCount()
        {
            return _uow.InvitationScheduleRepository.Count(x => x.SellerId == Seller.SellerId);
        }
        #endregion

    }
}
