using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experienciacessivel.application.mainbc
{
    public interface IPlaceAppService
    {
        CategoryDTO AddCategory(CategoryDTO category);
        CategoryDTO RenameCategory(CategoryDTO category);
        bool DeleteCategory(Guid categoryId);

        PlaceDTO AddPlace(PlaceDTO place);
        PlaceDTO ChangeCategory(PlaceDTO place);
        bool DeletePlace(Guid placeId);
    }        
}
