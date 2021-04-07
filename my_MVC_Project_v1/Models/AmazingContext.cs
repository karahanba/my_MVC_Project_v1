using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_MVC_Project_v1.Models
{
    public class AmazingContext : DbContext
    {

        public AmazingContext(DbContextOptions<AmazingContext> opt) : base(opt)
        {

        }

        public DbSet<_Iletisim> Contact { get; set; } // Contact is table's name in db

        public DbSet<Urunler> Products { get; set; }
    }
}
