﻿using MovieProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<Category> GetListAll();
    }
}
