using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FreeStudent.Data.Interfaces;
using FreeStudent.Data.Models;
using FreeStudent.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FreeStudent.Controllers
{
    public class FilesController : Controller
    {
        public readonly IFiles _files;
        public readonly IUserProfiles _userProfiles;
        private readonly UserManager<User> _userManager;
        public FilesController(IFiles files, IUserProfiles userProfiles, UserManager<User> userManager)
        {
            _userManager = userManager;
            _files = files;
            _userProfiles = userProfiles;
        }
        public IActionResult Index()
        {
            return View(_files.GetAllFiles());
        }

        [HttpGet]
        public IActionResult AddNewFile()
        {
                return View();  
        }

        [HttpPost]
        public IActionResult AddNewFile(AddNewFileViewModel model)
        {

            if (ModelState.IsValid)
            {
                
                
                if (HttpContext.Request.Form.Files.Count > 0 & HttpContext.Request.Form.Files[0] != null)
                {
                    File file = new File { Name = HttpContext.Request.Form.Files[0].FileName };
                    // считываем переданный файл в массив байтов
                    using (var binaryReader = new System.IO.BinaryReader(HttpContext.Request.Form.Files[0].OpenReadStream()))
                    {
                        file.bytes = binaryReader.ReadBytes((int)HttpContext.Request.Form.Files[0].Length);
                        file.UserProfileId = _userProfiles.GetUserProfileByUserId(_userManager.GetUserId(User)).Id;
                        _files.Add(file);
                    }
                    // установка массива байтов

                }


                return RedirectToAction("Index");
            }
            ViewBag.Message = "Error";
            return View("Message");
        }
    }
}