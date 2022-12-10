using CurWork.Properties;
using CurWork.Menu;
using CurWork.DAL.Entities;
using CurWork.TypeOFValidations;

namespace CurWork.Controller
{
    public class MenuController  
    {
        private readonly BuyTicketController _buying;
        private readonly ReturnTicketController _returning;
        private readonly MenuObject _menu;
        List<ITicket> tickets = new();
        

        private IEnumerable<ITicket> Add()
        {
            tickets.Add(_buying);
            tickets.Add(_returning);
            return tickets;
        }

        public MenuController() 
        {
            _menu = new(Resources.buyTicket, Resources.returnTicket);
            _buying = new BuyTicketController();
            _returning = new();
        }


        
        public void LogicsMenu(Customer currentCustomer)
        {
           
            Console.WriteLine(_menu);
            int input = int.Parse(Console.ReadLine());
            tickets = (List<ITicket>)Add();
            tickets[input-1].OnRegistration(currentCustomer);
            tickets[input-1].UnRegistration();




            //if (input == 1)
            //{
            //    _buying.OnRegistration(currentCustomer);

            //    _buying.UnRegistration();
            //}
            //if (input == 2)
            //{
            //    _returning.OnRegistration(currentCustomer);

            //    _returning.UnRegistration();
            //}


        }

        
    }
}
