using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_Razor.Pages
{
    public class TestModel : PageModel
    {
        public void OnGet(string Name,string Family)
        {
            ViewData["FullName"] = Name + " " + Family;
        }
    }
}