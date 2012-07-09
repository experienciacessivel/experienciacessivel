using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experienciacessivel.domain.mainbc
{
    public class Category : Entity
    {
        public string Name { get; private set; }

        public void Rename(string name)
        {
            if (string.IsNullOrWhiteSpace((name)))
                throw new ArgumentException("name");

            Name = name;
        }
    }
}