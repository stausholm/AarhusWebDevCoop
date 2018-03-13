using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AarhusWebDevCoop.ViewModels
{
    public class ContactForm
    {
        [Required(ErrorMessage = "Please enter your name")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Please enter email address")]
        [Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessage = "Please enter correct email address")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Please enter a subject")]
        public String Subject { get; set; }

        [Required(ErrorMessage = "Please enter a message")]
        public String Message { get; set; }
    }
}
