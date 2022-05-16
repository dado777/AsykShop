using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AsykShop.Core.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name="Есіміңізді толтырыңыз")]
        [StringLength(25)]
        [Required(ErrorMessage = "Есіміңіз дұрыс толтырылған жоқ!")]
        public string Name { get; set; }

        [Display(Name = "Тегіңізді толтырыңыз")]
        [StringLength(25)]
        [Required(ErrorMessage = "Тегіңіз дұрыс толтырылған жоқ!")]
        public string LastName { get; set; }

        [Display(Name = "Мекен-жайды толтырыңыз")]
        [StringLength(25)]
        [Required(ErrorMessage = "Мекен-жай дұрыс толтырылған жоқ!")]
        public string Address { get; set; }

        [Display(Name = "Ұялы телефон нөмірін толтырыңыз")]
        [StringLength(12)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Ұялы телефон нөміріңіз дұрыс толтырылған жоқ!!")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Электронды поштаны толтырыңыз")]
        [StringLength(25)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Электронды пошта дұрыс толтырылған жоқ!")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderDate { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
