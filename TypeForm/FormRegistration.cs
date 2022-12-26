using CurWork.DAL.Context;
using CurWork.DAL.Entities;
using CurWork.Properties;
using System.Data;

namespace CurWork.TypeForm

{
    public class FormRegistration : IOnCheack
    {
        private  Customer _customer;
        private readonly DbManager _manager;
        public FormRegistration() 
        {
            _customer = new Customer();
            _manager = new DbManager();
        }
        public Customer OnCheack() // A user adds in the database 
        {

            return _manager.Registration(_customer);
        }

    }
}
