using CurWork.Properties;
using CurWork.Menu;
using CurWork.DAL.Entities;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;

namespace CurWork.Controller
{

    public class MenuController  
    {
        private readonly BuyTicketController _buying;
        private readonly ReturnTicketController _returning;
        private readonly MenuObject _menu;
        List<ITicket> tickets = new();
        private int _input;



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
            do
            {
                Console.Clear();
                Console.WriteLine(_menu);
                    _input = int.Parse(Console.ReadLine());
            }
            while (_input <= Convert.ToInt32(Resources.Zero) & _input >= tickets.Count);
            tickets = (List<ITicket>)Add();
            tickets[_input-1].OnRegistration(currentCustomer);
            tickets[_input-1].UnRegistration();

        }

        
     
        
    }
}
