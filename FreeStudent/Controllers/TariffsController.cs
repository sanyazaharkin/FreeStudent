using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeStudent.Data.Entities;
using FreeStudent.Data.Models;
using FreeStudent.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FreeStudent.Controllers
{
    public class TariffsController : Controller
    {
        public readonly ITariffs _tariffs;

        public TariffsController(ITariffs tariffs)
        {
            _tariffs = tariffs;
        }

        public IActionResult Index()
        {
            return View(_tariffs.All());
        }


        
        

        [HttpPost]
        public async Task<IActionResult> Edit(EditTariffViewModel model)
        {
            if (ModelState.IsValid)
            {
                Tariff tariff = new Tariff { Name = model.Name, CustomerPays = model.CustomerPays, ExecutorPays = model.ExecutorPays, Discount = model.Discount};
                await _tariffs.Add(tariff);
                return RedirectToAction("Index");

            }
            return View(model);
        }
        
        public IActionResult Edit(int id)
        {
            Tariff tariff = _tariffs.GetById(id);
            if (tariff == null)
            {
                return NotFound();
            }

            EditTariffViewModel model = new EditTariffViewModel(tariff);
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            _tariffs.DeleteById(id);

            return RedirectToAction("Index");
        }
    }
}