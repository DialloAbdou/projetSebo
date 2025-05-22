using SeboDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSebo.domainSrervices
{
    public class ArticleServices
    {
        private List<Genre> _genreList = new List<Genre>()
        {
             new Genre { Id = 1, Type= "Litterature", Category = new Category {Id =1, NomCategorie = "Livre"} }

        }; 
        private List<Article> _articles = new List<Article>();  
        public List<Article> GetAllArticle()
        {
            return _articles;
        }

        public Article ? CreateArticle(Article article) 
        {
            // verifier si la category existed
           if(!isExisted(article.GenreId)) return null;
            _articles.Add(article);
            return article;
        }
        public bool  isExisted(int genreId)
        {
            return _genreList.Any(g=>g.Id == genreId);
        }
    }
}
