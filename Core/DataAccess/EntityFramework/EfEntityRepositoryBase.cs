using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<PEntity, PContext> : IEntityRepository<PEntity>
        where PEntity: class, IEntity, new()
    {
        public void Insert(PEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(PEntity entity)
        {
            throw new NotImplementedException();
        }

        public PEntity Get(Expression<Func<PEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<PEntity> GetAll(Expression<Func<PEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<PEntity> GetCarsByBrandId(Expression<Func<PEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<PEntity> GetCarsByColorId(Expression<Func<PEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(PEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
