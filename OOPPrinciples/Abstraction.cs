namespace OOPPrinciples
{
    /// <summary>
    /// Абстракция. 
    /// Моделирование требуемых атрибутов и взаимодействий сущностей в виде классов для определения абстрактного представления системы.
    /// </summary>
    internal class Abstraction { }

    #region правильная Абстракция
    public class Person
    {
        public double Id { get; }
        public string Name { get; }
        public Person(double id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class Car
    {
        public double Id { get; }
        public string Name { get; }
        public Person Owner { get; }

        public Car(double id, string name, Person owner)
        {
            Id = id;
            Name = name;
            Owner = owner;
        }

        public void Drive() { }
    }
    #endregion

    #region Неправильная Абстракция

    public class Plane
    {
        public double Id { get; }
        public string Name { get; }

        public void Swim() { }
    }
    #endregion
}
