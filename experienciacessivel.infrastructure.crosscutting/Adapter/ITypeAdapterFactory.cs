using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experienciacessivel.infrastructure.crosscutting.Adapter
{
    public interface ITypeAdapterFactory
    {        
        ITypeAdapter Create();
    }
}
