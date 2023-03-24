using System.Reflection;

namespace PR1
{
    class Car
    {
        public double maxSpeed;
        public string carName;
        public Car()
        {
            this.maxSpeed = 180;
            this.carName = "Car Name";
        }
        public Car(double maxSpeed, string carName)
        {
            this.maxSpeed = maxSpeed;
            this.carName = carName;
        }

        public double CalculateTime(double distance)
        {
            return distance / maxSpeed;
        }
        public void PrintCarInfo()
        {
            Console.WriteLine($"Название автомобиля - {carName}");
            Console.WriteLine($"Максимальная скорость - {maxSpeed}");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Car[] cars = new Car[4];

                double distance = 700;

                Car buggatti = new Car(380, "Buggatti Divo");
                cars[0] = buggatti;
                double buggattiTime = buggatti.CalculateTime(distance);
                buggatti.PrintCarInfo();
                Console.WriteLine($"Buggatti Divo пройдёт 100 км за {buggattiTime}\n");


                Car hennessey = new Car(500, "Hennessey Venom F5");
                cars[1] = hennessey;
                double hennesseyTime = hennessey.CalculateTime(distance);
                hennessey.PrintCarInfo();
                Console.WriteLine($"Hennessey Venom F5 пройдёт 100 км за {hennesseyTime}\n");


                Car SSC = new Car(460, "SSC Tuatara");
                cars[2] = SSC;
                double SSCTime = SSC.CalculateTime(distance);
                SSC.PrintCarInfo();
                Console.WriteLine($"SSC Tuatara пройдёт 100 км за {SSCTime}\n");


                Car aston = new Car(400, "Aston Martin Valkyrie");
                cars[3] = aston;
                double astonTime = aston.CalculateTime(distance);
                aston.PrintCarInfo();
                Console.WriteLine($"Aston Martin Valkyrie пройдёт 100 км за {astonTime}\n");

                double maxSpeed = 0;

                foreach (Car car in cars)
                {
                    if (car.maxSpeed > maxSpeed)
                    {
                        maxSpeed = car.maxSpeed;
                    }
                }

                Car winner;
                foreach (Car car in cars)
                {
                    if (car.maxSpeed == maxSpeed)
                    {
                        winner = car;
                        Console.WriteLine($"В гонке победил автомобиль {winner.carName}!");
                        
                    }
                }


                Console.ReadKey(true);
            }
        }
    }
}