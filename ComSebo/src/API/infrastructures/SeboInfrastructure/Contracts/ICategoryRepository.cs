using SeboDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeboInfrastructure.Contracts
{
    public interface ICategoryRepository
    {
        Task<Category> AddAsyncCategory(Category category);
        Task<IEnumerable<Category>> GetAllAsyncCategories();
    }
}
