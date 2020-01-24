using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_Demo.Controllers
{
    public class DemoController : Controller
    {

        #region Property
        [BindProperty(SupportsGet =true)]
        public int id { get; set; }
        #endregion 

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [ResponseCache(CacheProfileName = "Default-Cache", VaryByQueryKeys = new[] { "id" })]
        public IActionResult OnView()
        {
            ViewBag.DateTimeDisplay = DateTime.Now;

            return View();
        }
    }
}