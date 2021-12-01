using System;

namespace OOPCar
{
    class Program
    {


        class Car
        {
            string mark;
            string model;
            string regNumber;
            string color;
            int odo;
            int fuelTank;

            public Car(string _mark, string _model, string _regnumber, string _color)
            {
                mark = _mark;
                model = _model;
                regNumber = _regnumber;
                color = _color;
                odo = 0;
                fuelTank = 60;

                Console.WriteLine($"{color} {mark} {model} {regNumber} has been created.");
            }
        }
        static void Main(string[] args)
        {
           Car myCar = new Car("Porsche", "911 GT3", "SEX372", "Blue")
        }
    }
}
