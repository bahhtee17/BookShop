using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class EFBookRepository : IBookRepository
    {
        private EFBookContext context;
        public EFBookRepository(EFBookContext cont)
        {
            context = cont;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
