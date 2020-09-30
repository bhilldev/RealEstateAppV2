using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using RealEstateApp2.Models;

namespace RealEstateApp2.Controllers
{
    [Authorize]
    public class HouseController : Controller
    {
        
        // GET: Default
        IHouseRepository repository;
        public HouseController(IHouseRepository repPassedIn)
        {
            repository = repPassedIn;
        }
        [AllowAnonymous]
        public ActionResult List()
        {
            return View(repository.Houses);
        }
        public ActionResult Edit(int houseId)
        {
            House house = repository.Houses.FirstOrDefault(p => p.HouseID == houseId);
            ViewBag.RealtorID = new SelectList(repository.Realtors, "RealtorID", "FirstName", house.RealtorID);
            return View(house);

        }
        [HttpPost]
        public ActionResult Edit(House house)
        {
            if (ModelState.IsValid)
            {
                repository.SaveHouse(house);
                TempData["message"] = string.Format("{0} has been saved", house.Street);
                return RedirectToAction("List");
            }
            else
            {
                return View(house);
            }
        }
        public ActionResult Create()
        {
            ViewBag.RealtorID = new SelectList(repository.Realtors, "RealtorID", "FirstName");
            return View("Edit", new House());
        }
        public ActionResult Delete(int houseId)
        {
            House deletedHouse = repository.DeleteHouse(houseId);
            if (deletedHouse != null)
            {
                TempData["message"] = string.Format("{0} was deleted", deletedHouse.Street);
            }
            return RedirectToAction("List");
        }
    }
}