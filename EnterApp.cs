using CurWork.TypeForm;
using CurWork.TypeForm.Form;
using CurWork.DAL.Entities;
using CurWork.Helpers;
using CurWork.AbstractClasses;

namespace CurWork
{

    public class EnterApp : ValidationHelper, IHint
    {
        //delegate Action DelegateAction();
        FormRegistration formRegistration;
        FormAuthorization formAuthorization;
        public string Message { get; set; }
        public ChoisenHelper choisenHelper { get; private set; }
        public EnterApp()
        {
            formRegistration = new();
            formAuthorization = new();
            Message = isValid();
        }

        private void OnRegistration()
        {
            formRegistration.InputDate(new Customer());
        }

        private void OnAuthorization()
        {
            formAuthorization.InputDate(new Customer());
        }
        public void GetHint(string message)
        {
            Console.WriteLine(message); ;
        }

        public void MakeAChoice()
        {
            if (Message == nameof(Behaviour.Да))
            {
                OnAuthorization();
            }
            else if (Message == nameof(Behaviour.Нет))
            {
                OnRegistration();
            }
            else
            {
                throw new Exception("Вводим только Да или Нет");
            }
        }
    }
}
