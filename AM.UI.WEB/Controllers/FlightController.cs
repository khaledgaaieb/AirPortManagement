﻿using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AM.UI.WEB.Controllers
{

    
    public class FlightController : Controller
    {
        IServiceFlights sf;
        IServicePlane sp;
        public FlightController(IServiceFlights sf, IServicePlane sp)
        {
            this.sf = sf;
            this.sp = sp;
        }

        // GET: FlightController
        public ActionResult Index(DateTime? dateDepart)
        {
            if (dateDepart == null)
                return View(sf.GetAll());
            else
                return View(sf.GetMany(f => f.FlightDate.Date.Equals(dateDepart)));
            
        }

        // GET: FlightController/Details/5
        public ActionResult Details(int id)
        {
            return View(sf.GetById(id));
        }

        // GET: FlightController/Create
        public ActionResult Create()
        {
            ViewBag.PlaneFk = new SelectList(sp.GetAll(), "PlaneId", "Information");
            return View();
        }

        // POST: FlightController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Flight flight, IFormFile AirlineLogo)
        {
            try
            {

                //sauvegarder l'image sous uploads
                if (AirlineLogo != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(),

                    "wwwroot", "uploads", AirlineLogo.FileName);

                    Stream stream = new FileStream(path, FileMode.Create);
                    AirlineLogo.CopyTo(stream);
                    flight.Airline = AirlineLogo.FileName;
                }
                sf.Add(flight);
                sf.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.PlaneFk = new SelectList(sp.GetAll(), "PlaneId", "Information");
            return View(sf.GetById(id));
        }

        // POST: FlightController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Flight flight)
        {
            try
            {
                sf.Update(flight);
                sf.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View(sf.GetById(id));
        }

        // POST: FlightController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Flight flight)
        {
            try
            {
                sf.Delete(flight);
                sf.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
