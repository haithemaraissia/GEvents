using DAL.Data.Generic;
using DAL.Data.Repo.IRepository;
using Model;

namespace DAL.Data.Repo.Repository
{
    public class UserTypeRepository : GenericRepository<UserTypes>, IUserTypeRepository
    {
    }
}
       