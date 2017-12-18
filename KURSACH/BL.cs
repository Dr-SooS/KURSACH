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
			var mark = subject.Marks.FirstOrDefault(
				m => m.ControlPoint.ControlPointId == cp.ControlPointId 
				&& m.Student.StudentId == student.StudentId 
				&& m.Teacher.TeacherId == teacher.TeacherId);
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

		public static void EditAbsence(CollegeContext db, ControlPoint cp, Student student, Subject subject, Teacher teacher, string newValue)
		{
			var absence = subject.Absences.FirstOrDefault(m => m.ControlPoint.ControlPointId == cp.ControlPointId && m.Student.StudentId == student.StudentId && m.Teacher.TeacherId == teacher.TeacherId);
			if (absence != null)
				absence.Count = int.Parse(newValue);
			else
			{
				db.Absences.Add(new Absence { Count = int.Parse(newValue), Subject = subject, Student = student, ControlPoint = cp, Teacher = teacher });
			}
		}

		public static void EditLabWork(CollegeContext db, ControlPoint cp, Student student, Subject subject, Teacher teacher, string newValue)
		{
			var lab = subject.LabWorks.FirstOrDefault(m => m.ControlPoint.ControlPointId == cp.ControlPointId && m.Student.StudentId == student.StudentId && m.Teacher.TeacherId == teacher.TeacherId);
			if (lab != null)
				lab.NotPassed = int.Parse(newValue);
			else
			{
				db.LabWorks.Add(new LabWork { NotPassed = int.Parse(newValue), Subject = subject, Student = student, ControlPoint = cp, Teacher = teacher });
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

		public static List<Tuple<Teacher, Subject>> GetGroupProblemSubjectsTeachers(CollegeContext db, Group group, ControlPoint cp)
		{
			var res = new List<Tuple<Teacher, Subject>>();
			foreach (var mark in db.Marks.ToList().Where(m => m.Student.Group.GroupId == group.GroupId && m.ControlPoint.ControlPointId == cp.ControlPointId))
				if (!res.Contains(Tuple.Create(mark.Teacher, mark.Subject)) && MarkIsBad(mark))
					res.Add(Tuple.Create(mark.Teacher, mark.Subject));

			foreach (var lab in db.LabWorks.ToList().Where(m => m.Student.Group.GroupId == group.GroupId && m.ControlPoint.ControlPointId == cp.ControlPointId))
				if (!res.Contains(Tuple.Create(lab.Teacher, lab.Subject)) && LabWorkIsBad(lab))
					res.Add(Tuple.Create(lab.Teacher, lab.Subject));

			foreach (var abs in db.Absences.ToList().Where(m => m.Student.Group.GroupId == group.GroupId && m.ControlPoint.ControlPointId == cp.ControlPointId))
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

		public static void StatsToExcel(string filename, CollegeContext db, ControlPoint cp)
		{
			ExcelPackage ExcelPkg = new ExcelPackage();
			ExcelWorksheet wsSheet1 = ExcelPkg.Workbook.Worksheets.Add("Sheet1");

			var groups = db.Groups.ToList();

			wsSheet1.Cells[1, 1].Value = "# группы";
			wsSheet1.Cells[1, 2].Value = "Количество учащихся";
			wsSheet1.Cells[1, 3].Value = "Кол-во уч-ся, которые имеют отрицательные отметки";
			wsSheet1.Cells[1, 4].Value = "Кол-во уч-ся, которые имеют много пропусков";
			wsSheet1.Cells[1, 5].Value = "кол-во уч-ся, у которых есть не сданные л.р.";

			wsSheet1.Cells[1, 1, 1, 5].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
			wsSheet1.Cells[1, 1, 1, 5].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
			wsSheet1.Cells[1, 1, 1, 5].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
			wsSheet1.Cells[1, 1, 1, 5].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

			wsSheet1.Cells[1, 3, 1, 5].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
			wsSheet1.Cells[1, 1, 1, 2].Style.TextRotation = 90;
			wsSheet1.Cells[1, 3, 1, 5].Style.WrapText = true;

			wsSheet1.Column(3).Width = 20;
			wsSheet1.Column(4).Width = 20;
			wsSheet1.Column(5).Width = 20;

			for (int i = 2; i <= groups.Count + 1; i++)
			{
				var marks = (double)CountStudentsWithBadMarks(db, groups[i - 2], cp) / groups[i - 2].Students.Count * 100;
				var abs = (double)CountStudentsWithALotOfAbsences(db, groups[i - 2], cp) / groups[i - 2].Students.Count * 100;
				var labs = (double)CountStudentsWithNotPassedLabs(db, groups[i - 2], cp) / groups[i - 2].Students.Count * 100;
				wsSheet1.Cells[i, 1].Value = groups[i - 2].Number;
				wsSheet1.Cells[i, 2].Value = groups[i - 2].Students.Count;
				wsSheet1.Cells[i, 3].Value = $"{CountStudentsWithBadMarks(db, groups[i - 2], cp)} ({marks}%)";
				wsSheet1.Cells[i, 4].Value = $"{CountStudentsWithNotPassedLabs(db, groups[i - 2], cp)} ({abs}%)";
				wsSheet1.Cells[i, 5].Value = $"{CountStudentsWithALotOfAbsences(db, groups[i - 2], cp)} ({labs}%)";

				wsSheet1.Cells[i, 1, i, 5].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
				wsSheet1.Cells[i, 1, i, 5].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
				wsSheet1.Cells[i, 1, i, 5].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
				wsSheet1.Cells[i, 1, i, 5].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
			}
				

			ExcelPkg.SaveAs(new FileInfo(filename));
		}
	}
}
