using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models.ViewModels
{
    public class AuthorBookListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public List<Book> Books { get; set; }
        public Book Book { get; set; }
       
    }
}
