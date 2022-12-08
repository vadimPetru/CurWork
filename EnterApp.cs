using CurWork.TypeForm;
using CurWork.TypeForm.Form;
using CurWork.DAL.Entities;
using CurWork.Properties;
using CurWork.TypeOFValidations;

namespace CurWork
{

    public class EnterApp : ValidationYesNo
    {

        private readonly FormRegistration _formRegistration;
        private readonly FormAuthorization _formAuthorization;
        private ValidationYesNo _yesNo;
        public string? Message { get; set; }

        public EnterApp(ValidationString validation) : base()
        {
            _formRegistration = new(validation);
            _formAuthorization = new(validation);
            _yesNo = new();
            Message = _yesNo.IsValid("Enter Yes or No");
        }
       



        private Customer OnRegistration()
        {
            
           return _formRegistration.AddDataBase();
        }

        private Customer OnAuthorization()
        {
            return _formAuthorization.onCheak();
        }


        public Customer MakeAChoice()
        {
            if (Message == nameof(Behaviour.YES))
            {
                return OnAuthorization();
            }
            else if (Message == nameof(Behaviour.NO))
            {
                return OnRegistration();
            }
            else
            {
                throw new Exception(Resources.ExceptionYesOrNot);
            }
            
            

        }
    }
}
