using System;

namespace Facade
{
    public class Engine : IEngine
    {
        public void Start()
        {
            this.EnableAirflowSensor();
            this.StartFuelPump();
            this.EnableEngineStarter();
            this.StartCoolingPump();
        }

        public void Stop()
        {
            this.StopFuelPump();
            this.StopCoolingPump();
            this.DisableAirflowSensor();
        }

        #region StartEngine

        private void EnableAirflowSensor()
        {
            Console.WriteLine("The Airflow sensor was enabled!");
        }

        private void StartFuelPump()
        {
            Console.WriteLine("The Fuel pump was started!");
        }

        private void EnableEngineStarter()
        {
            Console.WriteLine("The Engine starter was enabled!");
        }

        private void StartCoolingPump()
        {
            Console.WriteLine("The Cooling pump was started!");
        }

        #endregion

        #region StopEngine
        private void StopFuelPump()
        {
            Console.WriteLine("The Fuel pump was stopped!");
        }

        private void StopCoolingPump()
        {
            Console.WriteLine("The Cooling pump was stopped!");
        }

        private void DisableAirflowSensor()
        {
            Console.WriteLine("The Airflow sensor was disabled!");
        }

        #endregion
    }
}
