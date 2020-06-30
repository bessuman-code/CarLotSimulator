using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CarLotSimulator
{

    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    //The methods should take one string parameter: the respective noise property 
    class Car
    {
        public Car()
        {

        }

        int carYear = 0;
        string carMake = "You didn't specify CAR MAKE";
        string carModel = "You didn't specify CAR MODEL";
        string carEngineNoise;
        string carHonkNoise;
        bool carIsDriveable;
        public int Year
        {
            get { return carYear; }
            set { carYear = value; }

        }
        public string Make
        {
            get { return carMake; }
            set { carMake = value; }
        }

        public string Model
        {
            get { return carModel; }
            set { carModel = value; }
        }
        public string EngineNoise
        {
            get { return carEngineNoise; }
            set { carEngineNoise = value;}
        }
        public string HonkNoise
        {
            get { return carHonkNoise; }
            set { carHonkNoise = value; }
        }
        public bool IsDriveable
        {
            get { return carIsDriveable; }
            set { carIsDriveable = value; }
        }
        public string MakeEngineNoise(string whatEngineNoise)
        {
            var typeId = int.Parse(whatEngineNoise);
            switch (typeId)
            {
                case 0:
                    return "Clucth";
                case 1:
                    return "Veep";
                case 2:
                    return "Power";
                default:
                    return "Normal";
            }
        }
        public string MakeHonkNoise(string whatHonkNoise)
        {
            var typeId = int.Parse(whatHonkNoise);
            switch (typeId)
            {
                case 0:
                    return "Honk";
                case 1:
                    return "Beep";
                case 2:
                    return "Train";
                default:
                    return "Normal";
            }
        }
    }
}
