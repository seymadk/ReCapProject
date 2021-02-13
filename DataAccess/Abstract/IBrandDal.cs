﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBrandDal : IEntityRepository<Entities.Concrete.Brand>
    {
        List<Brand> GetAll();
        Brand Get(Func<object, bool> p);
    }
}
