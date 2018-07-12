using AutoMapper;
using Binary_Project_Structure_BLL.Interfaces;
using Binary_Project_Structure_DataAccess.Interfaces;
using Binary_Project_Structure_DataAccess.Models;
using Binary_Project_Structure_DataAccess.UnitOfWork;
using Binary_Project_Structure_Shared.DTOs;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Project_Structure_BLL.Services
{
    public class TicketService 
    {
        public IUnitOfWork context { get; private set; }
        IMapper iMapper;
        public TicketService()
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            context = ninjectKernel.Get<IUnitOfWork>();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Ticket, TicketDto>();
            });
            iMapper = config.CreateMapper();
        }

        public List<TicketDto> GetAll()
        {
            return iMapper.Map<List<Ticket>, List<TicketDto>>(context.Tickets.GetAll());
        }

        public TicketDto GetById(int id)
        {
            return iMapper.Map<Ticket, TicketDto>(context.Tickets.GetById(x => x.Id == id));
        }

        public void Update(TicketDto TicketDto)
        {
            Ticket Ticket = iMapper.Map<TicketDto, Ticket>(TicketDto);
            context.Tickets.Update(Ticket);
        }

        public void Create(TicketDto TicketDto)
        {
            Ticket Ticket = iMapper.Map<TicketDto, Ticket>(TicketDto);
            context.Tickets.Create(Ticket);
        }

        public bool Delete(int id)
        {
            return context.Tickets.Delete(x => x.Id == id);
        }

    }
}
