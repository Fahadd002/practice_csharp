using System;

namespace csharp_class
{
    public class Car
    {
        private int maxSpeed;
        private double currentSpeed;
        private bool hasEngineStarted;

        public int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value > 0)
                {
                    maxSpeed = value;
                }
                else
                {
                    throw new ArgumentException("MaxSpeed must be greater than 0.");
                }
            }
        }
        public double CurrentSpeed
        {
            get { return currentSpeed; }
        }

        public bool HasEngineStarted
        {
            get { return hasEngineStarted; }
        }

        public Car(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
            currentSpeed = 0;
            hasEngineStarted = false;
        }

        public void Start()
        {
            hasEngineStarted = true;
            Console.WriteLine("Car started.");
        }

        public void Stop()
        {
            hasEngineStarted = false;
            currentSpeed = 0;
            Console.WriteLine("Car stopped.");
        }
    }
}
