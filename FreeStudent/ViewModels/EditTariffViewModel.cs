using FreeStudent.Data.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStudent.ViewModels
{
    public class EditTariffViewModel
    {
        public EditTariffViewModel() { }

        public EditTariffViewModel(Tariff tariff)
        {
            this.Id = tariff.Id;
            this.Discount = tariff.Discount;
            this.ExecutorPays = tariff.ExecutorPays;
            this.CustomerPays = tariff.CustomerPays;
        }

        [BindNever]
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле заполненно некоректно")] public string Name { get; set; }
        [Required(ErrorMessage = "Поле заполненно некоректно")] [Range(0, 50, ErrorMessage = "Число от 0 до 50")] public double Discount { get; set; }
        [Required(ErrorMessage = "Поле заполненно некоректно")] [Range(0, 50, ErrorMessage = "Число от 0 до 50")] public int ExecutorPays { get; set; }
        [Required(ErrorMessage = "Поле заполненно некоректно")] [Range(0,50,ErrorMessage = "Число от 0 до 50")] public int CustomerPays { get; set; }
    }
}
