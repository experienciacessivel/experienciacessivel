using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using experienciacessivel.domain;

namespace experienciacessivel.infrastructure
{
    public class LocalRepository : ILocalRepository
    {
       private ExperienciacessivelContext _context;

       public LocalRepository(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException("unitOfWork");

            _context = unitOfWork as ExperienciacessivelContext;
        }

        public List<Local> GetLocalByName(string name)
        {
            return _context.Locais.Include("AccessibleAttributes")
                .Where(c => c.Name.StartsWith(name))                
                .ToList();
        }
    }
}
