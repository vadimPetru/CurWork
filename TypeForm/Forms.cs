using CurWork.DAL.Entities;
using CurWork.Properties;
using CurWork.TypeOFValidations;
using FluentValidation.Results;

namespace CurWork.TypeForm
{
    public abstract class Forms 
    {
        public virtual Customer CreateCustomer(Customer customer) // Создаем пользователя , и проверяем валидацию данных
        {
            
                ValidatorCustomer _validaotor = new();
                ValidationResult _resualt;
            do
            {
                customer = Initialize(customer);
                _resualt = _validaotor.Validate(customer);
                if (_resualt.IsValid)
                    break;
                Console.WriteLine(Resources.ExceptionUnvalidRecord);
            } while (!_resualt.IsValid);
            return customer;
        }

        private string InputDate(string request) /// Вводим запрос
        {
            Console.WriteLine(request);
            string value = Console.ReadLine();
            return value;
        } 
        private Customer Initialize(Customer customer) // Инициализируем поля
        {
            customer.Name = InputDate(Resources.InputName);
            customer.Surname = InputDate(Resources.InputSurname);
            customer.Age = int.Parse(InputDate(Resources.InputAge));

            return customer;
        }

        
    }
}
