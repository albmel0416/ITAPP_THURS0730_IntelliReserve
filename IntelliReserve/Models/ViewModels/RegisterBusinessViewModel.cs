﻿using IntelliReserve.Models;
using System.ComponentModel.DataAnnotations;

public class RegisterBusinessViewModel
{
    // User information
    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
    public string Password { get; set; }

    public int OwnerId { get; set; }
    public UserRole? Role { get; set; }

    // Business information
    [Required(ErrorMessage = "Organization name is required.")]
    public string OrganizationName { get; set; }

    [Required(ErrorMessage = "Address is required.")]
    public string Address { get; set; }

    [Required(ErrorMessage = "Phone number is required.")]
    public string Phone { get; set; }

    [Required(ErrorMessage = "Description is required.")]
    public string Description { get; set; }
}
