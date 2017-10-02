using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace KURSACH
{
	class BL
	{
		public static Mark GetMark(ControlPoint cp, Student student, Subject subject)
		{
			return subject.Marks.FirstOrDefault(m => m.ControlPoint.ControlPointId == cp.ControlPointId && m.Student.StudentId == student.StudentId);
		}

		public static Absence GetAbsence(ControlPoint cp, Student student, Subject subject)
		{
			return subject.Absences.FirstOrDefault(m => m.ControlPoint.ControlPointId == cp.ControlPointId && m.Student.StudentId == student.StudentId);
		}

		public static LabWork GetLabWork(ControlPoint cp, Student student, Subject subject)
		{
			return subject.LabWorks.FirstOrDefault(m => m.ControlPoint.ControlPointId == cp.ControlPointId && m.Student.StudentId == student.StudentId);
		}

		public static void EditMark(CollegeContext db, ControlPoint cp, Student student, Subject subject, Teacher teacher, string newValue)
		{
			var mark = subject.Marks.FirstOrDefault(m => m.ControlPoint.ControlPointId == cp.ControlPointId && m.Student.StudentId == student.StudentId && m.Teacher.TeacherId == teacher.TeacherId);
			if (newValue == null)
			{
				if (mark != null)
					db.Marks.Remove(mark);
			}
			else
			{
				if (mark != null)
					if (newValue == "-")
						mark.NoValue = true;
					else
					{
						mark.NoValue = false;
						mark.Value = int.Parse(newValue);
					}
				else
				{
					if (newValue == "-")
						db.Marks.Add(new Mark { NoValue = true, Subject = subject, Student = student, ControlPoint = cp, Teacher = teacher});
					else
						db.Marks.Add(new Mark { Value = int.Parse(newValue), Subject = subject, Student = student, ControlPoint = cp, Teacher = teacher});
				}
			}
		}

		public static void EditAbsence(CollegeContext db, ControlPoint cp, Student student, Subject subject, Teacher teacher, string newValue)
		{
			var absence = subject.Absences.FirstOrDefault(m => m.ControlPoint.ControlPointId == cp.ControlPointId && m.Student.StudentId == student.StudentId && m.Teacher.TeacherId == teacher.TeacherId);
			if (newValue == null)
			{
				if (absence != null)
					db.Absences.Remove(absence);
			}
			else
			{
				if (absence != null)
					absence.Count = int.Parse(newValue);
				else
				{
					db.Absences.Add(new Absence { Count = int.Parse(newValue), Subject = subject, Student = student, ControlPoint = cp, Teacher = teacher });
				}
			}
		}

		public static void EditLabWork(CollegeContext db, ControlPoint cp, Student student, Subject subject, Teacher teacher, string newValue)
		{
			var lab = subject.LabWorks.FirstOrDefault(m => m.ControlPoint.ControlPointId == cp.ControlPointId && m.Student.StudentId == student.StudentId && m.Teacher.TeacherId == teacher.TeacherId);
			if (newValue == null)
			{
				if (lab != null)
					db.LabWorks.Remove(lab);
			}
			else
			{
				if (lab != null)
					lab.NotPassed = int.Parse(newValue);
				else
				{
					db.LabWorks.Add(new LabWork { NotPassed = int.Parse(newValue), Subject = subject, Student = student, ControlPoint = cp, Teacher = teacher });
				}
			}
		}

		public static bool MarkIsBad(Mark mark)
		{
			return mark.Value < 4 || mark.NoValue;
		}

		public static bool AbsenceIsBad(Absence absence)
		{
			return absence.Count > 8;
		}

		public static bool LabWorkIsBad(LabWork labWork)
		{
			return labWork.NotPassed > 0;
		}

		public static int CountStudentsWithBadMarks(CollegeContext db, Group group, ControlPoint cp)
		{
			int c = 0;
			foreach(var student in db.Students.Where(s => s.Group.GroupId == group.GroupId).ToList())
				foreach (var m in student.Marks.Where(m => m.ControlPoint.ControlPointId == cp.ControlPointId))
					if (MarkIsBad(m))
					{
						c++;
						break;
					}
			return c;
		}

		public static int CountStudentsWithNotPassedLabs(CollegeContext db, Group group, ControlPoint cp)
		{
			int c = 0;
			foreach (var student in db.Students.Where(s => s.Group.GroupId == group.GroupId).ToList())
				foreach (var m in student.LabWorks.Where(m => m.ControlPoint.ControlPointId == cp.ControlPointId))
					if (LabWorkIsBad(m))
					{
						c++;
						break;
					}
			return c;
		}

		public static int CountStudentsWithALotOfAbsences(CollegeContext db, Group group, ControlPoint cp)
		{
			int c = 0;
			foreach (var student in db.Students.Where(s => s.Group.GroupId == group.GroupId).ToList())
				foreach (var m in student.Absences.Where(m => m.ControlPoint.ControlPointId == cp.ControlPointId))
					if (AbsenceIsBad(m))
					{
						c++;
						break;
					}
			return c;
		}

		public static List<Tuple<Teacher, Subject>> GetGroupProblemSubjectsTeschers(CollegeContext db, Group group, ControlPoint cp)
		{
			var res = new List<Tuple<Teacher, Subject>>();
			foreach (var mark in db.Marks.Where(m => m.Student.Group.GroupId == group.GroupId && m.ControlPoint.ControlPointId == cp.ControlPointId))
				if (!res.Contains(Tuple.Create(mark.Teacher, mark.Subject)) && MarkIsBad(mark))
					res.Add(Tuple.Create(mark.Teacher, mark.Subject));

			foreach (var lab in db.LabWorks.Where(m => m.Student.Group.GroupId == group.GroupId && m.ControlPoint.ControlPointId == cp.ControlPointId))
				if (!res.Contains(Tuple.Create(lab.Teacher, lab.Subject)) && LabWorkIsBad(lab))
					res.Add(Tuple.Create(lab.Teacher, lab.Subject));

			foreach (var abs in db.Absences.Where(m => m.Student.Group.GroupId == group.GroupId && m.ControlPoint.ControlPointId == cp.ControlPointId))
				if (!res.Contains(Tuple.Create(abs.Teacher, abs.Subject)) && AbsenceIsBad(abs))
					res.Add(Tuple.Create(abs.Teacher, abs.Subject));

			return res;
		}

		public static List<Tuple<Teacher, Subject>> GetStudentProblemSubjectsTeschers(Student student, ControlPoint cp)
		{
			var res = new List<Tuple<Teacher, Subject>>();
			foreach (var mark in student.Marks.Where(m => m.ControlPoint.ControlPointId == cp.ControlPointId))
				if (!res.Contains(Tuple.Create(mark.Teacher, mark.Subject)) && MarkIsBad(mark))
					res.Add(Tuple.Create(mark.Teacher, mark.Subject));

			foreach (var lab in student.LabWorks.Where(m => m.ControlPoint.ControlPointId == cp.ControlPointId))
				if (!res.Contains(Tuple.Create(lab.Teacher, lab.Subject)) && LabWorkIsBad(lab))
					res.Add(Tuple.Create(lab.Teacher, lab.Subject));

			foreach (var abs in student.Absences.Where(m => m.ControlPoint.ControlPointId == cp.ControlPointId))
				if (!res.Contains(Tuple.Create(abs.Teacher, abs.Subject)) && AbsenceIsBad(abs))
					res.Add(Tuple.Create(abs.Teacher, abs.Subject));

			return res;
		}

		public static bool IfStudentHasProblems(Student student, ControlPoint cp)
		{
			foreach (var mark in student.Marks.Where(m => m.ControlPoint.ControlPointId == cp.ControlPointId))
				if (MarkIsBad(mark))
					return true;

			foreach (var abs in student.Absences.Where(a => a.ControlPoint.ControlPointId == cp.ControlPointId))
				if (AbsenceIsBad(abs))
					return true;

			foreach (var lab in student.LabWorks.Where(s => s.ControlPoint.ControlPointId == cp.ControlPointId))
				if (LabWorkIsBad(lab))
					return true;
			return false;
		}

		public static dynamic GetStudentStats(ControlPoint cp, Student student)
		{
			var marks = cp.Marks.Where(i => i.Student.StudentId == student.StudentId).ToList();
			var abs = cp.Absences.Where(i => i.Student.StudentId == student.StudentId).ToList();
			var labs = cp.LabWorks.Where(i => i.Student.StudentId == student.StudentId).ToList();
			return marks.Zip(abs.Zip(labs, Tuple.Create), (mark, tuple) => new { Mark = mark, Absence = tuple.Item1, LabWork = tuple.Item2 });
		}

		public static void StatsToExcel(string filename, CollegeContext db)
		{
			ExcelPackage ExcelPkg = new ExcelPackage();
			ExcelWorksheet wsSheet1 = ExcelPkg.Workbook.Worksheets.Add("Sheet1");
			//
			ExcelPkg.SaveAs(new FileInfo(@"C:\KURSACH\s.xlsx"));
		}
	}
}
