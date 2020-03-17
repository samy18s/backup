using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FirstMvc.Models
{
    public class GetResponses
    {
        [Required(ErrorMessage ="Please Enter Your Name")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage = "Please enter correct email address")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
        ErrorMessage = "Entered phone format is not valid.")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Please Give Your Confirmation..")]
        public Nullable <bool> WillAttend { get; set; }
    }
    
}