namespace Decorator
{
    public class Program
    {
        public static void Main()
        {
            CalculateEmployeeSalary salary = new CalculateEmployeeSalary();
            NewYearBonus bonus = new NewYearBonus(salary);

            System.Console.WriteLine(bonus.Calculate());
        }
    }
}
