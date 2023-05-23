using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Business.Abstract
{
    public interface IProductService
    {
        void Create(Product entity);
        void Delete(Product entity);
        void Update(Product entity);

        Product GetById(int id);
        List<Product> GetAll();
    }
}
