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
    public class InvitationHelper
    {
        private readonly UnitofWork _uow;

        public InvitationHelper()
        {
            _uow = new Uow().AllRepo();
        }

        public InvitationHelper(UnitofWork uow)
        {
            _uow = uow;
        }



        public void UpdateInvitation(int invitationId, int invitationStatus)
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
                case (int)InvitationStatus.Values.Cleared:
                    BuyerClearRefusedInvitation(invitationId);
                    DeleteInvitation(invitationId);
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

        private Model.Invitations GetInvitationById(int invitationId)
        {
            return _uow.InvitationsRepository.FindBy(x => x.InvitationId == invitationId).FirstOrDefault();
        }


        private void BuyerAcceptInvitation(int invitationId)
        {
            var invitation = GetInvitationById(invitationId);
            if (invitation != null)
            {
                var existingAcceptedInvitation = _uow.InvitationAcceptedRepository.FindBy(x => x.InvitationId == invitationId).FirstOrDefault();
                if (existingAcceptedInvitation == null)
                {
                    var acceptedInvitation = new InvitationsAccepted
                    {
                        #if (DEBUG )
                            InvitationsAcceptedId = _uow.InvitationAcceptedRepository.All.Max(x => x.InvitationsAcceptedId) + 1,
                        #endif
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
#if (DEBUG )
                        InvitationRefusedId = _uow.InvitationRefusedRepository.All.Max(x => x.InvitationRefusedId) + 1,
#endif
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

        private void BuyerClearRefusedInvitation(int invitationId)
        {
            var invitationRefused = _uow.InvitationRefusedRepository.FindBy(x => x.InvitationId == invitationId).FirstOrDefault();

            if (invitationRefused == null) return;
            _uow.InvitationRefusedRepository.Delete(invitationRefused);
            _uow.Save();
        }

        private void DeleteInvitation(int invitationId)
        {
            var invitation = _uow.InvitationsRepository.FindBy(x => x.InvitationId == invitationId).FirstOrDefault();

            if (invitation == null) return;
            _uow.InvitationsRepository.Delete(invitation);
            _uow.Save();
        }

        private void CreateInvitationSchedule(InvitationsAccepted invitationAccepted)
        {
            var existingInvitationCount =_uow.InvitationScheduleRepository.Count(x => x.BuyerId == invitationAccepted.BuyerId && x.SellerId == invitationAccepted.SellerId);

            if (existingInvitationCount == 0)
            {
                var newScheduledInvitation = new InvitationSchedules
                {
#if (DEBUG )
                    InvitationScheduleId = _uow.InvitationScheduleRepository.All.Max(x => x.InvitationScheduleId) + 1,
#endif
                    BuyerId = invitationAccepted.BuyerId,
                    SellerId = invitationAccepted.SellerId,
                    BoothId = invitationAccepted.BoothId,
                    Date = invitationAccepted.Date,
                    InvitationId = invitationAccepted.InvitationId
                };
                _uow.InvitationScheduleRepository.Add(newScheduledInvitation);
                _uow.Save();
            }
        }

    }
}
