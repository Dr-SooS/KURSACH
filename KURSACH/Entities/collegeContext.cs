using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OfficeOpenXml;
using System.IO;

namespace KURSACH
{
    public class CollegeContext: DbContext
    {
        public CollegeContext(): base("collegeContext") { }

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

		public void SeedDb()
		{
			//var dep = Departments.Add(new Department { Name = "КТ", Code = 1 });
			//var sepc = Specialties.Add(new Specialty { Name = "ПОИТ", Code = 1, Department = dep });
			//var gr = Groups.Add(new Group { Number = 42491, Specialty = sepc });

			//FileInfo newFile = new FileInfo(Directory.GetCurrentDirectory() + "\\st.xlsx");
			//ExcelPackage pck = new ExcelPackage(newFile);
			//ExcelWorksheet sheet = pck.Workbook.Worksheets[1];

			//for(int i = 1; sheet.Cells[i, 1].Value != null; i++)
			//{
			//	var ln = sheet.Cells[i, 1].Value.ToString().Split(' ')[0];
			//	var fn = sheet.Cells[i, 1].Value.ToString().Split(' ')[1];
			//	var mn = sheet.Cells[i, 1].Value.ToString().Split(' ')[2];
			//	Students.Add(new Student { Group = gr, FirstName = fn, MiddleName = mn, LastName = ln });
			//}

			var cp1 = ControlPoints.Add(new ControlPoint { Date = DateTime.ParseExact("30.09 2017", "dd.MM yyyy", null) });
			var cp2 = ControlPoints.Add(new ControlPoint { Date = DateTime.ParseExact("30.10 2017", "dd.MM yyyy", null) });
			var cp3 = ControlPoints.Add(new ControlPoint { Date = DateTime.ParseExact("30.11 2017", "dd.MM yyyy", null) });

			var sub1 = Subjects.Add(new Subject { Name = "КПиЯП" });
			var teacher1 = Teachers.Add(new Teacher { FirstName = "Марина", MiddleName = "Анатольевна", LastName = "Бельчик" });

			var sub2 = Subjects.Add(new Subject { Name = "БДиСУБД" });
			var teacher2 = Teachers.Add(new Teacher { FirstName = "Ольга", MiddleName = "Николаевна", LastName = "Виничук" });

			var sub3 = Subjects.Add(new Subject { Name = "ПСИП" });
			foreach (var student in Students.ToList())
			{
				student.Marks.Add(new Mark { Value = new Random().Next(3, 10), ControlPoint = cp1, Student = student, Subject = sub1, Teacher = teacher1 });
				student.Marks.Add(new Mark { Value = new Random().Next(3, 10), ControlPoint = cp2, Student = student, Subject = sub1, Teacher = teacher1 });
				student.Marks.Add(new Mark { Value = new Random().Next(3, 10), ControlPoint = cp3, Student = student, Subject = sub1, Teacher = teacher1 });

				student.Absences.Add(new Absence { Count = 0, ControlPoint = cp1, Student = student, Subject = sub1, Teacher = teacher1 });
				student.Absences.Add(new Absence { Count = 0, ControlPoint = cp2, Student = student, Subject = sub1, Teacher = teacher1 });
				student.Absences.Add(new Absence { Count = 0, ControlPoint = cp3, Student = student, Subject = sub1, Teacher = teacher1 });

				student.LabWorks.Add(new LabWork { NotPassed = 0, ControlPoint = cp1, Student = student, Subject = sub1, Teacher = teacher1 });
				student.LabWorks.Add(new LabWork { NotPassed = 0, ControlPoint = cp2, Student = student, Subject = sub1, Teacher = teacher1 });
				student.LabWorks.Add(new LabWork { NotPassed = 0, ControlPoint = cp3, Student = student, Subject = sub1, Teacher = teacher1 });
			}

			foreach(var student in Students.ToList())
			{
				student.Marks.Add(new Mark { Value = new Random().Next(3, 10), ControlPoint = cp1, Student = student, Subject = sub2, Teacher = teacher2 });
				student.Marks.Add(new Mark { Value = new Random().Next(3, 10), ControlPoint = cp2, Student = student, Subject = sub2, Teacher = teacher2 });
				student.Marks.Add(new Mark { Value = new Random().Next(3, 10), ControlPoint = cp3, Student = student, Subject = sub2, Teacher = teacher2 });

				student.Absences.Add(new Absence { Count = 0, ControlPoint = cp1, Student = student, Subject = sub2, Teacher = teacher2 });
				student.Absences.Add(new Absence { Count = 0, ControlPoint = cp2, Student = student, Subject = sub2, Teacher = teacher2 });
				student.Absences.Add(new Absence { Count = 0, ControlPoint = cp3, Student = student, Subject = sub2, Teacher = teacher2 });

				student.LabWorks.Add(new LabWork { NotPassed = 0, ControlPoint = cp1, Student = student, Subject = sub2, Teacher = teacher2 });
				student.LabWorks.Add(new LabWork { NotPassed = 0, ControlPoint = cp2, Student = student, Subject = sub2, Teacher = teacher2 });
				student.LabWorks.Add(new LabWork { NotPassed = 0, ControlPoint = cp3, Student = student, Subject = sub2, Teacher = teacher2 });
			}

			foreach(var student in Students.ToList())
			{
				student.Marks.Add(new Mark { Value = new Random().Next(3, 10), ControlPoint = cp1, Student = student, Subject = sub3, Teacher = teacher2 });
				student.Marks.Add(new Mark { Value = new Random().Next(3, 10), ControlPoint = cp2, Student = student, Subject = sub3, Teacher = teacher2 });
				student.Marks.Add(new Mark { Value = new Random().Next(3, 10), ControlPoint = cp3, Student = student, Subject = sub3, Teacher = teacher2 });

				student.Absences.Add(new Absence { Count = 0, ControlPoint = cp1, Student = student, Subject = sub3, Teacher = teacher2 });
				student.Absences.Add(new Absence { Count = 0, ControlPoint = cp2, Student = student, Subject = sub3, Teacher = teacher2 });
				student.Absences.Add(new Absence { Count = 0, ControlPoint = cp3, Student = student, Subject = sub3, Teacher = teacher2 });

				student.LabWorks.Add(new LabWork { NotPassed = 0, ControlPoint = cp1, Student = student, Subject = sub3, Teacher = teacher2 });
				student.LabWorks.Add(new LabWork { NotPassed = 0, ControlPoint = cp2, Student = student, Subject = sub3, Teacher = teacher2 });
				student.LabWorks.Add(new LabWork { NotPassed = 0, ControlPoint = cp3, Student = student, Subject = sub3, Teacher = teacher2 });
			}
			this.SaveChanges();
		}
    }
}
