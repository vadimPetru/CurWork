using CurWork.DAL.Context;
using CurWork.DAL.Entities;
using CurWork.Helpers;

namespace CurWork.TypeForm

{
    public class FormRegistration : Helper
    {
        private readonly Helper _helper = new();
        private  Customer _customer;
        public FormRegistration()
        {
            _customer = new Customer();
        }

        public void AddDataBase()
        {
            using (TicketsalesmanagerContext context = new())
            {
                _customer = _helper.CheackUser(_helper.InputDate(new Customer()));

               
                context.Customers.Add(_customer);
                context.SaveChanges();

            }

        }

    }
}
