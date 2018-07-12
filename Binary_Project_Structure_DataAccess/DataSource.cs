using System;
using System.Collections.Generic;
using System.Text;
using Binary_Project_Structure_DataAccess.Models;

namespace Binary_Project_Structure_DataAccess
{
    public class DataSource : IDataSource
    {
        public List<Flight> Flights { get; set; }

        public List<Ticket> Tickets { get; set; }

        //public List<Stewardess> Stewardesses { get; private set; }

        //public List<Pilot> Pilots { get; private set; }

        //public List<Departure> Departures { get; private set; }

        //public List<Crew> Crews { get; private set; }

        //public List<TypeAircraft> TypeAircrafts { get; private set; }

        //public List<Aircraft> Aircrafts { get; private set; }

        public DataSource()
        {
            if (Flights == null)
            {
                GenerateFlights();
                GenerateTickets();
                //GenerateStewardess();
                //GeneratePilots();
                //GenerateCrews();
                //GenerateTypeAircrafts();
                //GenerateAircrafts();

                //GenerateDepartures();
            }
        }

        public void GenerateFlights()
        {
            Flights = new List<Flight>();

            Flights.AddRange(new Flight[] { new Flight()
            {
                Id = 1,
                DeparturePoint = "Kiev",
                ArrivalPoint = "Berlin",
                DepartureTime = new TimeSpan(4, 46, 0),
                ArrivalTime = new TimeSpan(10, 29, 0),
            },
            new Flight()
            {
                Id = 2,
                DeparturePoint = "Kiev",
                ArrivalPoint = "Riga",
                DepartureTime = new TimeSpan(11, 30, 0),
                ArrivalTime = new TimeSpan(8, 05, 0),
            },
            new Flight()
            {
                Id = 3,
                DeparturePoint = "Kiev",
                ArrivalPoint = "Brussels",
                DepartureTime = new TimeSpan(05, 48, 0),
                ArrivalTime = new TimeSpan(3, 15, 0),
            }
            });
        }

        public void GenerateTickets()
        {
            Tickets = new List<Ticket>(); 
            Tickets.AddRange(new Ticket[] {
                new Ticket()
                {
                    Id = 1,
                    Price = 200,
                    FlightId = 1,
                },
                new Ticket()
                {
                    Id = 2,
                    Price = 300,
                    FlightId = 2,
                },
                new Ticket()
                {
                    Id = 2,
                    Price = 400,
                    FlightId = 3,
                }
            });
        }

        //public void GenerateStewardess()
        //{
        //    Stewardesses.AddRange(new Stewardess[] {
        //        new Stewardess()
        //    {
        //            Id = 1,
        //            Name = "Natali",
        //            Surname = "Sidorova",
        //            DateBirth = new DateTime(1990, 12, 4)
        //    },
        //         new Stewardess()
        //    {
        //            Id = 2,
        //            Name = "Kate",
        //            Surname = "Petrova",
        //            DateBirth = new DateTime(1995, 5, 15)
        //    },
        //         new Stewardess()
        //    {
        //            Id = 3,
        //            Name = "Tanya",
        //            Surname = "Durova",
        //            DateBirth = new DateTime(1993, 7, 26)
        //    }
        //    });
        //}

        //public void GeneratePilots()
        //{
        //    Pilots.AddRange(new Pilot[] {
        //        new Pilot()
        //    {
        //            Id = 1,
        //            Name = "Ivan",
        //            Surname = "Ivanov",
        //            DateBirth = new DateTime(1990, 12, 4),
        //            Experience = 5
        //    },
        //         new Pilot()
        //    {
        //            Id = 2,
        //            Name = "Petr",
        //            Surname = "Petrov",
        //            DateBirth = new DateTime(1995, 5, 15),
        //            Experience = 10
        //    },
        //         new Pilot()
        //    {
        //            Id = 3,
        //            Name = "Sidr",
        //            Surname = "Sidorov",
        //            DateBirth = new DateTime(1993, 7, 26),
        //            Experience = 7
        //    }
        //    });
        //}

        //public void GenerateCrews()
        //{
        //    Crews.AddRange(new Crew[] {
        //        new Crew()
        //        {
        //            Id = 1,
        //            PilotId = 1,
        //            Stewardesses = this.Stewardesses
        //        },
        //        new Crew()
        //        {
        //            Id = 2,
        //            PilotId = 2,
        //            Stewardesses = this.Stewardesses
        //        },
        //        new Crew()
        //        {
        //            Id = 3,
        //            PilotId = 3,
        //            Stewardesses = this.Stewardesses
        //        }
        //    });
        //}

        //public void GenerateTypeAircrafts()
        //{
        //    TypeAircrafts.AddRange(new TypeAircraft[] {
        //        new TypeAircraft()
        //        {
        //            Id = 1,
        //            AircraftModel = AircraftModel.IL_96_300,
        //            NumberPlaces = 797,
        //            CarryingCapacity = 240000

        //        },
        //        new TypeAircraft()
        //        {
        //            Id = 2,
        //            AircraftModel = AircraftModel.Airbus_A310,
        //            NumberPlaces = 183,
        //            CarryingCapacity = 164000
        //        }
        //    });
        //}

        //public void GenerateAircrafts()
        //{
        //    Aircrafts.AddRange(new Aircraft[]
        //    {
        //        new Aircraft()
        //        {
        //            Id = 1,
        //            TypeAircraftId = 1,
        //            AircraftName = "Star",
        //            DateRelease = new DateTime(1998, 05, 12),
        //            Lifetime = new TimeSpan(1000, 0, 0, 0)
        //        },
        //        new Aircraft()
        //        {
        //            Id = 2,
        //            TypeAircraftId = 2,
        //            AircraftName = "Cometa",
        //            DateRelease = new DateTime(1991, 10, 03),
        //            Lifetime = new TimeSpan(2500, 0, 0, 0)
        //        }
        //    });
        //}

        //public void GenerateDepartures()
        //{
        //    Departures.AddRange(new Departure[] {
        //        new Departure()
        //        {
        //            Id = 1,
        //            AircraftId = 1,
        //            CrewId = 1,
        //            FlightId = 1,
        //            DepartureTime = new DateTime(2018, 07, 13)
        //        },
        //        new Departure()
        //        {
        //            Id = 2,
        //            AircraftId = 2,
        //            CrewId = 2,
        //            FlightId = 2,
        //            DepartureTime = new DateTime(2018, 07, 15)
        //        },
        //        new Departure()
        //        {
        //            Id = 3,
        //            AircraftId = 1,
        //            CrewId = 3,
        //            FlightId = 3,
        //            DepartureTime = new DateTime(2018, 07, 14)
        //        },
        //    });
        //}

    }
}
