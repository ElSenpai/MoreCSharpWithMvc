﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;

using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
       


        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
           _categoryDal = categoryDal;
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public void Add(Category category)
        {
           
            
               _categoryDal.Add(category);  
            
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(c=>c.CategoryId==id);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }
    }

}
