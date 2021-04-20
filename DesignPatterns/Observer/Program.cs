namespace Observer
{
    public class Program
    {
        public static void Main()
        {
            IBank bank = new Bank();

            IClient john = new Person();
            IClient doe = new Person();

            IClient mentormate = new Company();

            bank.Attach(john);
            bank.Attach(doe);
            bank.Attach(mentormate);

            bank.IncreaseTax(10);
            bank.IncreaseTax(20);

            bank.Detach(doe);

            bank.IncreaseTax(11);
        }
    }
}
