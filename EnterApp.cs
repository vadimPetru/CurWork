using CurWork.TypeForm;
using CurWork.TypeForm.Form;
using CurWork.DAL.Entities;
using CurWork.Properties;
using CurWork.Menu;

namespace CurWork
{

    public class EnterApp 
    {

        private readonly FormRegistration _formRegistration;
        private readonly FormAuthorization _formAuthorization;
        private readonly MenuObject choiceMenu;


        public EnterApp() 
        {
            _formRegistration = new();
            _formAuthorization = new();
            choiceMenu = new(Resources.Yes,Resources.No);
        }

       
        public Customer MakeAChoice() // TODO:
        {
            Console.WriteLine(Resources.Registraion);
            Console.WriteLine(choiceMenu);
            var index = int.Parse(Console.ReadLine());

            List<IOnCheack> forms = new List<IOnCheack>
            {
                _formAuthorization,
                _formRegistration
                
            };

            return forms[index-1].OnCheack();

        }
    }
}
