using System;
using System.Collections.Generic;

namespace ClassesExercise1_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car()
            {
                Make = "Ferrari",
                Model = "F50",
                Year = 1995
            };


            var car2 = new Car();
            car2.Make = "Koenigsegg";
            car2.Model = "CCR";
            car2.Year = 2006;


            var car3 = new Car("Saleen", "S7", 2003);


            PrintCars(car1, car2, car3);




        }

        public static void PrintCars(Car carX, Car carY, Car carZ)
        {
            List<Car> carList = new List<Car>()
            {
                carX,
                carY,
                carZ
            };

            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Make} \n {car.Model} \n {car.Year}");
            }

        }


    }
}
