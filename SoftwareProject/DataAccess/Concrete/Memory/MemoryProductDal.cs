using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Memory
{
    public class MemoryProductDal : IProductDal
    {
        List<Product> _product;
        public MemoryProductDal()
        {
            _product = new List<Product> {
                new Product{ ProductId=1, CategoryId=1, ProductName="Peynir (600gr)", 
                    UnitInStock=77, UnitPrice=35},
                new Product{ ProductId=2, CategoryId=1, ProductName="Zeytin (300gr)",
                    UnitInStock=18, UnitPrice=12},
                new Product{ ProductId=3, CategoryId=1, ProductName="Yumurta (30'lu)",
                    UnitInStock=25, UnitPrice=30},
                new Product{ ProductId=4, CategoryId=1, ProductName="Ekmek",
                    UnitInStock=350, UnitPrice=3},
                new Product{ ProductId=5, CategoryId=1, ProductName="Çay (500gr)",
                    UnitInStock=100, UnitPrice=35}
            };
        }
        public void Add(Product product)
        {
            _product.Add(product);
        }

        public void Delete(Product product)
        {
            //1.YOL
            //Product productToDelete = null;
            //foreach (var selected in _product)
            //{
            //    if (product.ProductId == selected.ProductId)
            //    {
            //        productToDelete = selected;
            //    }
            //}

            //_product.Remove(productToDelete);

            //2.YOL
            //LINQ: Language Integrated Query
            Product productToDelete = _product.SingleOrDefault(x => x.ProductId == product.ProductId);
            _product.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _product;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByCategoryId(int categoryId)
        {
            return _product.Where(x => x.CategoryId == categoryId).ToList();

        }

        public void Update(Product product)
        {
            Product productToUpdate = _product.SingleOrDefault(y => y.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
        }
    }
}
