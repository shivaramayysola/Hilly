using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using Hily.Models;
using System.ComponentModel.DataAnnotations;

namespace Hily.ViewModels
{
    public class MovieFormViewModel
    {
        public MovieFormViewModel(Movie movie)
        {
            Movie = movie;
        }

        public  IEnumerable<Genre> Genres { get; set; }

        public Movie Movie { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name ="Genre")]
        [Required]
        public byte? GenreId { get; set; }


        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in stock")]
        [Range(1,20)]
        [Required]
        public byte? NumberInStock { get; set; }

        public string Title 

        {
            get
            {

                return Id != 0 ? "Edit Movie" : "New Movie";
                

            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }
        
    }
}