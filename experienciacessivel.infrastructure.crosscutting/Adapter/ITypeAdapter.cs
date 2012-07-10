using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experienciacessivel.infrastructure.crosscutting.Adapter
{
    public interface ITypeAdapter
    {
        TTarget Adapt<TSource, TTarget>(TSource source)
            where TTarget : class,new()
            where TSource : class;

        TTarget Adapt<TTarget>(object source)
            where TTarget : class,new();
    }
}