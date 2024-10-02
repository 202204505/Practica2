﻿using Practice1;

namespace Practice1
{
    abstract class Vehicle : IMessageWritter
    {
        private string typeOfVehicle;
        //private string plate;
        private float speed;

        public Vehicle(string typeOfVehicle)
        {
            this.typeOfVehicle = typeOfVehicle;
            //this.plate = plate;
            speed = 0f;
        }

        //Override ToString() method with class information
        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {GetPlate()}";
        }

        public string GetTypeOfVehicle()
        {
            return typeOfVehicle;
        }
        public abstract string GetPlate();

        public float GetSpeed()
        {
            return speed;
        }

        public void SetSpeed(float speed)
        {
            this.speed = speed;
        }

        //Implment interface with Vechicle message structure
        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
        
    }
}



     
        

