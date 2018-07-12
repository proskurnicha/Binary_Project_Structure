using Binary_Project_Structure_DataAccess.Models;
using Binary_Project_Structure_Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Project_Structure_BLL.Interfaces
{
    public interface ITicketService
    {
        List<TicketDto> GetAll();
        TicketDto GetById(int id);
        void Update(TicketDto flightDto);
        void Create(TicketDto flightDto);
        bool Delete(int id);
    }
}

