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
        public Flight GetById(object id)
        {
            return DataSource.Flights.Find(x => x.Id == (int)id);
        }

        public List<Flight> Get()
        {
            return DataSource.Flights;
        }

        public void Create(Flight entity)
        {
            DataSource.Flights.Add(entity);
        }

        public void Update(Flight entity)
        {
            Flight flight = DataSource.Flights.First(x => x.Id == entity.Id);
            flight.ArrivalPoint = entity.ArrivalPoint;
            flight.ArrivalTime = entity.ArrivalTime;
            flight.DeparturePoint = entity.DeparturePoint;
            flight.DepartureTime = entity.DepartureTime;
            flight.Tickets = entity.Tickets;
        }

        public bool Delete(object id)
        {
            Flight flight = DataSource.Flights.First(x => x.Id == (int)id);
            if (flight != null)
            {
                DataSource.Flights.Remove(flight);
                return true;
            }
            return false;
        }


        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
