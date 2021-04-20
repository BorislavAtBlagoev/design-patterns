namespace Adapter
{
    public class Program
    {
        public static void Main()
        {
            KmhSpeed kmhSpeed = new KmhSpeed();
            IMphSpeed mphSpeed = new Adapter(kmhSpeed);

            mphSpeed.CalculateSpeedPerHour();
        }
    }
}
