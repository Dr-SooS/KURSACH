using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KURSACH
{
    public class Group
    {
        public int GroupId { get; set; }
        public int Number { get; set; }

        [Required]
        public virtual Specialty Specialty { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}
