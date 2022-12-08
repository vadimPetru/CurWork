using CurWork.Properties;
using CurWork.Menu;
using CurWork.DAL.Entities;
using CurWork.TypeOFValidations;

namespace CurWork.Controller
{
    public class MenuController  
    {
        private readonly BuyTicketController buying;
        private readonly ReturnTicketController returning;
        private readonly MenuObject _menu;
       
        public MenuController(ValidationString validation) 
        {
            _menu = new(Resources.buyTicket, Resources.returnTicket);
            buying = new BuyTicketController(validation);
            returning = new(validation);
        }

        public void LogicsMenu(Customer currentCustomer)
        {

            Console.WriteLine(_menu);
            int input = int.Parse(Console.ReadLine());
            if(input == 1)
            {
                buying.OnRegistration(currentCustomer);
                
                buying.UnRegistration();
            }
            if(input == 2)
            {
                returning.OnRegistration(currentCustomer);

                returning.UnRegistration();
            }
            
           
        }

        
    }
}
