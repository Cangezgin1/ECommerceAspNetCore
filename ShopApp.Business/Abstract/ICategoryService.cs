using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Business.Abstract
{
    public interface ICategoryService
    {
        void Create(Category entity);
        void Delete(Category entity);
        void Update(Category entity);

        Category GetById(int id);
        List<Category> GetAll();
    }
}
