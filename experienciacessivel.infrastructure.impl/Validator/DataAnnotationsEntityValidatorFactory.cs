using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using experienciacessivel.infrastructure.crosscutting.Validator;

namespace experienciacessivel.infrastructure.impl.Validator
{
    public class DataAnnotationsEntityValidatorFactory
    : IEntityValidatorFactory
    {        
        public IEntityValidator Create()
        {
            return new DataAnnotationsEntityValidator();
        }
    }
}
