using Book_Store.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Store.ViewModels
{
    public class BookFormViewModel
    {
        public int Id { get; set; }

        [Required, StringLength(250)]
        [Display(Name = "Book Title")]
        public String Title { get; set; }

        [Required]
        public String Description { get; set; }

        public byte[] Image { get; set; }

        [Required]
        public double Price { get; set; }

        [Range(1,5, ErrorMessage = "Value for Rate must be between 1 and 5.")]
        public double Rate { get; set; }

        [Display(Name = "Total Pages")]
        public int TotalPages { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
    }
}
