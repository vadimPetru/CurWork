using CurWork.DAL.Context;
using CurWork.DAL.Entities;
using CurWork.Helpers;
using System.Collections.Generic;

namespace CurWork.Controller
{
    public  class ReturnTicketController : ITicket
    {
        GetHelpers get = new GetHelpers();
        MoviesList list = new();
        public void Ticket(Customer currentCustomer)
        {
            list.GetRecords();
            var selectedMovie = get.Get(Console.ReadLine(), new Movie());
            using (TicketsalesmanagerContext context = new())
            {
                context.Charterclients.Remove(new Charterclient() { Customerid = currentCustomer.Id, Movieid = selectedMovie.Id });
                context.SaveChanges();
            }
        }
    } 
}
