using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using experienciacessivel.domain;
using System.Linq.Expressions;

namespace experienciacessivel.domain.Specification
{
    public sealed class NotSpecification<TEntity>
    : Specification<TEntity>
    where TEntity : class
    {
        #region Members

        Expression<Func<TEntity, bool>> _OriginalCriteria;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for NotSpecificaiton
        /// </summary>
        /// <param name="originalSpecification">Original specification</param>
        public NotSpecification(ISpecification<TEntity> originalSpecification)
        {

            if (originalSpecification == (ISpecification<TEntity>)null)
                throw new ArgumentNullException("originalSpecification");

            _OriginalCriteria = originalSpecification.SatisfiedBy();
        }

        /// <summary>
        /// Constructor for NotSpecification
        /// </summary>
        /// <param name="originalSpecification">Original specificaiton</param>
        public NotSpecification(Expression<Func<TEntity, bool>> originalSpecification)
        {
            if (originalSpecification == (Expression<Func<TEntity, bool>>)null)
                throw new ArgumentNullException("originalSpecification");

            _OriginalCriteria = originalSpecification;
        }

        #endregion

        #region Override Specification methods

        /// <summary>
        /// <see cref="Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.ISpecification{TEntity}"/>
        /// </summary>
        /// <returns><see cref="Microsoft.Samples.NLayerApp.Domain.Seedwork.Specification.ISpecification{TEntity}"/></returns>
        public override Expression<Func<TEntity, bool>> SatisfiedBy()
        {

            return Expression.Lambda<Func<TEntity, bool>>(Expression.Not(_OriginalCriteria.Body),
                                                         _OriginalCriteria.Parameters.Single());
        }

        #endregion
    }
}
