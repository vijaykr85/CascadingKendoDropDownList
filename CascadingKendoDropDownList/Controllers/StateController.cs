using CascadingKendoDropDownList.Models;
using Microsoft.AspNetCore.Mvc;

namespace CascadingKendoDropDownList.Controllers
{
    public class StateController : Controller
    {
        private readonly StateContext context;

        public StateController(StateContext context)
        {
            this.context = context;
        }


        public IActionResult Index()
        {
            return View();
        }


        public ActionResult GetData()
        {
            var states = context.states.ToList();
            return Json(states);
        }

        public ActionResult GetData2()
        {
            var city = context.cities.ToList();
            return Json(city);
        }

        public ActionResult Createdrop(city city)
        {

            context.cities.Add(city);
            context.SaveChanges();

            return Json(city);
        }
    }
}
