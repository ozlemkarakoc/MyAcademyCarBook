﻿using Microsoft.EntityFrameworkCore;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.DataAccessLayer.Abstract
{
    public interface ICommentDal : IGenericDal<Comment>
    {
      public  List<Comment> GetCommentsByCar(int id);
    }
}
