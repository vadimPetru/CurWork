using CurWork.Items;
using CurWork.Properties;
using CurWork.Menu;
using Microsoft.Identity.Client;
using CurWork.DAL.Entities;

namespace CurWork.Controller
{
    public class MenuController 
    {
        MenuObject _menu;
        static List<ITicket> _items = new List<ITicket>
        {
            new BuyTicketController(), // Покупка билетов
            new ReturnTicketController(),
            
        };
       
        public MenuController()
        {
            _menu = new(Resources.buyTicket, Resources.returnTicket, Resources.Exit);
        }
       
        public void LogicsMenu()
        {

            Console.WriteLine(_menu);
            int input = int.Parse(Console.ReadLine());
            var result = Logics(input);
            
        }

        private static ITicket Logics(int item) =>_items[item - 1].Ticket();
    }
}
