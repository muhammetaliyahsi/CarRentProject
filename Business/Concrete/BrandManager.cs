using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.Name.Length > 2 && _brandDal.GetAll().Any(b => b.Name == brand.Name) == false)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Marka başarıyla eklendi.");
            }
            else if (brand.Name.Length <= 2)
            {
                Console.WriteLine("Lütfen 2 karakterden uzun bir marka ismi giriniz!");
            }
            else if (_brandDal.GetAll().Any(b => b.Name == brand.Name) == true)
            {
                Console.WriteLine("Lütfen mevcut olmayan bir marka giriniz!");
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka başarıyla silindi.");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(c => c.Id == id);
        }

        public void Update(Brand brand)
        {
            if (brand.Name.Length >= 2)
            {
                _brandDal.Update(brand);
                Console.WriteLine("Marka başarıyla güncellendi.");
            }
            else
            {
                Console.WriteLine("Lütfen 2 karakterden uzun bir marka ismi giriniz!");
            }
        }
    }
}
