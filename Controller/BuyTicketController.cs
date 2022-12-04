using CurWork.Helpers;
using CurWork.DAL.Entities;
using CurWork.DAL.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.IdentityModel.Tokens;

namespace CurWork.Controller
{
    public class BuyTicketController  : GetHelpers , ITicket
    {
        GetHelpers get = new();
        MoviesList list = new();
        public void Ticket(Customer currentCustomer)
        {
            
            list.GetRecords();
            var selectedMovie =  get.Get(Console.ReadLine(),new Movie());
            using(TicketsalesmanagerContext context = new())
            {
                context.Charterclients.Add(new Charterclient() { Customerid = currentCustomer.Id, Movieid = selectedMovie.Id });
                context.SaveChanges();
            }
        }

       
    }
}
