using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Binary_Project_Structure_Shared.DTOs
{
    public class FlightDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string DeparturePoint { get; set; }

        [Required]
        public TimeSpan DepartureTime { get; set; }

        [Required]
        public string ArrivalPoint { get; set; }

        [Required]
        public TimeSpan ArrivalTime { get; set; }

        public List<TicketDto> Tickets { get; set; }
    }
}
