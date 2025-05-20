using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeboDomain.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
