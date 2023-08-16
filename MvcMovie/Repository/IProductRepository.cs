using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMovie.Repository
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        void Add(Product product);
        Product Get(int id);
    }
}
