using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Condor_HelloWorld.Models
{
    public class QSViewModel
    {
        [Required]
        public string shitYouSearched { get; set; }
    }
}