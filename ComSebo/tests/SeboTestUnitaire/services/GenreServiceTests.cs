using FluentAssertions;
using SeboDomain.Models;
using ServiceSebo.domainSrervices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeboTestUnitaire.services
{

    public class GenreServiceTests
    {
        private CategorieService _categorieService;
        private GenreService _genreService;
        private static Category category = new Category
        {
            Id = 1,
            NomCategorie = "Livre",


        };

        private static Genre genre = new Genre
        {
            Id = 1,
            Type = "litterature",
            Category = category,
            CategoryId = category.Id,
        };
        public GenreServiceTests()
        {
            _genreService = new GenreService();
            _categorieService = new CategorieService();
        }
        

        [Fact]
        public void GetAllGenre_Should_Be_Return_Empty_when_Db_isEmpty()
        {
            //Arrange
           //Action
           var results= _genreService.GetAllGenre();
            //Assert
            results.Should().BeEmpty();

        }

        [Fact]
        public void GetAllGenre_Should_Be_Return_notEmpty_when_Db_isNotEmpty()
        {
            //Arrange 
            var _categ = _categorieService.AddASyncCategorie(category);
            var isExisted = _genreService.IsCategExisted(category.Id);
            var _genre = _genreService.CreateGenre(genre);
            var _listGenres = _genreService.GetAllGenre();
            //Ac
            //Assert
            _genre.Should().NotBeNull();
            _genre.Id.Should().Be(1);
            _listGenres.Should().NotBeNull();

        }
    }


}
