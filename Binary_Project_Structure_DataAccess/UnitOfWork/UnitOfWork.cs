using System;
using System.Collections.Generic;
using System.Text;
using Binary_Project_Structure_DataAccess.Repositories;
using Binary_Project_Structure_DataAccess.Interfaces;
using Binary_Project_Structure_DataAccess.Models;

namespace Binary_Project_Structure_DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private AircraftRepository aircraftRepository;

        private CrewRepository crewRepository;

        private DepartureRepositoty departureRepository;

        private FlightRepository flightRepository;

        private PilotRepository pilotRepository;

        private StewardessRepository stewardessRepository;
                
        private TicketRepository ticketRepository;

        private TypeAircraftRepository typeAircraftRepository;

        public IRepository<Aircraft> Aircrafts
        {
            get
            {
                if (aircraftRepository == null)
                    aircraftRepository = new AircraftRepository();
                return aircraftRepository;
            }
        }

        public IRepository<Crew> Crews
        {
            get
            {
                if (crewRepository == null)
                    crewRepository = new CrewRepository();
                return crewRepository;
            }
        }

        public IRepository<Departure> Departures
        {
            get
            {
                if (departureRepository == null)
                    departureRepository = new DepartureRepositoty();
                return departureRepository;
            }
        }

        public IRepository<Flight> Flights
        {
            get
            {
                if (flightRepository == null)
                    flightRepository = new FlightRepository();
                return flightRepository;
            }
        }

        public IRepository<Pilot> Pilots
        {
            get
            {
                if (pilotRepository == null)
                    pilotRepository = new PilotRepository();
                return pilotRepository;
            }
        }

        public IRepository<Stewardess> Stewardesses
        {
            get
            {
                if (stewardessRepository == null)
                    stewardessRepository = new StewardessRepository();
                return stewardessRepository;
            }
        }

        public IRepository<Ticket> Tickets
        {
            get
            {
                if (ticketRepository == null)
                    ticketRepository = new TicketRepository();
                return ticketRepository;
            }
        }

        public IRepository<TypeAircraft> TypesAircraft
        {
            get
            {
                if (typeAircraftRepository == null)
                    typeAircraftRepository = new TypeAircraftRepository();
                return typeAircraftRepository;
            }
        }
    }
}
