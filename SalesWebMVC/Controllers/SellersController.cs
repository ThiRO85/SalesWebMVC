using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller //Nome do controlador deve estar no plural, tal qual...
    {                                           //... no arguivo _Layout.cshtml e na pasta Views
        public IActionResult Index()
        {
            return View();
        }
    }
}
