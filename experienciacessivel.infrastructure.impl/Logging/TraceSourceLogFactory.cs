using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using experienciacessivel.infrastructure.crosscutting.Logging;

namespace experienciacessivel.infrastructure.impl.Logging
{
    public class TraceSourceLogFactory
    : ILoggerFactory
    {        
        public ILogger Create()
        {
            return new TraceSourceLog();
        }
    }
}
