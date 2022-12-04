using CurWork.AbstractClasses;
using CurWork.DAL.Entities;
using CurWork.Properties;


namespace CurWork.TypeForm
{
    public abstract class Forms : ValidationHelper , IUserInput
    {
        public virtual Customer InputDate(Customer customer)
        {
            Initialize(customer.Name, Resources.InputName);
            Initialize(customer.Surname, Resources.InputSurname);
            Initialize(customer.Age, Resources.InputSurname);
            return customer;
            
        }

        public  void Initialize( object Value,string Request)
        {
            Console.WriteLine(Request);
            Value = isValid();
        }
    }
}
