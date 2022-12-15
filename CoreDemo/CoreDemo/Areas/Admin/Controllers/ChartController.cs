using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass()
            { 
                categoryName = "Teknoloji", 
                categoryCount = 10 
            });
            list.Add(new CategoryClass()
            {
                categoryName = "Yazılım",
                categoryCount = 12
            });
            list.Add(new CategoryClass()
            {
                categoryName = "Spor",
                categoryCount = 8
            });
            list.Add(new CategoryClass()
            {
                categoryName = "Eğitim",
                categoryCount = 13
            });

            return Json(new { jsonlist = list });
        }
    }
}
