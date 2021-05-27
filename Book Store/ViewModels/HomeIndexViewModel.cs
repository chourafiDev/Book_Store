using Book_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Store.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<Book> Books { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
