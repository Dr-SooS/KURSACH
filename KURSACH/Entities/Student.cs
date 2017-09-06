using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KURSACH
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Enterance { get; set; }

        [Required]
        public virtual Group Group { get; set; }
        public virtual List<Mark> Marks { get; set; }
		public virtual List<Absence> Absences { get; set; }
		public virtual List<LabWork> LabWorks { get; set; }
    }
}
