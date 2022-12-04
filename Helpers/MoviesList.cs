using CurWork.DAL.Context;

namespace CurWork.Helpers
{
    public   class MoviesList
    {
        public void GetRecords()
        {
            using (TicketsalesmanagerContext context = new())
            {
                var list = context.Movies.Where(item => item.Moviename != null).ToList();

                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("Введите название фильма:");
        }
    }
}
