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
    public class CarDetailManeger : ICarDetailService
    {
        private readonly ICarDetailDal _carDetailDal;

        public CarDetailManeger(ICarDetailDal carDetailDal)
        {
            _carDetailDal = carDetailDal;
        }

        public void TDelete(CarDetail entity)
        {
            _carDetailDal.Delete(entity);
        }

        public CarDetail TGetByID(int id)
        {
            return _carDetailDal.GetByID(id);
        }

        public CarDetail TGetCarDetailByCarID(int id)
        {
            return _carDetailDal.GetCarDetailByCarID(id);
        }

        public CarDetail TGetCarDetailWithAuthor(int id)
        {
            return _carDetailDal.GetCarDetailWithAuthor(id);
        }

        public List<CarDetail> TGetListAll()
        {
            return _carDetailDal.GetListAll();
        }

        public void TInsert(CarDetail entity)
        {
            _carDetailDal.Insert(entity);
        }

        public void TUpdate(CarDetail entity)
        {
            _carDetailDal.Update(entity);
        }
    }
}
