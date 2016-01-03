using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Condor_HelloWorld.Models
{
    public class CreateViewModel
    {
   
        [Required]
        public string email { get; set; }
        [Required]
        public string fullName { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        [Compare("password")]
        public string confirmationPassword { get; set; }
        
    }
}