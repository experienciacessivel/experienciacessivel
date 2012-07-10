using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using experienciacessivel.domain;
using experienciacessivel.domain.Specification;

namespace experienciacessivel.domain.mainbc
{
    public static class PlaceSpecifications
    {
        
        public static ISpecification<Place> PlaceByAddress(Guid addressId)
        {
            Specification<Place> specification = new TrueSpecification<Place>();

            if (addressId != Guid.Empty)
            {                
                specification &= new DirectSpecification<Place>(
                    p => p.AddressId == addressId
                    );                
            }
            
            return specification;
        }

        public static ISpecification<Place> PlaceByAddress(Address address)
        {            
            Specification<Place> specification = new TrueSpecification<Place>();
            
            if (address != null)
            {                
                var stspec = new DirectSpecification<Place>(
                    p => p.Address.Street.ToLower().Contains(
                        address.Street.ToLower()
                        )
                    );

                var dtspec = new DirectSpecification<Place>(
                    p => p.Address.District.ToLower().Contains(                        
                        address.District.ToLower()
                        )
                    );
                var zpspec = new DirectSpecification<Place>(
                    p => p.Address.ZipCode == address.ZipCode
                    );

                specification &= stspec || dtspec || zpspec;
            }

            return specification;
        }

        public static ISpecification<Place> PlaceByCategory(Guid categoryId)
        {
            Specification<Place> specification = new TrueSpecification<Place>();

            if (categoryId != Guid.Empty)
            {
                specification &= new DirectSpecification<Place>(
                    p => p.CategoryId == categoryId
                    );
            }
            
            return specification;
        }

        public static ISpecification<Place> PlaceByName(string name)
        {
            Specification<Place> specification = new TrueSpecification<Place>();

            if (!string.IsNullOrWhiteSpace(name))
            {
                specification &= new DirectSpecification<Place>(
                    p => p.Name.ToLower().Contains(name.ToLower())
                    );
            }

            return specification;
        } 
    }
}
