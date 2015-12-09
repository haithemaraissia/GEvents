using System;
using DAL.Data.Generic;
using DAL.Fake.Repo.Repository;
using Model;

namespace DAL.Data.UnitofWork
{
    public class UnitofWork : IUnitofWork
    {

        #region Constructors

        private readonly GEventsContext _context;

        public UnitofWork()
        {
            _context = new GEventsContext();
        }

        public UnitofWork(GEventsContext context)
        {
            _context = context;
        }

        #endregion

        #region Model

        //Model
       
        #region AgendaRepository

        private IGenericRepository<Agenda> _agendaRepository;
        public IGenericRepository<Agenda> AgendaRepository
        {
            get { return _agendaRepository ?? (_agendaRepository = new GenericRepository<Agenda>(_context)); }
            set { _agendaRepository = value; }
        }
        #endregion

        #region BoothRepository

        private IGenericRepository<Booths> _boothRepository;
        public IGenericRepository<Booths> BoothRepository
        {
            get { return _boothRepository ?? (_boothRepository = new GenericRepository<Booths>(_context)); }
            set { _boothRepository = value; }
        }
        #endregion

        #region BuyerRepository

        private IGenericRepository<Buyers> _buyerRepository;
        public IGenericRepository<Buyers> BuyerRepository
        {
            get { return _buyerRepository ?? (_buyerRepository = new GenericRepository<Buyers>(_context)); }
            set { _buyerRepository = value; }
        }
        #endregion

        #region CompanyRepository

        private IGenericRepository<Companies> _companyRepository;
        public IGenericRepository<Companies> CompanyRepository
        {
            get { return _companyRepository ?? (_companyRepository = new GenericRepository<Companies>(_context)); }
            set { _companyRepository = value; }
        }
        #endregion

        #region EventRateSectionRepository

        private IGenericRepository<EventRateSection> _eventRateSectionRepository;
        public IGenericRepository<EventRateSection> EventRateSectionRepository
        {
            get { return _eventRateSectionRepository ?? (_eventRateSectionRepository = new GenericRepository<EventRateSection>(_context)); }
            set { _eventRateSectionRepository = value; }
        }

        #endregion

        #region EventsRepository

        private IGenericRepository<Events> _eventsRepository;
        public IGenericRepository<Events> EventRepository
        {
            get { return _eventsRepository ?? (_eventsRepository = new GenericRepository<Events>(_context)); }
            set { _eventsRepository = value; }
        }
        #endregion

        #region EventTypesRepository

        private IGenericRepository<EventTypes> _eventTypesRepository;
        public IGenericRepository<EventTypes> EventTypeRepository
        {
            get { return _eventTypesRepository ?? (_eventTypesRepository = new GenericRepository<EventTypes>(_context)); }
            set { _eventTypesRepository = value; }
        }
        #endregion

        #region FeedBacksRepository

        private IGenericRepository<FeedBacks> _feedbacksRepository;
        public IGenericRepository<FeedBacks> FeedBackRepository
        {
            get { return _feedbacksRepository ?? (_feedbacksRepository = new GenericRepository<FeedBacks>(_context)); }
            set { _feedbacksRepository = value; }
        }
        #endregion

        #region SellersRepository

        private IGenericRepository<Sellers> _sellersRepository;
        public IGenericRepository<Sellers> SellerRepository
        {
            get { return _sellersRepository ?? (_sellersRepository = new GenericRepository<Sellers>(_context)); }
            set { _sellersRepository = value; }
        }
        #endregion

        #region SpeakersRepository

        private IGenericRepository<Speakers> _speakersRepository;
        public IGenericRepository<Speakers> SpeakerRepository
        {
            get { return _speakersRepository ?? (_speakersRepository = new GenericRepository<Speakers>(_context)); }
            set { _speakersRepository = value; }
        }
        #endregion

        #region SpeakerSchedulesRepository

        private IGenericRepository<SpeakerSchedules> _speakerSchedulesRepository;
        public IGenericRepository<SpeakerSchedules> SpeakerScheduleRepository
        {
            get { return _speakerSchedulesRepository ?? (_speakerSchedulesRepository = new GenericRepository<SpeakerSchedules>(_context)); }
            set { _speakerSchedulesRepository = value; }
        }
        #endregion

        #region UsersRepository

        private IGenericRepository<Users> _usersRepository;
        public IGenericRepository<Users> UserRepository
        {
            get { return _usersRepository ?? (_usersRepository = new GenericRepository<Users>(_context)); }
            set { _usersRepository = value; }
        }
        #endregion

        #region UserTypesRepository

        private IGenericRepository<UserTypes> _userTypesRepository;
        public IGenericRepository<UserTypes> UserTypeRepository
        {
            get { return _userTypesRepository ?? (_userTypesRepository = new GenericRepository<UserTypes>(_context)); }
            set { _userTypesRepository = value; }
        }
        #endregion

        #region InvitationsRepository

        private IGenericRepository<Invitations> _invitationsRepository;
        public IGenericRepository<Invitations> InvitationsRepository
        {
            get { return _invitationsRepository ?? (_invitationsRepository = new GenericRepository<Invitations>(_context)); }
            set { _invitationsRepository = value; }
        }
        #endregion

        #region InvitationAcceptedRepository

        private IGenericRepository<InvitationsAccepted> _invitationAcceptedRepository;
        public IGenericRepository<InvitationsAccepted> InvitationAcceptedRepository
        {
            get { return _invitationAcceptedRepository ?? (_invitationAcceptedRepository = new GenericRepository<InvitationsAccepted>(_context)); }
            set { _invitationAcceptedRepository = value; }
        }
        #endregion

        #region InvitationRefusedRepository

        private IGenericRepository<InvitationsRefuseds> _invitationRefusedRepository;
        public IGenericRepository<InvitationsRefuseds> InvitationRefusedRepository
        {
            get { return _invitationRefusedRepository ?? (_invitationRefusedRepository = new GenericRepository<InvitationsRefuseds>(_context)); }
            set { _invitationRefusedRepository = value; }
        }
        #endregion

        #region InvitationScheduleRepository

        private IGenericRepository<InvitationSchedules> _invitationScheduleRepositoryRepository;
        public IGenericRepository<InvitationSchedules> InvitationScheduleRepository
        {
            get { return _invitationScheduleRepositoryRepository ?? (_invitationScheduleRepositoryRepository = new GenericRepository<InvitationSchedules>(_context)); }
            set { _invitationScheduleRepositoryRepository = value; }
        }
        #endregion

      #endregion

        #region Saving and Disposing

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed;

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        #endregion
    }      
}