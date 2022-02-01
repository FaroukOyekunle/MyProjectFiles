using System;

namespace gettaANDsetta
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Setbrand("maserati");
            Console.WriteLine(car.Getbrand());
        }
    }
    class Car
    {
        string brand;
        string color;
        


        public string Getbrand()
        {
            return brand;
        }

        public void Setbrand(string brand)
        {
            this.brand = brand;
        }

    }
}
