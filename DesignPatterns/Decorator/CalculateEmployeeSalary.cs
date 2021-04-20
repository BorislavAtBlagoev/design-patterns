namespace Decorator
{
    public class CalculateEmployeeSalary : CalculateSalary
    {
        public override decimal Calculate()
        {
            return 50000m;
        }
    }
}
