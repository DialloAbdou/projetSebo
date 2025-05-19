using AppliSebo.Dtos;
using SeboDomain.Models;

namespace AppliSebo.mapping
{
    public class CategoryProfile
    {
        public static Category getMappingCategory(CategoryInput input)
        {
            return new Category
            {
                NomCategorie = input.NomCategorie,

            };
        }

        public static CategoryOutput getMappingCategoryOutput(Category category)
        {
            return new CategoryOutput
                (
                 Id : category.Id,
                 NomCategory: category.NomCategorie
                );
        }
    }
}
