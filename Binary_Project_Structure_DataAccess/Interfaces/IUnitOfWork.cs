using System;
using System.Collections.Generic;
using System.Text;
using Binary_Project_Structure_DataAccess.Models;

namespace Binary_Project_Structure_DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Flight> Flights { get; }

        IRepository<Ticket> Tickets { get; }

        //int SaveChages();

        //Task<int> SaveChangesAsync();
    }
}
