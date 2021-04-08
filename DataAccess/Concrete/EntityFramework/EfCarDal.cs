using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,CarRentContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.Name,
                                 ColorName = co.Name,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from c in context.Cars
                             where c.ColorId == colorId
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.Name,
                                 ColorName = co.Name,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from c in context.Cars
                             where c.BrandId == brandId
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.Name,
                                 ColorName = co.Name,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarFilterBrandIdColorId(int brandId, int colorId)
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = (from ca in context.Cars
                              join co in context.Colors on ca.ColorId equals co.Id
                              join br in context.Brands on ca.BrandId equals br.Id
                              where ca.ColorId == colorId && br.Id == brandId
                              select new CarDetailDto
                              {
                                  Id = ca.Id,
                                  Description = ca.Description,
                                  BrandId = br.Id,
                                  DailyPrice = ca.DailyPrice,
                                  BrandName = br.Name,
                                  ColorId = co.Id,
                                  ColorName = co.Name,
                                  ModelYear = ca.ModelYear
                              }).ToList();
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByCarId(int carId)
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from c in context.Cars
                             where c.Id == carId
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.Name,
                                 ColorName = co.Name,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear

                             };
                return result.ToList();
            }
        }
    }
}