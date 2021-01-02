using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class RentalController : ApiController
    {
        private ApplicationDbContext _context;
        public RentalController()
        {
            _context = new ApplicationDbContext();
            
        }

        public IHttpActionResult GetRentals()
        {
            var rentalDtos = _context.Rentals.Include(m => m.Movie).Include(c=>c.Customer).ToList().Select(Mapper.Map<Rental, RentalDto>);

            return Ok(rentalDtos);

        }

    }
}
