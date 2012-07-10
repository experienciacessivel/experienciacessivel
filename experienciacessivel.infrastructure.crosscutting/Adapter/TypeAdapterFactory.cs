using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experienciacessivel.infrastructure.crosscutting.Adapter
{
    public static class TypeAdapterFactory
    {
        #region Members

        static ITypeAdapterFactory _currentTypeAdapterFactory = null;

        #endregion

        #region Public Static Methods
        
        public static void SetCurrent(ITypeAdapterFactory adapterFactory)
        {
            _currentTypeAdapterFactory = adapterFactory;
        }
        
        public static ITypeAdapter CreateAdapter()
        {
            return _currentTypeAdapterFactory.Create();
        }
        
        #endregion
    }
}
