using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Models;

namespace Test.DegreeComponents
{
    public class DegreeComponent:ViewComponent
    {
        private readonly IDegreeRepository degreeRepository;

        public DegreeComponent(IDegreeRepository degreeRepository)
        {
            this.degreeRepository = degreeRepository;
        }
        //InvokeAsync
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("DegreeList", degreeRepository.GetDegrees()));
        }
    }
}
