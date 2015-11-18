using System;
using DAL.Data.Generic;
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
       
        #region ClientRepository

        private IGenericRepository<Events> _eventRepository;
        public IGenericRepository<Events> EventRepository
        {
            get { return _eventRepository ?? (_eventRepository = new GenericRepository<Events>(_context)); }
            set { _eventRepository = value; }
        }
        #endregion

        //#region CookerRepository

        //private IGenericRepository<Cooker> _cookerRepository;
        //public IGenericRepository<Cooker> CookerRepository
        //{
        //    get { return _cookerRepository ?? (_cookerRepository = new GenericRepository<Cooker>(_context)); }
        //    set { _cookerRepository = value; }
        //}
        //#endregion

        //#region CookerMenusRepository
        
        //private IGenericRepository<CookerMenu> _cookerMenuRepository;
        //public IGenericRepository<CookerMenu> CookerMenuRepository
        //{
        //    get { return _cookerMenuRepository ?? (_cookerMenuRepository = new GenericRepository<CookerMenu>(_context)); }
        //    set { _cookerMenuRepository = value; }
        //}
        //#endregion

        //#region CookerMenuPriceRepository

        //private IGenericRepository<CookerMenuPrice> _cookerMenuPriceRepository;
        //public IGenericRepository<CookerMenuPrice> CookerMenuPriceRepository
        //{
        //    get { return _cookerMenuPriceRepository ?? (_cookerMenuPriceRepository = new GenericRepository<CookerMenuPrice>(_context)); }
        //    set { _cookerMenuPriceRepository = value; }
        //}
        //#endregion

        //#region CuisineTypesRepository

        //private IGenericRepository<Cooker> _cuisineTypeRepository;
        //public IGenericRepository<Cooker> CuisineTypeRepository
        //{
        //    get { return _cuisineTypeRepository ?? (_cuisineTypeRepository = new GenericRepository<Cooker>(_context)); }
        //    set { _cuisineTypeRepository = value; }
        //}
        //#endregion

        //#region CurrenciesRepository

        //private IGenericRepository<Currency> _currenciesRepository;
        //public IGenericRepository<Currency> CurrenciesRepository
        //{
        //    get { return _currenciesRepository ?? (_currenciesRepository = new GenericRepository<Currency>(_context)); }
        //    set { _currenciesRepository = value; }
        //}
        //#endregion

        //#region DishesTypesRepository

        //private IGenericRepository<Dish> _dishesRepository;
        //public IGenericRepository<Dish> DishesRepository
        //{
        //    get { return _dishesRepository ?? (_dishesRepository = new GenericRepository<Dish>(_context)); }
        //    set { _dishesRepository = value; }
        //}
        //#endregion

        //#region InvoicesRepository

        //private IGenericRepository<Invoice> _invoicesRepository;
        //public IGenericRepository<Invoice> InvoicesRepository
        //{
        //    get { return _invoicesRepository ?? (_invoicesRepository = new GenericRepository<Invoice>(_context)); }
        //    set { _invoicesRepository = value; }
        //}
        //#endregion

        //#region MenuServingRepository

        //private IGenericRepository<MenuServing> _menuServingRepository;
        //public IGenericRepository<MenuServing> MenuServingRepository
        //{
        //    get { return _menuServingRepository ?? (_menuServingRepository = new GenericRepository<MenuServing>(_context)); }
        //    set { _menuServingRepository = value; }
        //}
        //#endregion

        //#region OrdersRepository

        //private IGenericRepository<Order> _orderRepository;
        //public IGenericRepository<Order> OrderRepository
        //{
        //    get { return _orderRepository ?? (_orderRepository = new GenericRepository<Order>(_context)); }
        //    set { _orderRepository = value; }
        //}
        //#endregion

        //#region ReviewsRepository

        //private IGenericRepository<Review> _reviewsRepository;
        //public IGenericRepository<Review> ReviewRepository
        //{
        //    get { return _reviewsRepository ?? (_reviewsRepository = new GenericRepository<Review>(_context)); }
        //    set { _reviewsRepository = value; }
        //}
        //#endregion

        //#region ServingPricingsRepository

        //private IGenericRepository<ServingPricing> _servingPricingRepository;
        //public IGenericRepository<ServingPricing> ServingPricingRepository
        //{
        //    get { return _servingPricingRepository ?? (_servingPricingRepository = new GenericRepository<ServingPricing>(_context)); }
        //    set { _servingPricingRepository = value; }
        //}
        //#endregion

        //#region UsersRepository

        //private IGenericRepository<User> _usersRepository;
        //public IGenericRepository<User> UserRepository
        //{
        //    get { return _usersRepository ?? (_usersRepository = new GenericRepository<User>(_context)); }
        //    set { _usersRepository = value; }
        //}
        //#endregion

        //#region UserTypesRepository

        //private IGenericRepository<UserType> _userTypeRepository;
        //public IGenericRepository<UserType> UserTypeRepository
        //{
        //    get { return _userTypeRepository ?? (_userTypeRepository = new GenericRepository<UserType>(_context)); }
        //    set { _userTypeRepository = value; }
        //}
        //#endregion

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