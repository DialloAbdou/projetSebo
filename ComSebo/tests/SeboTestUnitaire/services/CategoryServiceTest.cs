using FluentAssertions;
using SeboDomain.Models;
using ServiceSebo.contratServices;
using ServiceSebo.domainSrervices;

namespace SeboTestUnitaire.services
{
    public class CategoryServiceTest
    {
        private CategorieService _service;
        private static Category category = new Category
        {
            Id = 1,
            NomCategorie = "Livre"
        };
        [Fact]
        public void GetAllCategory_should_be_return_empty()
        {
            _service = new CategorieService();
            var result = _service.GetAllCategoriesAsync();
            result.Should().BeEmpty();
        }

        [Fact]
        public void GetAllCategory_should_be_return_Not_Empty()
        {
           // Arrange
            _service = new CategorieService();
            var isexisted = _service.IsExistedCateg(category.NomCategorie);          
            Category? _category = _service.AddASyncCategorie(category);
            //Action
            var result = _service.GetAllCategoriesAsync();
            // Assert
            result.Should().NotBeEmpty();
            _category.Id.Should().Be(category.Id);
            _category.NomCategorie.Should().Be(category.NomCategorie);

        }

        [Fact]
        public void AddCategory_should_be_Category_Not_Existed_In_DB()
        {
            // Arrange
            _service = new CategorieService();

            Category? _category = _service.AddASyncCategorie(category);
            //Action
            var result = _service.GetAllCategoriesAsync();
            // Assert
            result.Should().NotBeEmpty();
            _category.Id.Should().Be(category.Id);
            _category.NomCategorie.Should().Be(category.NomCategorie);

        }

    }
}
