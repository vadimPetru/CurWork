using CurWork.DAL.Entities;
using CurWork.Properties;
using CurWork.TypeOFValidations;


namespace CurWork.TypeForm
{
    public abstract class Forms 
    {
        public virtual Customer CreateCustomer(Customer customer)
        {
            ValidatorCustomer _validaotor = new();
            customer = Initialize(customer);
            var resualt = _validaotor.Validate(customer);
            if (resualt.IsValid)
                return customer;
            else
               throw new Exception(Resources.ExceptionUnvalidRecord);
        }

        private string InputDate(string request)
        {
            Console.WriteLine(request);
            string value = Console.ReadLine();
            return value;
        } 
        private Customer Initialize(Customer customer)
        {
            customer.Name = InputDate(Resources.InputName);
            customer.Surname = InputDate(Resources.InputSurname);
            customer.Age = int.Parse(InputDate(Resources.InputAge));

            return customer;
        }

        
    }
}
