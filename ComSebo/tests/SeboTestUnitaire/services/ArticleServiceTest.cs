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
    public class ArticleServiceTest
    {
        private static Article article = new Article
        {
            Id = 1,
            Editeur = "petit Lettre A",
            Créateur = "createur",
            Description = "description",
            Etat = false,
            Etat_Reapro = false,
            Prix = 5,
            Qte_stock = 5,
            Référence = "12458A",
            Titre = "Apprendre Angular",
            Seuil_mini = 3,
            GenreId = 1,


        };
        [Fact]
        public void GetAllAticle_Should_be_Emty_inDb()
        {
            // Arrange
            var articleservice = new ArticleServices();
            // Action
            var articles = articleservice.GetAllArticle();
            //Assert
            articles.Should().NotBeNull();
        }

        [Fact]
        public void GetAllAticle_Should_Not_be_Emty_inDb()
        {
            // Arrange
            var articleservice = new ArticleServices();

            // Action
            var resutArticle = articleservice.CreateArticle(article);
            var articles = articleservice.GetAllArticle();
            //Assert
            articles.Should().NotBeNull();
        }

        [Fact]
        public void AddAticle_when_Genre_and_category_Existed()
        {
            // Arrange
            var articleservice = new ArticleServices();

            var _genre = new Genre
            {
                Id = 1,
                Category = new Category { Id = 1, NomCategorie = "Livre" }
            };
            // Action
            var isExisted = articleservice.isExisted(_genre.Id);
            var resutArticle = articleservice.CreateArticle(article);
            resutArticle.Should().NotBeNull();
            resutArticle.Id.Should().Be(1);
            resutArticle.Prix.Should().Be(5);

        }
    }
}
