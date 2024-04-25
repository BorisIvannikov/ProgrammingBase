namespace SOLIDPrinciples
{
    /// <summary>
    /// Single Responsibility Principle - Принцип единой ответственности
    /// </summary>
    internal class S
    {

    }
    
    public class Employer
    {
        public int ID { get; set; }
        public int Name { get; set; }
    }
    /// <summary>
    /// представляет компонент контекста БД
    /// </summary>
    public class EmployersDBContext
    {   
        List<Employer> Employers { get; set; } = new List<Employer>();
        public EmployersDBContext() 
        {
            EnsureCreateTable();
        }
        private void EnsureCreateTable() { }

        /// <summary>
        /// нарушение принципа
        /// </summary>
        //public static void CreateEmployer() { }
        //public static void DeleteEmployer() { }
    }
    /// <summary>
    /// работа с элементами бд описана в отдельном компоненте
    /// </summary>
    public class EmployersRepository
    {
        public static void CreateEmployer() { }
        public static void DeleteEmployer() { }
    }
}