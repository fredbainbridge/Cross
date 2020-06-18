using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cross.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Alias { get; set; }
    }
}
