﻿using System.ComponentModel.DataAnnotations;

namespace Truckrrapp.Application.DTOs.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}