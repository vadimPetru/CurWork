
using CurWork.DAL.Entities;
using CurWork.Properties;
using CurWork.TypeOFValidations;

namespace CurWork.TypeForm
{
    public abstract class Forms : Validation
    {
        private readonly ValidationString _validation;

        protected Forms(ValidationString validation) 
        {
            _validation = validation;
        }

        public virtual Customer InputDate(Customer customer)
        {
            customer.Name = Initialize(customer.Name, Resources.InputName) ;
            customer.Surname = Initialize(customer.Surname, Resources.InputSurname);
            customer.Age= int.Parse(Initialize(customer.Age.ToString(), Resources.InputAge));
           
            return customer;
            
        }

        private string Initialize(string Value , string Request)
        {
            Console.WriteLine(Request);
            return Value = _validation.IsValid("UnValidRecord");
        }

        
    }
}
