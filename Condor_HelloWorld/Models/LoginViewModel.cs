using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Condor_HelloWorld.Models
{
    public class LoginViewModel
    {
        [Required]
        public string username { get; set; }
        
        [Required]
        public string password { get; set; }
        public bool RememberMe { get; set; }

    }
}