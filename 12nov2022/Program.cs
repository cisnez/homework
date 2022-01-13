using System;

namespace InClassDemo
{
    class Car
    {
        public int Size;
        public int NumberOfDoors;
        public int MaxSpeed;

    };
    class Program
    {
        static void Main(string [] args)
        {
            Car SarasCar = new Car();
            Car MaxsCar;
            MaxsCar = new Car();
            Car MaxsCopyCar = MaxsCar;
            //Two tags, 3 reference, 2 objects
            //Press F5 for Debugger
            //Class key word lets us reference? our class
            //'new' keyword lets us use an instance of the class
            //class is the cookie cutter, oject is the cookie
            //An object is an instance of a class
            MaxsCar.NumberOfDoors = 4;
            SarasCar.NumberOfDoors = 4;
            MaxsCopyCar.MaxSpeed = 550;
            MaxsCopyCar = new Car();
        }
    }
}