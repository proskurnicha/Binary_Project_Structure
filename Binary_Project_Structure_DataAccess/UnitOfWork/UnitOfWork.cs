using System;
using System.Collections.Generic;
using System.Text;
using Binary_Project_Structure_DataAccess.Repositories;
using Binary_Project_Structure_DataAccess.Interfaces;
using Binary_Project_Structure_DataAccess.Models;
using Ninject;

namespace Binary_Project_Structure_DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly IDataSource source;

        private FlightRepository flightRepository;

        public UnitOfWork()
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IDataSource>().To<DataSource>();
            source = ninjectKernel.Get<IDataSource>();
            this.source = source;
        }

        public IRepository<Flight> Flights
        {
            get
            {
                if (flightRepository == null)
                    flightRepository = new FlightRepository(source);
                return flightRepository;
            }
        }

        //public IRepository<Aircraft> Aircrafts
        //{
        //    get
        //    {
        //        return null;
        //    }
        //}
    }
}
