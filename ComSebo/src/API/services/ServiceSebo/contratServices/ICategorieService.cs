using ServiceSebo.domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceSebo.contratServices
{
    public interface ICategorieService
    {
       Category AddCategorie(Category category);
    }
}
