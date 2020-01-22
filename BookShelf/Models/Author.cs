using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShelf.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Display(Name = "Author")]
        public string Name { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public List<Book> Books { get; set; }
    }
}