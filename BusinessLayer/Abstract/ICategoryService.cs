using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        void RemoveCategory(Category category);
        void DeleteCategory(Category category);
        List<Category> GetAllList();
        Category GetById(int id);
    }
}
