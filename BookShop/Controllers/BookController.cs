using BookShop.Models;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository repository;
        public int pagesize = 4;

        public BookController(IBookRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Books);
               
            
           
         
    }
}
