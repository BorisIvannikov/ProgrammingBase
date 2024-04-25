using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    /// <summary>
    /// Dependency Inversion Principle - Принцип инверсии зависимостей
    /// Модули верхнего уровня не должны зависеть от модулей нижнего уровня. И те и другие должны зависеть от абстракций.
    /// Абстракции не должны зависеть от деталей.Детали должны зависеть от абстракций.
    /// </summary>
    internal class D
    {
    }

    public class UserEntityRepository
    {
        private readonly AppDBContext db;

        public UserEntityRepository(AppDBContext db)
        {
            this.db = db;
        }

        public async Task<bool> Create(UserEntity entity)
        {
            await db.UserEntities.AddAsync(entity);
            await db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(UserEntity entity)
        {
            db.Remove(entity);
            await db.SaveChangesAsync();
            return true;
        }
    }

    /// <summary>
    /// представляет ресурс EntityFrameworkCore
    /// позволяет работать с БД, не зависимо от того какая это БД, 
    /// при изменении БД мне не нужно будет переписывать методы в UserEntityRepository
    /// </summary>
    public class AppDBContext
    {

    }
}
