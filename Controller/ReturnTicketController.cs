using CurWork.DAL.Context;
using CurWork.DAL.Entities;
using CurWork.TypeOFValidations;


namespace CurWork.Controller
{
    public delegate void ReturnHendler(Customer currentCustomer);
    public  class ReturnTicketController : ITicket
    {
        public event ReturnHendler returning;
        private readonly DbManager _manager;
   
        public ReturnTicketController()
        {
            _manager = new DbManager();
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

            _manager.ReturnTicket(currentCustomer);
        }

       
    } 
}
