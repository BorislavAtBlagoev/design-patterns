namespace Observer
{
    public interface IClient
    {
        void Update(IBank bank, decimal amount);
    }
}
