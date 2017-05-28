using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KURSACH
{
    public class collegeContext: DbContext
    {
        public collegeContext(): base("collegeContext") { }

        public DbSet<Mark> Marks { get; set; }
		public DbSet<Absence> Absences { get; set; }
		public DbSet<LabWork> LabWorks { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ControlPoint> ControlPoints { get; set; }
    }
}
