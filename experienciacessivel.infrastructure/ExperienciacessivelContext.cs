using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using experienciacessivel.domain;

namespace experienciacessivel.infrastructure
{
    public class ExperienciacessivelContext : DbContext, IUnitOfWork
    {
        public DbSet<Local> Locais { get; set; }
        public DbSet<AccessibleAttributes> AccessibleAttributes { get; set; }

        public void Save()
        {
            SaveChanges();
        }
    }
}
