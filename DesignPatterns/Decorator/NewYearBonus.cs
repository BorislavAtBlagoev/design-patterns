namespace Decorator
{
    public class NewYearBonus : Bonus
    {
        public NewYearBonus(CalculateSalary calculateSalary) : base(calculateSalary)
        {
        }

        public override decimal Calculate()
        {
            if (this._calculateSalary != null)
            {
                decimal bonus = 10m;
                decimal salaryAfterBonus = this._calculateSalary.Calculate();
                return salaryAfterBonus * bonus;
            }
            else
            {
                return 0;
            }
        }
    }
}
