using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KURSACH
{
    public class Mark
    {
        public int MarkId { get; set; }
        public int Value { get; set; }

        [Required]
        public virtual Student Student { get; set; }
        [Required]
        public virtual Teacher Teacher { get; set; }
        [Required]
        public virtual Subject Subject { get; set; }
        [Required]
        public virtual ControlPoint ControlPoint { get; set; }
    }
}
