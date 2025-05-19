using Microsoft.EntityFrameworkCore;
using SeboDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeboInfrastructure
{
    public class SeboDbContext :DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public SeboDbContext( DbContextOptions<SeboDbContext> options)
            :base(options)
        {
            
        }
    }
}
