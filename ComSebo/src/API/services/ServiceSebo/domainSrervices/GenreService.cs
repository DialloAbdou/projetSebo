using SeboDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSebo.domainSrervices
{
    public class GenreService
    {
        private List<Genre> _genreLists = new List<Genre>();
        private List<Category> _categories = new List<Category>();
        
        public List<Genre> GetAllGenre()
        {
            
            return _genreLists;
        }
        public Genre? CreateGenre(Genre genre)
        {
            // verifion si category exist
            if (IsCategExisted(genre.CategoryId)) return null;
             _genreLists.Add(genre);
            return genre;
        }

        public bool IsCategExisted(int categId)
        {
            return _categories.Any(c=>c.Id == categId);    
        }

    }
}
