using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CarLotSimulator
{
    //Create a CarLot class
    //It should have at least one property: a List of cars
    //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
    //At the end iterate through the list printing each of car's Year, Make, and Model to the console
     class CarLot
    {
        
        public CarLot()
        {

        }

        
        public List<Car> ListOfCars = new List<Car>();

        List<Car> id = new List<Car>();
        public List<Car> ListOfCars0 
        
        {
            get { return id; }
            set { id = value; }
        }
    }
  
}
