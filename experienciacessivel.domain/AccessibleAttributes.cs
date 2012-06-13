using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experienciacessivel.domain
{
    public class AccessibleAttributes
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public IList<Local> Locals { get; private set; }

        protected AccessibleAttributes()
        {
        }

        public AccessibleAttributes(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public AccessibleAttributes(string name)
        {
           this.Name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj is AccessibleAttributes)
            {
                return obj.GetHashCode() == this.GetHashCode();
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id ^ Name.GetHashCode();
        }
    }
}
