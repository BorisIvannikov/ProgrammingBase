using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    /// <summary>
    /// Interface Segregation Principle - Принцип разделения интерфейсов
    /// Клиенты не должны вынужденно зависеть от методов, которыми не пользуются.
    /// </summary>
    internal class I
    {
    }

    public interface IBaseRepository
    {
        public void Create();
        public void Read();
        public void Update();
        public void Delete();

        //нарушение принципа
        public void GetUser(int id);
    }

    public class ProductRepository : IBaseRepository
    {
        public void Create() { }
        public void Delete() { }
        public void Read() { }
        public void Update() { }
        //эти методы тут не нужны 
        public void GetUser(int id) { }
    }

    public class UserRepository : IBaseRepository
    {
        public void Create() { }
        public void Delete() { }
        // а тут этот метод уместен
        public void GetUser(int id) { }
        public void Read() { }
        public void Update() { }
    }
}
