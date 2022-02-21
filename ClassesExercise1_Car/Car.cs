using System;

namespace ClassesExercise1_Car
{
    public class Car
    {
        public Car() // Default Constructor
        {

        }

        // Parameterized Constructor
        public Car(string make, string model, int year )
        {
            Make = make;
            Model = model;
            Year = year;
        }


        public string Make { get; set; } // Public "Make" property of type string

        public string Model { get; set; } // Public "Model" property of type string

        public int Year { get; set; } // Public "Year" property of type int
    }
}
