using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetList();
        void Add(Heading heading);
        void Delete(Heading heading);
        void Update(Heading heading);
        Heading GetById(int id);
    }
}
