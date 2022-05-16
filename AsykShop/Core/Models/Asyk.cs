using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using AsykShop.Properties;

namespace AsykShop.Core.Models
{
    public class Asyk
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name="Атауы")]
        [Required(ErrorMessage = "Атауы дұрыс толтырылған жоқ!")]
        public string AsykName { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name="Қысқаша сипаттамасы")]
        [Required(ErrorMessage = "Қысқаша сипаттамасы дұрыс толтырылған жоқ!")]
        public string AsykShortDesc { get; set; }

        [Display(Name = "Толық сипаттамасы")]
        [Required(ErrorMessage = "Толық сипаттамасы дұрыс толтырылған жоқ!")]
        public string AsykLongDesc { get; set; }

        [Display(Name = "Суреті")]
        public byte[] AsykImageData { get; set; }
        
        public string AsykImageMimeType { get; set; }

        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Resources))]
        [Range(0, 1000, ErrorMessage = "Бағасы дұрыс толтырылған жоқ!")]
        [DataType(DataType.Currency)]
        [Display(Name = "Бағасы")]
        public ushort AsykPrice { get; set; }

        [Display(Name = "Танымал түрі")]
        public bool isFavorAsyk { get; set; }

        [Display(Name = "Қолжетімді")]
        public bool AsykAvailable { get; set; }

        [Display(Name = "Санаты")]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Resources))]
        [Range(1, 2, ErrorMessage = "Санаты дұрыс толтырылған жоқ!")]
        public int CategoryId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public virtual Category Category {get; set;}
    }
}
