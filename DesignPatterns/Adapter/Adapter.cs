using System;

namespace Adapter
{
    public class Adapter : IMphSpeed
    {
        private readonly KmhSpeed _kmhSpeed;

        public Adapter(KmhSpeed kmhSpeed)
        {
            this._kmhSpeed = kmhSpeed;
        }

        public void CalculateSpeedPerHour()
        {
            this._kmhSpeed.CalculateSpeedPerHour();
        }
    }
}
