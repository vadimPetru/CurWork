using CurWork.DAL.Context;
using CurWork.DAL.Entities;
using CurWork.Helpers;
using CurWork.Properties;
using CurWork.TypeOFValidations;

namespace CurWork.TypeForm.Form
{
    public class FormAuthorization : Forms
    {

        private readonly Helper _helper;
        public Customer Customer { get; private set; }
        public FormAuthorization(ValidationString validation) : base(validation)
        {
            _helper = new(validation);
           
        }
        
        public Customer onCheak()
        {
            using (TicketsalesmanagerContext context = new())
            {

                 Customer = _helper.CheackUser(_helper.InputDate(new Customer()));
               
                return Customer;
            }
        }

    }
}
