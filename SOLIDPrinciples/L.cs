using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    /// <summary>
    /// Liskov Substitution Principle - принцип подстановки Лисков
    /// Должна быть возможность вместо базового типа подставить любой его подтип.
    /// </summary>
    internal class L
    {
    }
    public class Car
    {
        protected int fuel;
        public string Name { get; set; }
        public virtual int Fuel
        {
            get => fuel;
            set
            {
                if (value < 0 && value > 50) { throw new Exception("недопустимое значение топлива"); }
                fuel = value;
            }
        }
    }

    public class LADA : Car
    {
        //нарушение принципа, по скольку не учитываюстя ограничения класса родителя
        public override int Fuel { get => base.Fuel; set => fuel = value; }
    }
}
