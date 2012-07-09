using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experienciacessivel.domain.mainbc
{
    public class Place : Entity
    {
        public string Name { get; private set; }

        public Guid AddressId { get; private set; }
        public virtual Address Address { get; private set; }

        public Guid CategoryId { get; private set; }
        public virtual Category Category { get; private set; }

    public void ChangeAddress(Address newAddress)
        {
            if (newAddress == null || newAddress.IsTransient())
                throw new ArgumentException("newAddress");

            AddressId = newAddress.Id;
            Address = newAddress;
        }

        public void ChangeCategory(Category newCategory)
        {
            if (newCategory == null || newCategory.IsTransient())
                throw new ArgumentException("newCategory");

            CategoryId = newCategory.Id;
            Category = newCategory;
        }
    }
}