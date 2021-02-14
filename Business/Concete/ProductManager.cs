using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concete
{
    public class ProductManager : IProductService
    {
        //bir iş sınıfı başka sınıfları Newlememeli!! Bunun yöntemi soyut sınıf kullanmaktan geçer.

        IProductDal _productDal; //Ben arka tarafta Entitiy mi? ADO.NET mi? kullandığına bakmam.
        //private InMemoryProductDal inMemoryProductDal;

        public ProductManager(IProductDal _productDal) //Constractor ile bana bir Veri erişim nesnesi ver. (ADO.NET/Entities/Deper..)
        {
            this._productDal = _productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları
            //yetkisi var mmı
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int Id)
        {
            return _productDal.GetAll(p => p.CategoryId == Id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}
