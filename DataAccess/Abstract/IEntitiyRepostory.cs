using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Data access için Repostory yapısı sağlar.

    //generic constraint (kısıtlama). Her türlü nesne yollanmasın istiyorum. Sadece entitiy clası olsun istiyorum.
    //class : referans tip
    //IEntitiy : IEntitiy olabilir veya IEntitiy implemente eden bir nesne olabilir
    //new() : new'lenenilebilir olmalı. (Bunu yazarak IEntitiy tip almasını engelliyoruz.)
    public interface IEntitiyRepostory<T> where T:class, IEntitiy,new() //Sadece IEntitiy implemente eden classlar alır.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //filtre verilmeyebilir de.
        T Get(Expression<Func<T, bool>> filter); //filtre bulunması zorunlu.
        void Add(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);
    }
}
