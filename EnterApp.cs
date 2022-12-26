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
        private int _index;

        public EnterApp() 
        {
            _formRegistration = new();
            _formAuthorization = new();
            choiceMenu = new(Resources.Yes,Resources.No);
        }

       
        public Customer MakeAChoice() // TODO:
        {
            

            List<IOnCheack> forms = new List<IOnCheack>
            {
                _formAuthorization,
                _formRegistration

            };

            do
            {
                Console.Clear();
                Console.WriteLine(Resources.Registraion);
                Console.WriteLine(choiceMenu);
                _index = int.Parse(Console.ReadLine());

            } while (_index <= 0 | _index > forms.Count);
           

            

            return forms[_index - 1].OnCheack();

        }
    }
}
