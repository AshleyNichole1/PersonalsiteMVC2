using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ContactAction
    {

        [Required(ErrorMessage = "*")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "*")]
        [UIHint("MultilineText")] //Larger Text Box
        public string Message { get; set; }

    }

}
