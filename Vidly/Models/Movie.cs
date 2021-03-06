﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        [Display(Name = "Date of Release" )]
        [Required]
        public DateTime? ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; }
        [Display(Name = "Number in Stock")]
        [Required]
        [Range(1,500)]
        public int NumberInStock { get; set; }



    }
}