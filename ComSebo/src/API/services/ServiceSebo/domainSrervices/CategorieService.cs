using SeboDomain.Models;
using SeboInfrastructure.Contracts;
using ServiceSebo.contratServices;


namespace ServiceSebo.domainSrervices
{
    public class CategorieService
    {
        private List<Category> _categories = new List<Category>();
        public Category? AddASyncCategorie(Category category)
        {
            if (IsExistedCateg(category.NomCategorie)) return null;
              _categories.Add(category);
               return category;

        }
        public bool IsExistedCateg(string nomCateg)
        {

            return _categories.Any(c => c.NomCategorie != nomCateg);
        }

        public List<Category> GetAllCategoriesAsync()
        {
            return _categories.ToList();
        }
    }
}
