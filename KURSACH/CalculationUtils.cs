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
			foreach (var m in db.Marks.Where(m => m.Student.Group.Number == group.Number))
				if (m.ControlPoint.Date == cp.Date)
					if (m.Value < 4)
						c++;
			return c;
		}

		public static int CountStudentsWithNotPassedLabs(CollegeContext db, Group group, ControlPoint cp)
		{
			int c = 0;
			foreach (var m in db.LabWorks.Where(m => m.Student.Group.Number == group.Number))
				if (m.ControlPoint.Date == cp.Date)
					if (m.NotPassed > 0)
						c++;
			return c;
		}

		public static int CountStudentsWithALotOfAbsences(CollegeContext db, Group group, ControlPoint cp)
		{
			int c = 0;
			foreach (var m in db.Absences.Where(m => m.Student.Group.Number == group.Number))
				if (m.ControlPoint.Date == cp.Date)
					if (m.Count > 8)
						c++;
			return c;
		}
	}
}
