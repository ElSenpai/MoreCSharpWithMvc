using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
        Category GetById(int id);

    }
}
