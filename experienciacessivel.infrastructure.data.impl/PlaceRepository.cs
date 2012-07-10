using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using experienciacessivel.domain;
using experienciacessivel.domain.mainbc;
using experienciacessivel.infrastructure.data;

namespace experienciacessivel.infrastructure.data.impl
{
    public class PlaceRepository
        : Repository<Place>, IPlaceRepository
    {
        
        public PlaceRepository(IQueryableUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        public IEnumerable<Place> FindByAddress(Address address) 
        {
            throw new NotImplementedException();
        }
        
        public IEnumerable<Place> FindByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Place> FindByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}