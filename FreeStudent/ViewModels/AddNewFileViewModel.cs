using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.ViewModels
{
    public class AddNewFileViewModel
    {
        public string Name { get; set; }


        [Display(Name = "Выберите файл")]
        [DataType(DataType.Upload)]
        public List<IFormFile> Files { get; set; }
    }
}
