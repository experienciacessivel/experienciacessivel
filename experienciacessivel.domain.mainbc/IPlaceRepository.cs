using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experienciacessivel.domain.mainbc
{
    public interface IPlaceRepository
    {
        IEnumerable<Place> FindByAddress(Address address);
        IEnumerable<Place> FindByAddress(Guid addressId);
        IEnumerable<Place> FindByCategory(Guid categoryId);
        IEnumerable<Place> FindByName(string name);
    }
}
