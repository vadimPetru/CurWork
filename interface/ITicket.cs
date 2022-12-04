using CurWork.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurWork
{
    public interface ITicket
    {
        public void Ticket(Customer currentCustomer);
    }
}
