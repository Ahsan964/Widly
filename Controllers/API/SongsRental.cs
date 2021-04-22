using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Widly.Dtos;
using Widly.Models;

namespace Widly.Controllers.API
{
    public class SongsRentalController : ApiController
    {
        private ApplicationDbContext _context;

        public SongsRentalController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);

            var songs = _context.Songs.Where(
                s => newRental.SongIds.Contains(s.ID)).ToList();

            foreach (var song in songs)
            {
            
                var rental = new SongsRental()
                {
                    Customer = customer,
                    Song = song,
                    DateRented = DateTime.Now
                };

                _context.SongsRentals.Add(rental);
            }


            _context.SaveChanges();

            return Ok();
        }
    }
}
