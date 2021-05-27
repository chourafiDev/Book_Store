using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Store.Models
{
    public class ApplicationUser : IdentityUser
    {
        //[Required, MaxLength(30)]
        //public string AccountType { get; set; }

        [Required, MaxLength(30)]
        public string FirstName { get; set; }

        [Required, MaxLength(30)]
        public string LastName { get; set; }

        [Required, MaxLength(30)]
        public string Country { get; set; }

        [Required, MaxLength(50)]
        public string FullAdress { get; set; }

        [Required, MaxLength(5)]
        public string ZipCode { get; set; }

        public DateTime DateCreate { get; set; } = DateTime.Now;

        public byte[] UserPhoto { get; set; }
    }
}
