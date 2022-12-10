using CurWork.DAL.Context;
using CurWork.DAL.Entities;
using CurWork.Properties;
using CurWork.TypeForm;
using CurWork.TypeOFValidations;

namespace CurWork.Helpers
{
    public class Helper : Forms, IVerification
    {
       

        public Customer CheackUser(Customer customer) // Проверка есть ли такой пользователь в базе
        {
            using (TicketsalesmanagerContext context = new())
            {
                var User = context.Customers.Where(item => item.Name == customer.Name
                                                    & item.Surname == customer.Surname
                                                    & item.Age == customer.Age).FirstOrDefault();
                if(User == null)
                {
                    throw new Exception(Resources.ExceptionUserNotDatabase);
                }
                return User;
                   
            }
        }

   
    }
}
