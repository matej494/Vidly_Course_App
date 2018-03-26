using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Vidly_Course_App.Dtos;
using Vidly_Course_App.Models;

namespace Vidly_Course_App.Controllers.Api
{
    public class NewRentalController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {            
            var customer = _context.Customer.Single(c => c.Id == newRental.CustomerId);
                                                                     
            var movies = _context.Movie.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();
                                
            foreach (var movie in movies)
            {
                if (movie.NumberAvalible == 0)
                    return BadRequest("Movie is not avalible");

                movie.NumberAvalible--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}