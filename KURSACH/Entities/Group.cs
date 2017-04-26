using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH
{
    class Group
    {
        public int GroupId { get; set; }
        public int Number { get; set; }

        public virtual Specialty Specialty { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}
