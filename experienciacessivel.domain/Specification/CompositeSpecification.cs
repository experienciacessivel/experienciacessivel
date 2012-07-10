using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using experienciacessivel.domain;
using System.Linq.Expressions;

namespace experienciacessivel.domain.Specification
{
    public abstract class CompositeSpecification<TEntity>
     : Specification<TEntity>
     where TEntity : class
    {
        #region Properties

        /// <summary>
        /// Left side specification for this composite element
        /// </summary>
        public abstract ISpecification<TEntity> LeftSideSpecification { get; }

        /// <summary>
        /// Right side specification for this composite element
        /// </summary>
        public abstract ISpecification<TEntity> RightSideSpecification { get; }

        #endregion
    }
}
