using SeboDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSebo.contratServices
{
    public interface ICategorieService
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category> AddASyncCategorie(Category category);
    }
}
