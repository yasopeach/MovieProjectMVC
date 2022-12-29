﻿using MovieProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Business.Abstract
{
    public interface ICategoryService
    {

        Category GetById(int id);
        
        List<Category> GetAll();
        List<Category> GetListAll();
        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
    }
}
