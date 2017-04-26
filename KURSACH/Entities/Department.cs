using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH
{
    class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }

        public virtual List<Specialty> Specialties { get; set; }
    }
}
