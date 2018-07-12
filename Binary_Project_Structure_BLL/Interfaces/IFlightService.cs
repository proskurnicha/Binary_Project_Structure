using System;
using System.Collections.Generic;
using System.Text;
using Binary_Project_Structure_Shared.DTOs; 

namespace Binary_Project_Structure_BLL.Interfaces
{
    public interface IFlightService
    {
        List<FlightDto> GetFlights();
        FlightDto GetFlightById(int id);
        void Update(FlightDto flightDto);
        void Create(FlightDto flightDto);
        void Delete(int id);
    }
}
