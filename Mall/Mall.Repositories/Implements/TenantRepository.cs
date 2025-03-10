using Mall.DALs.Repositories.Interfaces;
using Mall.Models.Data;
using Mall.Models.Entities;
using Maynghien.Infrastructure.Repository;

namespace Mall.DALs.Repositories.Implements
{
    public class TenantRepository : GenericRepository<Tenant, ApplicationDbContext, ApplicationUser>, ITenantRepository
    {
        public TenantRepository(ApplicationDbContext unitOfWork) : base(unitOfWork)
        {
        }
    }
}
