using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hily.Models;

namespace Hily.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}