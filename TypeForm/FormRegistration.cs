using CurWork.DAL.Context;
using CurWork.DAL.Entities;
using CurWork.Helpers;
using CurWork.Properties;
using CurWork.TypeOFValidations;
using System.Data;

namespace CurWork.TypeForm

{
    public class FormRegistration : Helper
    {
        static ValidationString validation = new();
        private readonly Helper _helper = new(validation);
        private  Customer _customer;
        public FormRegistration(ValidationString validation) : base(validation)
        {
            _customer = new Customer();
        }

        public Customer AddDataBase() // A user adds in the database 
        {
            using (TicketsalesmanagerContext context = new())
            {
                _customer = _helper.InputDate(new Customer());
                if (context.Customers.Where(item => item.Name == _customer.Name
                                                    & item.Surname == _customer.Surname
                                                    & item.Age == _customer.Age).FirstOrDefault() == null)
                {
                    context.Customers.Add(_customer);
                }
                else
                {
                    throw new Exception(Resources.ExceptionUserDatabase);
                }
                
               
               
                context.SaveChanges();

            }
            return _customer;

        }

    }
}
