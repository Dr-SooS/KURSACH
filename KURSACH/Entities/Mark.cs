using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH
{
    public class Mark
    {
        public int MarkId { get; set; }
        public string Value { get; set; }

        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual ControlPoint ControlPoint { get; set; }
    }
}
