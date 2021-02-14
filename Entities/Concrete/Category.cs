using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //public yapacağız.
    //Çıplak Class Kalmasın (eğer interface vs inherit etmiyorsa bunları işaretlemeliyiz. ör.  bunlar veritabanı tablolarıdır.)
    public class Category : IEntitiy
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
