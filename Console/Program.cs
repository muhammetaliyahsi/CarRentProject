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

            //foreach (var car in carManager.GetAll())
            //{
            //    System.Console.WriteLine(car.Description);
            //}

            //colorManager.Add(new Color
            //{
            //    Id = 1,
            //    Name = "Beyaz"
            //});


            //brandManager.Add(new Brand
            //{
            //    Id = 3,
            //    Name = "Opel"
            //});


            foreach (var car in carManager.GetCarDetails())
            {
                System.Console.WriteLine(car.CarId + "-" + 
                    car.BrandName + "-" + 
                    car.ColorName + "-" + 
                    car.DailyPrice);
            }

        }
    }
}
