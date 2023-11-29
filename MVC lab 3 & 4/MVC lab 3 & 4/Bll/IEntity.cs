using MVC_lab_3___4.Models;

namespace MVC_lab_3___4.Bll
{
    public interface IEntity<T> where T : class
    {
        public List<T> getall();
        public T getbyid(int id);
        public void add(T s);
        public void deletebyid(int id);
        public void update(T s);


    }
}
