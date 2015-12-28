using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Condor_HelloWorld.Models
{
    public class PostJobViewModel
    {

        
        public int id { get; set; }

        [Required(ErrorMessage="Yo! Enter the title yo!")]
        public string title { get; set; }
        public double salary { get; set; }
        public int AccessLevel { get; set; }
    }
}