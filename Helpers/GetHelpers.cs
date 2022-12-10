using CurWork.DAL.Context;
using CurWork.DAL.Entities;
using CurWork.Properties;
using Microsoft.IdentityModel.Tokens;

namespace CurWork.Helpers
{
    public class GetHelpers  : IGet<Movie> 
    {
        public Movie Get(Movie movie)
        {
           using(TicketsalesmanagerContext context = new())
            {
                Console.WriteLine("Введите название фильма");
                string movieName = Console.ReadLine();
                var  movies = context.Movies.Where(t=> t.Moviename == movieName);
                if (movies.IsNullOrEmpty())
                {
                    throw new Exception(Resources.ExceptionMovieNotDatabase);
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

        //public Customer Get(Customer customer )
        //{
        //    using (TicketsalesmanagerContext context = new())
        //    {
        //        var selectedCustomer = context.Customers.Where(t => t.Name == customer.Name 
        //                                                   & t.Surname==customer.Surname 
        //                                                   & t.Age == customer.Age)
        //                                         .FirstOrDefault();
               
               
        //        return selectedCustomer;
        //    }
        //}

        
    }
}
