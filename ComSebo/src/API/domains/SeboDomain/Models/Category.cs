﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeboDomain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string NomCategorie { get; set; } = String.Empty;
        public List<Genre?> Genres { get; set; } = new List<Genre>();
    }
}
