using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPPrinciples
{
    /// <summary>
    /// Наследование.
    /// Возможность создания новых абстракций на основе существующих.
    /// Получение функциональности дочерним классом своего родительского класса или интерфейса
    /// </summary>
    internal class Inheritance
    {
    }

    public abstract class Animal
    {
        public string Name { get; }
        public string Habitat { get; }

        protected Animal(string name, string habitat)
        {
            Name = name;
            Habitat = habitat;
        }

        public void Eat() { }
    }

    public interface ISound
    {
        public string MakeSound();
    }

    public class Dog : Animal, ISound
    {
        public Dog(string name, string habitat) : base(name, habitat)
        {
        }   
        public string MakeSound() => "gav";
    }
}
