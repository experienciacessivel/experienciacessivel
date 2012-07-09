using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace experienciacessivel.domain
{
    public interface ISpecification<TEntity>
    where TEntity : class
    {
        Expression<Func<TEntity, bool>> SatisfiedBy();
    }
}