﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experienciacessivel.domain
{
    public interface IUnitOfWork
    {
        void Save();
    }
}
