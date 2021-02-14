using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Bu classa diğer katmanlar erişsin istiyorum. Dataacces ürünü ekleyecek ve business kontrol edecek UI ürünü gösterecek.
    //default interneldır ve sadece entities erişir. Bu nedenle public yaptım
    public class Product : IEntitiy
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
