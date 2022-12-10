using CurWork.DAL.Context;
using CurWork.DAL.Entities;
using CurWork.Helpers;
using CurWork.Properties;
using CurWork.TypeOFValidations;

namespace CurWork.TypeForm.Form
{
    public class FormAuthorization : Forms , IOnCheack
    {

        private readonly Helper _helper;
        public Customer Customer { get; private set; }
        public FormAuthorization() : base()
        {
            _helper = new();
           
        }
        
        public Customer OnCheack()
        {
            using (TicketsalesmanagerContext context = new())
            {

                 Customer = _helper.CheackUser(_helper.CreateCustomer(new Customer()));
               
                return Customer;
            }
        }

    }
}
