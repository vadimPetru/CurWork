using CurWork.Helpers;
using CurWork.DAL.Entities;
using CurWork.DAL.Context;
using CurWork.TypeOFValidations;

namespace CurWork.Controller
{
    public delegate void BuyHendler(Customer currentCustomer);
    
    public class BuyTicketController  : GetHelpers , ITicket
    {
        
        private event BuyHendler BuyTicket;
        private readonly GetHelpers _get;
        private readonly MoviesList _list;
        
        public BuyTicketController(ValidationString validation) : base(validation)
        {
           
            _get = new GetHelpers(validation);
            _list = new MoviesList();
        }

        public void OnRegistration(Customer currentCustomer)
        {
            BuyTicket += Ticket;
            BuyTicket?.Invoke(currentCustomer);
        }

        public void UnRegistration()
        {
            BuyTicket -= Ticket;
        }
        
        public void Ticket(Customer currentCustomer)
        {
            
            _list.GetRecords();
            var selectedMovie =  _get.Get(new Movie());
            var selectedCustomer = _get.Get(currentCustomer);
            using(TicketsalesmanagerContext context = new())
            {
                context.Charterclients.Add(new Charterclient() { Customerid = selectedCustomer.Id, Movieid = selectedMovie.Id });
                context.SaveChanges();
            }
            
        }

        


    }
}
