using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Project_Structure_DataAccess.Models
{
    class TypeAircraft
    {
        public int Id { get; set; }

        public AircraftModel AircraftModel { get; set; }

        public int NumberPlaces { get; set; }

        public int CarryingCapacity { get; set; }
    }
}
