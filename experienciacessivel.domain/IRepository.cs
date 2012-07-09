using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace experienciacessivel.domain
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : Entity
    {        
        IUnitOfWork UnitOfWork { get; }
        void Add(TEntity item);
        void Remove(TEntity item);
        void Modify(TEntity item);
        void TrackItem(TEntity item);
        void Merge(TEntity persisted, TEntity current);
        TEntity Get(Guid id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> AllMatching(ISpecification<TEntity> specification);
        IEnumerable<TEntity> GetPaged<KProperty>(int pageIndex, int pageCount, Expression<Func<TEntity, KProperty>> orderByExpression, bool ascending);        
        IEnumerable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> filter);
    }
}
