namespace Observer
{
    public interface IBank
    {
        void Attach(IClient client);

        void Detach(IClient client);

        void IncreaseTax(decimal amount);
    }
}
