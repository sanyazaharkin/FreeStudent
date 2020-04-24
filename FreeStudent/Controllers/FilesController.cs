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
        private readonly IFiles _files;
        private readonly IUserProfiles _userProfiles;
        private readonly UserManager<User> _userManager;
        public FilesController(IFiles files, IUserProfiles userProfiles, UserManager<User> userManager)
        {
            _userManager = userManager;
            _files = files;
            _userProfiles = userProfiles;
        }
        public IActionResult Index()
        {
            FilesViewModel viewModel = new FilesViewModel { Files = _files.GetAllFiles(), UserProfiles = _userProfiles.AllUserProfiles.ToList() };

            return View(viewModel);
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
               
                // считываем переданный файл в массив байтов
                using (var binaryReader = new System.IO.BinaryReader(model.File.OpenReadStream()))
                {
                    _files.Add(new File(
                        Guid.Parse(_userProfiles.GetUserProfileIdByUserId(_userManager.GetUserId(this.User))),
                        binaryReader.ReadBytes((int)model.File.Length),
                        System.IO.Path.GetFileName(model.File.FileName),
                        System.IO.Path.GetExtension(model.File.FileName),
                        model.File.ContentType
                        ));                        
                }
                    
                
                return RedirectToAction("Index");
            }
            ViewBag.Message = "Error";
            return View("Message");
        }
        public IActionResult GetFiles(string id)
        {
            File file = _files.GetFileById(id);
            FileContentResult result = new FileContentResult(file.bytes, file.ContentType)
            {
                FileDownloadName = file.Name
            };

            return result;
        }
        public IActionResult Del(string id)
        {
            _files.Del(Guid.Parse(id));

            return RedirectToAction("Index");
        }
    }
}