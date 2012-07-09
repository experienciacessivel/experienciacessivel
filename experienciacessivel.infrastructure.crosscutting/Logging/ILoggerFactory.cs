using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experienciacessivel.infrastructure.crosscutting.Logging
{
    public interface ILoggerFactory
    {
        /// <summary>
        /// Create a new ILog
        /// </summary>
        /// <returns>The ILog created</returns>
        ILogger Create();
    }
}
