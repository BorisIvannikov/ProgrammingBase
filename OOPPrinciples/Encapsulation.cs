using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    /// <summary>
    /// Инкапсуляция.
    /// Скрытие внутреннего состояния и функций объекта и предоставление доступа только через открытый набор функций.
    /// </summary>
    internal class Encapsulation
    {
    }

    public class Detail
    {
        private readonly string _name;
        public Factory Factory { get; }
        public string Name => $"Деталь: {_name} создана на {Factory.Name} ";
        public Detail(Factory factory, string name)
        {
            Factory = factory;
            _name = name;
        }

    }

    public class Factory
    {
        public string Name { get; }
        public Factory(string name) => Name = name;
        
    }

}
