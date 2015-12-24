using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UserDetails
    {
        [StringLength(20,MinimumLength = 2, ErrorMessage = "UserName length should be between 2 and 20")]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
