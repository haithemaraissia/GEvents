using DAL.Data.Generic;
using DAL.Data.Repo.IRepository;
using Model;

namespace DAL.Data.Repo.Repository
{
    public class EventRepository : GenericRepository<Events>, IEventRepository
    {
    }
}
       