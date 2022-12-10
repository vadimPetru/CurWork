using CurWork.DAL.Context;
using CurWork.DAL.Entities;
using CurWork.Helpers;
using CurWork.Properties;
using System.Data;

namespace CurWork.TypeForm

{
    public class FormRegistration : Helper , IOnCheack
    {
        
        private readonly Helper _helper = new();
        private  Customer _customer;
        public FormRegistration() 
        {
            _customer = new Customer();
        }

        public Customer OnCheack() // A user adds in the database 
        {
            using (TicketsalesmanagerContext context = new())
            {
                _customer = _helper.CreateCustomer(new Customer());
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
