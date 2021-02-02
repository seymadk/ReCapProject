using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.CarId);
                System.Console.WriteLine(car.BrandId);
                System.Console.WriteLine(car.ColorId);
                System.Console.WriteLine(car.ModelYear);
                System.Console.WriteLine(car.DailyPrice);
                System.Console.WriteLine(car.Description);
                System.Console.WriteLine("-------------------------------");
            }
        }
    }
}
