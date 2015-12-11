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
    public class BuyerHelper
    {
        //Functions
        //Accept Invitation
        //Refuse Invitation
        //Clear Refused Invitation

        private readonly UnitofWork _uow;

        public BuyerHelper()
        {
            _uow = new Uow().AllRepo();
        }

        public BuyerHelper(UnitofWork uow)
        {
            _uow = uow;
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

        private int GetInvitationCount(int buyerId)
        {
            return _uow.InvitationsRepository.Count(x => x.BuyerId == buyerId);
        }

        private int GetAcceptedInvitationCount(int buyerId)
        {
            return _uow.InvitationAcceptedRepository.Count(x => x.BuyerId == buyerId);
        }

        private int GetRefusedInvitationCount(int buyerId)
        {
            return _uow.InvitationRefusedRepository.Count(x => x.BuyerId == buyerId);
        }

        private int GetScheduledInvitationCount(int buyerId)
        {
            return _uow.InvitationScheduleRepository.Count(x => x.BuyerId == buyerId);
        }
        #endregion
    }
}
