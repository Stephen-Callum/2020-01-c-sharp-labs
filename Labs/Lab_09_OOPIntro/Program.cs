using System;

namespace Lab_09_OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            #region GenericCar
            // var keyword infers type from right.
            // car1 = INSTANCE ie particular object created
            // Car = TEMPLATE USED
            // () runs a METHOD when calling 'new' keyword // Constructor Method
            var car1 = new Car();
            car1.Make = "Merc";
            for (int i = 0; i < 1000; i++)
            {
                var car = new Car();
            }
            #endregion

        }
    }

    #region GenericCar
    class Car
    {
        public string Make;
        public string Model;
        public string Color;
        public int Length; // M
        public int Speed;

        // Default constructor present even when not stated
        public Car()
        {
            this.Speed = 0; // This = this instance
        }

        public Car(string make, string model, string color, int length)
        {
            this.Make = "make";
            this.Model = model;
            this.Color = color;
            this.Length = length;
        }
    }
    #endregion

    class Mercedes : Car
    {

    }

    class SClass : Mercedes
    {
        public bool SportsModel;
        public bool LeatherSeats;
    }

    class S220 : SClass
    {
        
    }

}
