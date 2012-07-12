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

        
        public IEnumerable<Place> FindByAddress(Guid addressId)
        {
            return this.AllMatching(PlaceSpecifications.ByAddress(addressId));
        } 
        
        public IEnumerable<Place> FindByAddress(Address address)
        {
            return this.AllMatching(PlaceSpecifications.ByAddress(address));
        }
        
        public IEnumerable<Place> FindByCategory(Guid categoryId)
        {
            return this.AllMatching(PlaceSpecifications.ByCategory(categoryId));
        }

        public IEnumerable<Place> FindByName(string name)
        {
            return this.AllMatching(PlaceSpecifications.ByName(name));
        }
    }
}