using FreeStudent.Data.Entities;
using FreeStudent.Data.Models;
using FreeStudent.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.Controllers
{
    public class OrdersController:Controller
    {
        public readonly IOrders _orders;
        public readonly ITariffs _tariffs;
        private readonly UserManager<User> _userManager;

        public OrdersController(IOrders orders, ITariffs tariffs, UserManager<User> userManager)
        {
            _orders = orders;
            _tariffs = tariffs;
            _userManager = userManager;
        }

        public IActionResult Index()
        {

            return View(_orders);
        }


        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Users = _userManager.Users;
            ViewBag.Tariffs = _tariffs;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddOrderViewModel model)
        {
            if (ModelState.IsValid)
            {
                Order order = new Order { Name = model.Name, CustomerId = model.CustomerId, ExecutorId = model.ExecutorId, TariffId = model.TariffId};
                await _orders.AddOrder(order);                


                return Content("Для завершения регистрации проверьте электронную почту и перейдите по ссылке, указанной в письме");

            }
            ViewBag.Users = _userManager.Users;
            ViewBag.Tariffs = _tariffs;
            return View(model);
        }

    }
}
