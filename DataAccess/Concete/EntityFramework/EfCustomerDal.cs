using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concete.EntityFramework
{
    public class EfCustomerDal : ICustomerDal
    {
        public void Add(Customer entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entitiy)
        {
            throw new NotImplementedException();
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
