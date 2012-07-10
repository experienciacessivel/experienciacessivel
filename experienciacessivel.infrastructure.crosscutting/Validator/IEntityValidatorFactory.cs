using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experienciacessivel.infrastructure.crosscutting.Validator
{
    public interface IEntityValidatorFactory
    {        
        IEntityValidator Create();
    }
}
