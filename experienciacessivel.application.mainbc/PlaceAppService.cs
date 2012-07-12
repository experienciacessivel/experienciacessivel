using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using experienciacessivel.domain;
using experienciacessivel.domain.mainbc;

namespace experienciacessivel.application.mainbc
{
    public class PlaceAppService: IPlaceAppService
    {

        private readonly IPlaceRepository _placeRepository;
        
        public PlaceAppService(IPlaceRepository placeRepository)
        {
            _placeRepository = placeRepository;
        }

        public CategoryDTO AddCategory(CategoryDTO category)
        {
            throw new NotImplementedException();
        }

        public CategoryDTO RenameCategory(CategoryDTO category)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategory(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public PlaceDTO AddPlace(PlaceDTO place)
        {
            throw new NotImplementedException();
        }

        public PlaceDTO ChangeCategory(PlaceDTO place)
        {
            throw new NotImplementedException();
        }

        public bool DeletePlace(Guid placeId)
        {
            var place = _placeRepository.Get(placeId);
            if (place == null)
                throw new ApplicationException("Place not found");

            _placeRepository.Remove(place);
            _placeRepository.UnitOfWork.Commit();

            return true;
        }
    }
}
