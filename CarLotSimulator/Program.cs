using System;
using System.Collections.Generic;
using System.Data.Common;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            
            

            //Now that the Car class is created we can instanciate 3 new cars
            
            var car1 = new Car() { Year = 2018, Make = "Piper", Model = "Cardi", EngineNoise = "Cry", HonkNoise = "Low", IsDriveable = true };
            var car2 = new Car();
            var car3 = new Car();

            
            //Set the properties for each of the cars
            car1.Year = 2018;
            car1.Make = "Piper";
            car1.Model = "Cardi";
            car1.EngineNoise = "Cry";
            car1.HonkNoise = "Low";
            car1.IsDriveable = true;

            car2.Year = 2019;
            car2.Make = "Fish";
            car2.Model = "Bugati";
            car2.EngineNoise = "Pow";
            car2.HonkNoise = "Mid";
            car2.IsDriveable = true;

            car3.Year = 2020;
            car3.Make = "Lion";
            car3.Model = "Tiger";
            car3.EngineNoise = "Blo";
            car3.HonkNoise = "High";
            car3.IsDriveable = true;

            //Call each of the methods for each car
            car1.MakeEngineNoise("0");
            car1.MakeEngineNoise("10");

            car2.MakeEngineNoise("1");
            car2.MakeHonkNoise("1");

            car3.MakeEngineNoise("2");
            Console.WriteLine($"{car3.MakeHonkNoise("2")}");

            var carLot = new CarLot();


            carLot.ListOfCars.Add(car1);
            carLot.ListOfCars.Add(car2);
            carLot.ListOfCars.Add(car3);
            foreach (var list in carLot.ListOfCars)
            {
                Console.WriteLine($" Year: {list.Year} Make: {list.Make} Model: {list.Model}");
            }


           


            carLot.ListOfCars0.Add(car1);
            carLot.ListOfCars0.Add(car2);
            carLot.ListOfCars0.Add(car3);
            foreach (var list in carLot.ListOfCars0)
            {
                Console.WriteLine($" Year: {list.Year} Make: {list.Make} Model: {list.Model}");
            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            var theCars = new List <Car>();
            theCars.Add(car1);
            theCars.Add(car2);
            theCars.Add(car3);
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var list in theCars)
            {
                Console.WriteLine($" Year: {list.Year} Make: {list.Make} Model: {list.Model}");
            }
        }
    }
}
