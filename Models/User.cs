using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BookmeFresh.Models
{
    public class User: IdentityUser
    {
        Guid id { get; set; }
        
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Characters are not allowed.")]
        public string? Fname {get; set;}

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters.")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Characters are not allowed.")]
        public string? Lname { get; set;}


        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        [StringLength(50, ErrorMessage = "Email cannot be longer than 50 characters.")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set;}

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set;}

        [Required]
        [Display(Name = "Role")]
        [StringLength(50, ErrorMessage = "Role cannot be longer than 50 characters.")]
        public string? Role { get; set;}

        [Required]
        [Display(Name = "Phone")]
        [StringLength(15, ErrorMessage = "Phone cannot be longer than 50 characters.")]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set;}

    }
}