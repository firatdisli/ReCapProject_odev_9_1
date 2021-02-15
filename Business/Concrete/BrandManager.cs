using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _branddal;

        public BrandManager(IBrandDal branddal)
        {
            _branddal = branddal;
        }

        public void Add(Brand brand)
        {
            _branddal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _branddal.Delete(brand);
        }

        public Brand Get(int brandId)
        {
            return _branddal.Get(b=>b.BrandId==brandId);
        }

        public List<Brand> GetAll()
        {
            return _branddal.GetAll();
        }

        public void Update(Brand brand)
        {
            _branddal.Update(brand);
        }
    }
}
