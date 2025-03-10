using Mall.Models.Data;
using Mall.Models.Entities;
using Mall.Repositories.Interfaces;
using Maynghien.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mall.Repositories.Implements
{
    public class CategoryRepository : GenericRepository<Category, ApplicationDbContext, ApplicationUser>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext unitOfWork) : base(unitOfWork)
        {
        }
    }
}
