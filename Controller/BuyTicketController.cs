using CurWork.DAL.Entities;
using CurWork.DAL.Context;

namespace CurWork.Controller
{
    public delegate void BuyHendler(Customer currentCustomer);
    
    public class BuyTicketController  : ITicket
    {
        
        private event BuyHendler BuyTicket;
        private readonly DbManager _manager;
        
        public BuyTicketController() 
        {
            _manager = new DbManager();
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
            _manager.BuyTicket(currentCustomer);
        }

        


    }
}
