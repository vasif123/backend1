using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            Testimonial model = new Testimonial { 
            Id=1,
            Maintext= "Testimonials",
            Maintitle= "Necessitatibus eius consequatur ex aliquid fuga eum quidem",
            Divtext= " Fugiat enim eram quae cillum dolore dolor amet nulla culpa multos export minim fugiat minim velit minim dolor enim duis veniam ipsum anim magna sunt elit fore quem dolore labore illum veniam. ",
            person="Murad Abdullayev",
            Image= "assets/img/testimonials/testimonials-6.jpg",
            Imagetext= "Programmer"

            };
            return View(model);
        }
    }
}
