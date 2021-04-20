namespace Facade
{
    public class Program
    {
        public static void Main()
        {
            IEngine engine = new Engine();

            engine.Start();
            engine.Stop();
        }
    }
}
