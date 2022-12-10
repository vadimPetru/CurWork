using CurWork.DAL.Entities;

namespace CurWork
{
    public interface IGet<T>
    {
        public  T Get(T movie);

    }
}
