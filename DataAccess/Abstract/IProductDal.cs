using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Product tablosunun DAL(Data Access Layer)
    public interface IProductDal : IEntitiyRepostory<Product>
    {
    }
}
