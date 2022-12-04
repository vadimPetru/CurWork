using CurWork.DAL.Context;
using CurWork.DAL.Entities;
using CurWork.TypeForm;
using CurWork.TypeForm.Form;
using Microsoft.IdentityModel.Tokens;

namespace CurWork.Helpers
{
    public class GetHelpers : IGet<Movie> , IGet<Customer> 
    {
        FormAuthorization FormAuthorization = new();
        FormRegistration FormRegistration = new();
        public Movie Get(string movieName , Movie movie)
        {
           using(TicketsalesmanagerContext context = new())
            {
               var  movies = context.Movies.Where(t=> t.Moviename == movieName);
                if (movies.IsNullOrEmpty())
                {
                    Console.WriteLine("Введите название фильма");
                    Get(Console.ReadLine(), movie);
                }
                else
                {
                    foreach (var item in movies)
                    {
                        movie = item;
                    }
                }
             
                return movie;
            }
        }

        public Customer Get(string customerID, Customer customer )
        {
            using (TicketsalesmanagerContext context = new())
            {
                var customers = context.Customers.Where(t => t.Id == int.Parse(customerID));
                if (customers.IsNullOrEmpty())
                {
                    FormRegistration.AddDataBase();
                    Get(customerID, customer);
                }
                else
                {
                    foreach (var element in customers)
                    {
                        customer = element;
                    }
                    
                }
                return customer;
            }
        }

        
    }
}
