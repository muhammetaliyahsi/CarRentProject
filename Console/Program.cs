using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new Car
            //{
            //    Id = 2,
            //    BrandId = 1,
            //    ColorId = 1,
            //    DailyPrice = 150,
            //    ModelYear = 2010,
            //    Description = "1.6 Model"
            //});

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }

        }
    }
}
