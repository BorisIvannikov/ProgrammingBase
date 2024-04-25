namespace OOPPrinciples
{
    /// <summary>
    /// Полиморфизм. 
    /// Возможность реализации наследуемых свойств или методов отличающимися способами в рамках множества абстракций.
    /// </summary>
    internal class Polymorphism
    {
    }

    public interface IEmployer
    {
        public string Name { get; }
        public void DoJob();
    }

    public class Accountant : IEmployer
    {
        private readonly string _name;
        public string Name { get => _name; }
        public void DoJob()
        {
            CalculateProfit();
        }
        private void CalculateProfit() { }
    }

    public class Driver
    {

        private readonly string _name;
        public string Name { get => _name; }
        public void DoJob()
        {
            Drive();
            Drive("BMW");
        }
        private void Drive() { }
        private void Drive(string car) { }
    }

}
