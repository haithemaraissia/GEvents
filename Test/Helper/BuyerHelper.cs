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
    public class BuyerHelper
    {
        //Functions
        //Accept Invitation
        //Refuse Invitation
        //Clear Refused Invitation

        private readonly UnitofWork _uow;
        public  Buyers Buyer;


        public BuyerHelper()
        {
            _uow = new Uow().AllRepo();
            Buyer = new Buyers();
        }

        public BuyerHelper(UnitofWork uow, Buyers b)
        {
            _uow = uow;
            Buyer = b;
        }

        public void AcceptInvitation(int invitationId)
        {
            var invitationHelper = new InvitationHelper(_uow);
            invitationHelper.UpdateInvitation(invitationId, (int)InvitationStatus.Values.Accepted);
        }

        public void RefuseInvitation(int invitationId)
        {
            var invitationHelper = new InvitationHelper(_uow);
            invitationHelper.UpdateInvitation(invitationId, (int)InvitationStatus.Values.Refused);
        }

        public void ClearRefusedInvitation(int invitationId)
        {
            var invitationHelper = new InvitationHelper(_uow);
            invitationHelper.UpdateInvitation(invitationId, (int)InvitationStatus.Values.Cleared);
        }



        #region Common

        public List<Invitations> GetInvitations()
        {
            return _uow.InvitationsRepository.FindBy(x => x.BuyerId == Buyer.BuyerId).ToList();
        }
        public int GetInvitationCount()
        {
            return _uow.InvitationsRepository.Count(x => x.BuyerId == Buyer.BuyerId);
        }

        public List<InvitationsAccepted> GetAcceptedInvitations()
        {
            return _uow.InvitationAcceptedRepository.FindBy(x => x.BuyerId == Buyer.BuyerId).ToList();
        }
        public int GetAcceptedInvitationCount()
        {
            return _uow.InvitationAcceptedRepository.Count(x => x.BuyerId == Buyer.BuyerId);
        }

        public List<InvitationsRefuseds> GetRefusedInvitations()
        {
            return _uow.InvitationRefusedRepository.FindBy(x => x.BuyerId == Buyer.BuyerId).ToList();
        }
        public int GetRefusedInvitationCount()
        {
            return _uow.InvitationRefusedRepository.Count(x => x.BuyerId == Buyer.BuyerId);
        }

        public List<InvitationSchedules> GetScheduledInvitations()
        {
            return _uow.InvitationScheduleRepository.FindBy(x => x.BuyerId == Buyer.BuyerId).ToList();
        }
        public int GetScheduledInvitationCount()
        {
            return _uow.InvitationScheduleRepository.Count(x => x.BuyerId == Buyer.BuyerId);
        }

        #endregion
    }
}
