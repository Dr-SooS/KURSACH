using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH
{
	class CalculationUtils
	{
		public static int CountStudentsWithBadMarks(CollegeContext db, Group group, ControlPoint cp)
		{
			int c = 0;
			foreach(var student in db.Students.Where(s => s.Group.GroupId == group.GroupId).ToList())
				foreach (var m in student.Marks.Where(m => m.ControlPoint.ControlPointId == cp.ControlPointId))
					if (m.Value < 4)
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
					if (m.NotPassed > 0)
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
					if (m.Count > 8)
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
				if (!res.Contains(Tuple.Create(mark.Teacher, mark.Subject)))
					res.Add(Tuple.Create(mark.Teacher, mark.Subject));
			return res;
		}

		public static bool IfStudentHasProblems(Student student, ControlPoint cp)
		{
			foreach (var mark in student.Marks.Where(m => m.ControlPoint.ControlPointId == cp.ControlPointId))
			{
				if (mark.Value < 4)
					return true;
			}

			foreach (var abs in student.Absences.Where(a => a.ControlPoint.ControlPointId == cp.ControlPointId))
			{
				if (abs.Count > 8)
					return true;
			}

			foreach (var lab in student.LabWorks.Where(s => s.ControlPoint.ControlPointId == cp.ControlPointId))
			{
				if (lab.ControlPoint == cp && lab.NotPassed > 0)
					return true;
			}
			return false;
		}
	}
}
