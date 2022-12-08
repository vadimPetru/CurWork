using CurWork.DAL.Context;
using CurWork.DAL.Entities;
using CurWork.TypeForm;
using CurWork.TypeForm.Form;
using CurWork.TypeOFValidations;
using Microsoft.IdentityModel.Tokens;

namespace CurWork.Helpers
{
    public class GetHelpers  : IGet<Movie> , IGet<Customer> 
    {
        private readonly FormRegistration _formRegistration;
        private readonly FormAuthorization _formAuthorization;
        public GetHelpers(ValidationString validation) 
        {
            _formAuthorization = new(validation);
            _formRegistration = new(validation);
        }

        
        
        public Movie Get(Movie movie)
        {
           using(TicketsalesmanagerContext context = new())
            {
                Console.WriteLine("Введите название фильма");
                string movieName = Console.ReadLine();
                var  movies = context.Movies.Where(t=> t.Moviename == movieName);
                if (movies.IsNullOrEmpty())
                {
                   
                    Get(movie);
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

        public Customer Get(Customer customer )
        {
            using (TicketsalesmanagerContext context = new())
            {
                var selectedCustomer = context.Customers.Where(t => t.Name == customer.Name 
                                                           & t.Surname==customer.Surname 
                                                           & t.Age == customer.Age)
                                                 .FirstOrDefault();
               
               
                return selectedCustomer;
            }
        }

        
    }
}
