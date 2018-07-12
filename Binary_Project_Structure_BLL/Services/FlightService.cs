﻿using System;
using System.Collections.Generic;
using System.Text;
using Binary_Project_Structure_BLL.Interfaces;
using Binary_Project_Structure_DataAccess.Interfaces;
using Binary_Project_Structure_Shared.DTOs;
using Binary_Project_Structure_DataAccess.Models;
using AutoMapper;
using Ninject;
using Binary_Project_Structure_DataAccess.UnitOfWork;

namespace Binary_Project_Structure_BLL.Services
{
    public class FlightService : IFlightService
    {
        public IUnitOfWork context { get; private set; }

        public FlightService()
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            context = ninjectKernel.Get<IUnitOfWork>();
            Mapper.Initialize(cfg => cfg.CreateMap<Flight, FlightDto>());
        }

        public List<FlightDto> GetFlights()
        {
            return Mapper.Map<List<Flight>, List<FlightDto>>(context.Flights.Get());
        }

        public FlightDto GetFlightById(int id)
        {
            return Mapper.Map<Flight, FlightDto>(context.Flights.GetById(id));
        }

        public void Update(FlightDto flightDto)
        {
            Flight flight = Mapper.Map<FlightDto, Flight>(flightDto);
            context.Flights.Update(flight);
        }

        public void Create(FlightDto flightDto)
        {
            Flight flight = Mapper.Map<FlightDto, Flight>(flightDto);
            context.Flights.Create(flight);
        }

        public bool Delete(int id)
        {
            return context.Flights.Delete(id);
        }
    }
}
