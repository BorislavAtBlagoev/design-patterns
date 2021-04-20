namespace Decorator
{
    public abstract class Bonus : CalculateSalary
    {
        protected CalculateSalary _calculateSalary;

        public Bonus(CalculateSalary calculateSalary)
        {
            this._calculateSalary = calculateSalary;
        }
    }
}
