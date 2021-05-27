using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Store.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required, MaxLength(250)]
        public String Title { get; set; }

        [Required]
        public String Description { get; set; }

        [Required]
        public byte[] Image { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public double Rate { get; set; }

        [Required]
        public int TotalPages { get; set; }

        [Required]
        public DateTime PublishedDtae { get; set; } = DateTime.Now;

        [Required]
        public byte GenreId { get; set; }
        public Genre Genres { get; set; }
    }
}
