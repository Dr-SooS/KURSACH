using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KURSACH
{
    public class Specialty
    {
        public int SpecialtyId { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }

        [Required]
        public virtual Department Department { get; set; }
        public virtual List<Group> Groups { get; set; } 
    }
}
