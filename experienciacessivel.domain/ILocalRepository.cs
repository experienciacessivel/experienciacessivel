using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experienciacessivel.domain
{
    public interface ILocalRepository
    {
        List<Local> GetLocalByName(string name);
    }
}
