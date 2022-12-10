using CurWork.DAL.Entities;


namespace CurWork
{
    public interface ITicket
    {
        public void Ticket(Customer currentCustomer);

        public void OnRegistration(Customer currentCustomer);

        public void UnRegistration();
    }
}
