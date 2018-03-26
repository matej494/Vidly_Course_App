using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_Course_App.Models;

namespace Vidly_Course_App.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}