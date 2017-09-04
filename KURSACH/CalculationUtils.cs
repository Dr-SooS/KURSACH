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
			foreach (var m in db.Marks.Where(m => m.Student.Group.Number == group.Number && m.ControlPoint.Date.ToString("dd.MM yyyy") == cp.Date.ToString("dd.MM yyyy")))
				if (int.Parse(m.Value) < 4)
					c++;
			return c;
		}
	}
}
