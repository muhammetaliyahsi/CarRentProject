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
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());


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
            //    Id = 2,
            //    Name = "Siyah"
            //});


            //brandManager.Add(new Brand
            //{
            //    Id = 3,
            //    Name = "opel"
            //});


            //var result = carManager.GetCarDetails();

            //foreach (var car in result.Data)
            //{
            //    System.Console.WriteLine(car.CarId + "-" +
            //        car.BrandName + "-" +
            //        car.ColorName + "-" +
            //        car.DailyPrice);
            //}

            

            userManager.Add(new User
            {
                Id = 1,
                Email = "ali@gmail.com",
                FirstName = "Ali",
                LastName = "Yahşi",
                Password = "123456789"
            });

            customerManager.Add(new Customer
            {
                UserId = 1,
                CustomerId = 1,
                CompanyName = "MAY"
            });



        }

    }
}
