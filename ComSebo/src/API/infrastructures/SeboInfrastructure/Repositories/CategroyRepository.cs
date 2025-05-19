using Microsoft.EntityFrameworkCore;
using SeboDomain.Models;
using SeboInfrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeboInfrastructure.Repositories
{
    public class CategroyRepository : ICategoryRepository
    {
       
        private SeboDbContext _dbContext;
        public CategroyRepository(SeboDbContext seboDbContext)
        {
            _dbContext = seboDbContext;
        }
        public async Task<Category> AddAsyncCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            await _dbContext.SaveChangesAsync();
            return category;
        }

        public async Task<IEnumerable<Category>> GetAllAsyncCategories()
        {
            return await _dbContext.Categories.ToListAsync();
        }
    }
}
