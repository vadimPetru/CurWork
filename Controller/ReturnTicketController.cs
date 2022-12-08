﻿using CurWork.DAL.Context;
using CurWork.DAL.Entities;
using CurWork.Helpers;
using CurWork.TypeOFValidations;


namespace CurWork.Controller
{
    public delegate void ReturnHendler(Customer currentCustomer);
    public  class ReturnTicketController : ITicket
    {
        public event ReturnHendler returning;
        public BuyHendler buying;
        private GetHelpers _get;
        private MoviesList _list;
        public ReturnTicketController(ValidationString validation)
        {
            
            _get = new GetHelpers(validation);
            _list = new();
        }
       
        public void OnRegistration(Customer currentCustomer)
        {
            returning += Ticket;
            returning?.Invoke(currentCustomer);
        }

        public void UnRegistration()
        {
            returning -= Ticket;
        }
        public void Ticket(Customer currentCustomer)
        {
            _list.GetRecords();
            var selectedMovie = _get.Get(new Movie());
            var selectedCustomer = _get.Get(currentCustomer);
            
            using (TicketsalesmanagerContext context = new())
            {
                var selectedRecord = context.Charterclients.Where(t => t.Customerid == selectedCustomer.Id & t.Movieid == selectedMovie.Id).FirstOrDefault();

                context.Charterclients.Remove(selectedRecord);
                context.SaveChanges();
            }
        }

        
    } 
}
