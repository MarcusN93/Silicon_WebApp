﻿using System.ComponentModel.DataAnnotations;
using WebApp.Filters;

namespace WebApp.ViewModels;

public class SignUpViewModel
{
    [Required(ErrorMessage = "You must enter a first name")]
    [Display(Name = "First name", Prompt = "Enter your first name")]
    public string FirstName { get; set; } = null!;

    [Required(ErrorMessage = "You must enter a last name")]
    [Display(Name = "Last name ", Prompt = "Enter your last name")]
    public string LastName { get; set; } = null!;

    [Required(ErrorMessage = "You must enter a valid e-mail address")]
    [Display(Name = "E-mail address", Prompt = "Enter your e-mail address")]
    [DataType(DataType.EmailAddress)]

    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Enter a valid password")]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Required(ErrorMessage = "Password must be confirmed")]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
    public string ConfirmPassword { get; set; } = null!;

    [CheckboxRequired(ErrorMessage = "You must accept the terms and conditions")]
    [Display(Name = "I Agree to the Terms & Conditions.", Prompt = "Terms and Conditions")]
    public bool TermsAndConditions { get; set; }
}
