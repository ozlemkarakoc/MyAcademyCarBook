﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.EntityLayer.Concrete
{
    public class CarDetail
    {
        public int CarDetailID { get; set; }
        public string Description { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
