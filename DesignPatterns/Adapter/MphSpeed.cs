using System;

namespace Adapter
{
    public class MphSpeed : IMphSpeed
    {
        public void CalculateSpeedPerHour()
        {
            Console.WriteLine($"Speed in Mph {100}");
        }
    }
}
