using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TollCalculator.Models;

namespace TollCalculator.Controllers
{
    public class TollController : Controller
    {

        public ActionResult Calculate()
        {
            ViewBag.VehicleType = new SelectList(Vehicle.VehicleTypes);
            return View(new Vehicle() { VehicleType = "Car", HasETag = false });
        }

        // POST: TollController/Create
        [HttpPost]
        public ActionResult Calculate(Vehicle vehicle)
        {

            ViewBag.VehicleType = new SelectList(Vehicle.VehicleTypes);
            return View(vehicle);

        }

    }
}
