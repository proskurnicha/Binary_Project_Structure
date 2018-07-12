using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Binary_Project_Structure_BLL.Interfaces;
using Binary_Project_Structure_BLL.Services;
using Binary_Project_Structure_Shared.DTOs;
namespace Binary_Project_Structure.Controllers
{
    [Produces("application/json")]
    [Route("api/Flights")]
    public class FlightsController : Controller
    {
        IFlightService service;

        public FlightsController(IFlightService service)
        {
            this.service = service;
        }
        // GET: api/Flights
        [HttpGet]
        public IEnumerable<FlightDto> Get()
        {
            return service.GetFlights();
        }

        // GET: api/Flights/5
        [HttpGet("{id}", Name = "Get")]
        public FlightDto Get(int id)
        {
            return service.GetFlightById(id);
        }

        // POST: api/Flights
        [HttpPost]
        public void Post([FromBody]FlightDto flight)
        {
            service.Create(flight);
        }

        // PUT: api/Flights/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]FlightDto flight)
        {
            service.Update(flight);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
