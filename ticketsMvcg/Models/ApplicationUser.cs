﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ticketsMvcg.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Display(Name = "Nombre completo")]
        public string FullName { get; set; }
    }
}
