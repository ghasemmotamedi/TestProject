using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class DegreeRepository : IDegreeRepository
    {
        public List<Degree> GetDegrees()
        {
            List<Degree> degrees = new List<Degree>()
            {
                new Degree{Id=1,Title="کاردانی",Description="طاب لازم ندارد",IsActive=true},
                new Degree{Id=2,Title="کارشناسی",Description="باید برای مقطع کاردانی و کاشرناسی زاب بگیریم",IsActive=true},
                new Degree{Id=3,Title="ارشد",Description="باید برای مقطع کارشناسی و ارشد زاب بگیریم",IsActive=true},
                new Degree{Id=4,Title="دکتری",Description="زاب لازم ندارد",IsActive=true},
            };
            return degrees;
        }
    }
}
