using CurWork.DAL.Context;
using CurWork.DAL.Entities;
using CurWork.Helpers;

namespace CurWork.TypeForm.Form
{
    public class FormAuthorization : Forms
    {
        private Helper _helper = new();
        Customer _customer = new();
        public Customer onCheak()
        {
            using (TicketsalesmanagerContext context = new())
            {

                return _customer = _helper.CheackUser(_helper.InputDate(new Customer()));

            }
        }

    }
}
