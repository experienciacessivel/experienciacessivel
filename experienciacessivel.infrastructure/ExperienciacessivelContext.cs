using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using experienciacessivel.domain;

namespace experienciacessivel.infrastructure
{
    internal class ExperienciacessivelContext : DbContext
    {
        public DbSet<Local> Locais { get; private set; }
        public DbSet<AccessibleAttributes> AccessibleAttributes { get; set; }
    }
}
