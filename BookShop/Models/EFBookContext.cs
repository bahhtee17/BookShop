using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class EFBookContext : DbContext
    {
        public EFBookContext(DbContextOptions<EFBookContext> options): base(options) { }
        public DbSet<Book> Books { get; set; }

        
    }
}
