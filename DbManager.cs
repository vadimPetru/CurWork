using CurWork.DAL.Context;
using CurWork.DAL.Entities;
using CurWork.Properties;
using CurWork.TypeForm;

namespace CurWork
{
    public class DbManager : Forms
    {
      

        private int ATTEMPS;

        public Customer Authorization(Customer Customer)
        {

            using (TicketsalesmanagerContext context = new())
            {
                for (ATTEMPS = Convert.ToInt32(Resources.Three); ATTEMPS > Convert.ToInt32(Resources.Zero); ATTEMPS--)
                {
                    Console.Clear();
                    if (ATTEMPS < Convert.ToInt32(Resources.Three)) Console.WriteLine($"Попробуй еще раз, осталось {ATTEMPS} попыток.");
                    Customer = CheackUser(CreateCustomer(new Customer()));
                    if (Customer != null)
                    {
                        return Customer;
                    }

                }
                throw new Exception(Resources.ExceptionUserNotDatabase);
            }
        }

        public Customer Registration(Customer customer)
        {
            using (TicketsalesmanagerContext context = new())
            {
                do
                {
                    customer = CreateCustomer(new Customer());
                    if (context.Customers.Where(item => item.Name == customer.Name
                                                  & item.Surname == customer.Surname
                                                  & item.Age == customer.Age).FirstOrDefault() == null)
                    {
                        context.Customers.Add(customer);
                        break;
                    }
                    Console.WriteLine(Resources.ExceptionUserNotDatabase);
                } while (true);

                context.SaveChanges();

            }
            return customer;
        }

        public void GetRecords()
        {
            using (TicketsalesmanagerContext context = new())
            {
                try
                {
                    var list = context.Movies.Where(item => item.Moviename != null).ToList();

                    foreach (var item in list)
                    {
                        Console.WriteLine($"Название фильма:{item.Moviename} , Жанр:{item.Genre} , Дата{item.DateOfRelease}") ;
                    }
                }
                catch (NullReferenceException)
                {
                    throw new Exception("Простите но сейчас нету фильмов для показа");
                }
            }

        }  // Вывод всех фильмов в пракате

        public void ReturnTicket(Customer currentCustomer)
        {
            var selectedMovie = GetMovie(new Movie());

            using (TicketsalesmanagerContext context = new())
            {
                var selectedRecord = context.Charterclients.Where(t => t.Customerid == currentCustomer.Id & t.Movieid == selectedMovie.Id).FirstOrDefault();

                context.Charterclients.Remove(selectedRecord);
                context.SaveChanges();
            }
        } // Возврат билета

        public void BuyTicket(Customer currentCustomer)
        {

            var selectedMovie = GetMovie(new Movie());
            using (TicketsalesmanagerContext context = new())
            {
                context.Charterclients.Add(new Charterclient() { Customerid = currentCustomer.Id, Movieid = selectedMovie.Id });
                context.SaveChanges();
            }
        }  // Покупка билета

        public Customer CheackUser(Customer customer) // Проверка есть ли такой пользователь в базе
        {
            using (TicketsalesmanagerContext context = new())
            {


                var User = context.Customers.Where(item => item.Name == customer.Name
                                                 & item.Surname == customer.Surname
                                                 & item.Age == customer.Age).FirstOrDefault();



                return User;


            }
        }


        public Movie GetMovie(Movie movie)
        {

            using (TicketsalesmanagerContext context = new())
            {
                do
                {
                    GetRecords();
                    Console.WriteLine("Введите название фильма");
                    string movieName = Console.ReadLine();

                    if (context.Movies.Where(t => t.Moviename == movieName).FirstOrDefault() != null)
                    {
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine(Resources.ExceptionMovieNotDatabase);
                } while (true);


                return movie;
            }
        } // Получаем фильм из бызы 

    }
}
