using Mall.Models.Data;
using Mall.Models.Entities;
using Maynghien.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.Repositories.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category, ApplicationDbContext, ApplicationUser>
    {
    }
}
