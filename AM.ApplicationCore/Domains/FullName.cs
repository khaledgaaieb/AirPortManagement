using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domains
{
   // [Owned] // either this or passengerConfig
    public class FullName
    {
        [MinLength(3, ErrorMessage = "min liength must be > 3 ")]
        [MaxLength(25, ErrorMessage = "max liength must be < 25 ")]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
