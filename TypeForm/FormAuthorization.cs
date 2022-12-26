using CurWork.DAL.Entities;


namespace CurWork.TypeForm.Form
{
    public class FormAuthorization :  IOnCheack
    {

        DbManager manager = new();
        public Customer Customer { get; private set; }
       
        public Customer OnCheack()
        {
            return manager.Authorization(Customer);
        }

    }
}
