using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using experienciacessivel.domain;
using experienciacessivel.infrastructure.crosscutting.Adapter;

namespace experienciacessivel.application.core
{
    public static class ProjectionsExtensionMethods
    {        
        public static TProjection ProjectedAs<TProjection>(this Entity item)
            where TProjection : class,new()
        {
            var adapter = TypeAdapterFactory.CreateAdapter();
            return adapter.Adapt<TProjection>(item);
        }
        
        public static List<TProjection> ProjectedAsCollection<TProjection>(this IEnumerable<Entity> items)
            where TProjection : class,new()
        {
            var adapter = TypeAdapterFactory.CreateAdapter();
            return adapter.Adapt<List<TProjection>>(items);
        }
    }
}
