using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH
{
    public class ControlPoint
    {
        public int ControlPointId { get; set; }
        public DateTime Date { get; set; }

        public virtual List<Mark> Marks { get; set; }
    }
}
