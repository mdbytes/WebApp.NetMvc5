using MVCWebApp.Data;
using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVC5Template.Controllers
{
    [Authorize]
    public class CarController : Controller
    {
        private ICarAccessor carAccessor;

        public CarController()
        {
            this.carAccessor = new CarAccessor();
        }

        // GET: Car
        public ActionResult Index()
        {
            List<Car> cars = carAccessor.getAllCars();
            return View(cars);
        }

        // GET: Car/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Car/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Car/Create
        [HttpPost]
        public ActionResult Create(Car car)
        {
            if(!ModelState.IsValid)
            {
                return View(car);
            }
            try
            {
                // TODO: Add insert logic here
                carAccessor.createCar(car);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Car/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Car/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: Car/Delete/5
        [Authorize(Roles ="ADMIN")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Car/Delete/5

        [HttpPost]
        [Authorize(Roles = "ADMIN")]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
