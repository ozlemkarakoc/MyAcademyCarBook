﻿using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.BusinessLayer.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void TDelete(Brand entity)
        {
            _brandDal.Delete(entity);
        }

        public Brand TGetByID(int id)
        {
            return _brandDal.GetByID(id);
        }

        public List<Brand> TGetListAll()
        {
            return _brandDal.GetListAll();
        }

        public void TInsert(Brand entity)
        {
            _brandDal.Insert(entity);
        }

        public void TUpdate(Brand entity)
        {
            _brandDal.Update(entity);
        }
    }
}
