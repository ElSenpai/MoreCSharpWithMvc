using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> _categoryDal = new GenericRepository<Category>();


        //private ICategoryDal _categoryDal;
        //public CategoryManager(ICategoryDal categoryDal)
        //{
        //    _categoryDal = categoryDal;
        //}

        public List<Category> GetAll()
        {
            return _categoryDal.List();
        }

        public void add(Category category)
        {
            _categoryDal.Add(category);
            //if (CheackCategory(category))
            //{
              
            //}
            
        }

        private bool CheackCategory(Category category)
        {
            if (category.CategoryName==""||category.CategoryName.Length<=3||category.Description==""||category.CategoryName.Length>= 51)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }

}
