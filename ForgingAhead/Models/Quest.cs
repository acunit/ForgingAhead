using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ForgingAhead.Models
{
    public class Quest
    {
        [Key]
        public string Name { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        // set up relationship here
        public List<Character> Characters { get; set; } = new List<Character>();
    }
}
