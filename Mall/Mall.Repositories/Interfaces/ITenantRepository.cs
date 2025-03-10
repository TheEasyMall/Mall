using Mall.Models.Data;
using Mall.Models.Entities;
using Maynghien.Infrastructure.Repository;

namespace Mall.DALs.Repositories.Interfaces
{
    public interface ITenantRepository : IGenericRepository<Tenant, ApplicationDbContext, ApplicationUser>
    {
    }
}
