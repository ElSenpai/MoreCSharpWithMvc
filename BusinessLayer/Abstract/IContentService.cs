using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        void Add(Content content);
        void Delete(Content content);
        void Update(Content content);
        Content GetById(int id);
    }
}
