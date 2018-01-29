using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Presentation.Models
{
    public class SearchViewModel
    {
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, ErrorMessage = "First name can be at most 50 characters")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, ErrorMessage = "Last name can be at most 50 characters")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [StringLength(50, ErrorMessage = "Email can be at most 50 characters")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [Display(Name = "Age")]
        [Range(10, 200)]
        public int AgeTo { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [Display(Name = "Age")]
        [Range(10, 200)]
        public int AgeFrom { get; set; }

        [Required(ErrorMessage = "Sex is required.")]
        [Display(Name = "Sex")]
        public int Sex { get; set; }

        [Required(ErrorMessage = "Height is required.")]
        [Display(Name = "Height")]
        [Range(2, 10.0)]
        public decimal HeightTo { get; set; }

        [Required(ErrorMessage = "Height is required.")]
        [Display(Name = "Height")]
        [Range(2, 10.0)]
        public decimal HeightFrom { get; set; }

        [Required(ErrorMessage = "Weight is required.")]
        [Display(Name = "Weight")]
        [Range(20, 200.0)]
        public int WeightTo { get; set; }

        [Required(ErrorMessage = "Weight is required.")]
        [Display(Name = "Weight")]
        [Range(20, 200.0)]
        public int WeightFrom { get; set; }

        [Required(ErrorMessage = "Nationality is required.")]
        [StringLength(50, ErrorMessage = "Nationality can be at most 50 characters")]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        public enum Gender
        {
            Female = 0,
            Male = 1
        };

    }

}