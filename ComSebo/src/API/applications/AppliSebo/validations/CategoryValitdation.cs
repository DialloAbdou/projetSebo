using AppliSebo.Dtos;
using FluentValidation;

namespace AppliSebo.validations
{
    public class CategoryValitdation : AbstractValidator<CategoryInput>
    {
        public CategoryValitdation()
        {
            RuleFor(c => c.NomCategorie).NotEmpty();
        }
    }
}
