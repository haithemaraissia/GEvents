using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Data.UnitofWork;
using DAL.Fake.Repo.Repository;

namespace Test.Base
{
    public class Uow
    {
        public Uow()
        {

        }

        public UnitofWork AllRepo()
        {
            // Arrange
            var agendaRepo = new FakeAgendasRepository();
            var boothRepo = new FakeBoothsRepository();
            var buyerRepo = new FakeBuyersRepository();
            var companyRepo = new FakeCompanysRepository();
            var eventRateSectionRepo = new FakeEventRatesRepository();
            var eventsRepo = new FakeEventsRepository();
            var eventTypesRepo = new FakeEventTypesRepository();
            var feedBackRepo = new FakeFeedBacksRepository();
            var invitationsRepo = new FakeInvitationsRepository();
            var invitationAcceptedRepo = new FakeInvitationAcceptedsRepository();
            var invitationRefusedRepo = new FakeInvitationRefusedsRepository();
            var invitationScheduleRepo = new FakeInvitationSchedulesRepository();
            var sellerRepo = new FakeSellersRepository();
            var speakerRepo = new FakeSpeakersRepository();
            var speakerScheduleRepo = new FakeSpeakerSchedulesRepository();
            var userRepo = new FakeUserRepository();
            var userTypeRepo = new FakeUserTypeRepository();

            return new UnitofWork
            {
                AgendaRepository = agendaRepo,
                BoothRepository = boothRepo,
                BuyerRepository = buyerRepo,
                CompanyRepository = companyRepo,
                EventRateSectionRepository = eventRateSectionRepo,
                EventRepository = eventsRepo,
                EventTypeRepository = eventTypesRepo,
                FeedBackRepository = feedBackRepo,
                InvitationAcceptedRepository = invitationAcceptedRepo,
                InvitationRefusedRepository = invitationRefusedRepo,
                InvitationScheduleRepository = invitationScheduleRepo,
                InvitationsRepository = invitationsRepo,
                SellerRepository = sellerRepo,
                SpeakerRepository = speakerRepo,
                SpeakerScheduleRepository = speakerScheduleRepo,
                UserRepository = userRepo,
                UserTypeRepository = userTypeRepo,

            };

        }

        ~Uow()
        {
        }
    }
}
