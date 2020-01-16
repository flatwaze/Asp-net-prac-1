using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson1.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson1.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/

        private List<GadgetView> gadgets = new List<GadgetView> {
            new GadgetView
            {
                Id = 1,
                Type = "Smartphone",
                Firm = "Samsung",
                Name = "Galaxy s10 plus",
                Processor_freq = 2.8,
                Operative_memory = 8,
                Price = 80000,
            },

            new GadgetView
            {
                Id = 2,
                Type = "Laptop",
                Firm = "Asus",
                Name = "UX331FN-EG018T",
                Processor_freq = 1.8,
                Operative_memory = 16,
                Price = 125000,
            },

            new GadgetView
            {
                Id = 3,
                Type = "Tablet",
                Firm = "Apple",
                Name = "Ipad Pro 2019",
                Processor_freq = 2.6,
                Operative_memory = 4,
                Price = 127000,
            }
        };
        public IActionResult Index()
        {
            return View(gadgets);
        }


        //Get: /home/details/{id}
        public IActionResult Сharacteristic(int id)
        {
            var gadget = gadgets.FirstOrDefault(x => x.Id == id);
            return View(gadget);
        }
    }
}
