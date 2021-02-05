using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository <P> where P : class, IEntity, new()
    {
        List<P> GetAll(Expression<Func<P, bool>> filter = null);
        List<P> GetCarsByBrandId(Expression<Func<P, bool>> filter = null);
        List<P> GetCarsByColorId(Expression<Func<P, bool>> filter = null);
        void Add(P entity);
        void Update(P entity);
        void Delete(P entity);
    }
}
