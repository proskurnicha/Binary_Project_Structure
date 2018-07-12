using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Binary_Project_Structure_DataAccess.Interfaces;
using Binary_Project_Structure_DataAccess.Models;

namespace Binary_Project_Structure_DataAccess.Repositories
{
    public class TicketRepository : IRepository<Ticket>
    {
        public Ticket GetById(object id)
        {
            return DataSource.Tickets.Find(x => x.Id == (int)id);
        }

        public List<Ticket> Get()
        {
            return DataSource.Tickets;
        }

        public void Create(Ticket entity)
        {
            DataSource.Tickets.Add(entity);
        }

        public void Update(Ticket entity)
        {
            DataSource.Tickets.First(x => x.Id == entity.Id);
            Ticket Ticket = DataSource.Tickets.First(x => x.Id == entity.Id);
            Ticket.Price = entity.Price;
            Ticket.FlightId = entity.FlightId;
            Ticket.Flight = DataSource.Flights.Find(flight => flight.Id == entity.FlightId);
        }

        public bool Delete(object id)
        {
            Ticket Ticket = DataSource.Tickets.First(x => x.Id == (int)id);
            if (Ticket != null)
            {
                DataSource.Tickets.Remove(Ticket);
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
