﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechTreeMVCWebApplication.Models
{
    public class RegistrationModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="User Name")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(100,MinimumLength =2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^(?:\+254|254)(\d{9})$")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        public bool AcceptUserAgreement { get; set; }
        public string RegistrationInValid { get; set; }
        public int CategoryId { get; set; }

    }
}
