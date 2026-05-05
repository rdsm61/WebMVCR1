using Microsoft.AspNetCore.Mvc;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers
{
    public class HomeController : Controller
    {
        private static PersonRepository _pr = new PersonRepository();
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good afternoon";
            ViewData["Message"] = "Have a nice day!";
            return View();
        }

        [HttpGet]
        public ViewResult InputData()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InputData(Person p)
        {
            _pr.AddPerson(p);
            return View("Hello", p);
        }

        public ViewResult OutputData()
        {
            ViewBag.Persons = _pr.GetAllPersons;
            ViewBag.Count = _pr.NumberOfPersons;
            return View("ListPerson");
        }

        //public string Index(string hel)
        //{
        //    string greeting = ModelClass.ModelHello() + ", " + hel + "!";

        //    return greeting;
        //}
    }
}
