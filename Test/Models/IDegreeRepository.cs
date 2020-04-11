using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public interface IDegreeRepository
    {
        List<Degree> GetDegrees();
    }
}
