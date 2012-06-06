using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experienciacessivel.domain
{
    public class Local
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public IList<AccessibleAttributes> AccessibleAttributes { get; private set; }

        protected Local()
        {
        }

        public Local(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override bool Equals(object obj)
{
if (obj is Local)
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