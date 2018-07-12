using System;
using System.Collections.Generic;
using System.Text;
using Binary_Project_Structure_DataAccess.Models;
using Binary_Project_Structure_DataAccess.Interfaces;
using System.Linq;

namespace Binary_Project_Structure_DataAccess.Repositories
{
    public class FlightRepository : IRepository<Flight>
    {
        protected readonly IDataSource source;

        public FlightRepository(IDataSource source)
        {
            this.source = source;
        }

        public Flight GetById(object id)
        {
            return source.Flights.First(x => x.Id == (int)id);
        }

        public List<Flight> Get()
        {
            return source.Flights;
        }

        public void Create(Flight entity)
        {
            source.Flights.Add(entity);
        }

        public void Update(Flight entity)
        {
            Flight flight = source.Flights.First(x => x.Id == entity.Id);
            flight.ArrivalPoint = entity.ArrivalPoint;
            flight.ArrivalTime = entity.ArrivalTime;
            flight.DeparturePoint = entity.DeparturePoint;
            flight.DepartureTime = entity.DepartureTime;
            flight.Tickets = entity.Tickets;
        }

        public void Delete(object id)
        {
            Flight flight = source.Flights.First(x => x.Id == (int)id);
            if (flight != null)
            {
                source.Flights.Remove(flight);
            }
        }


        public void Save()
        {
            throw new NotImplementedException();
        }
    }

}
