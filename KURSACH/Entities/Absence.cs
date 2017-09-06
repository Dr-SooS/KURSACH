using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH
{
	public class Absence
	{
		public int AbsenceId { get; set; }
		public int Count { get; set; }
		public int RespectCount { get; set; }

		[Required]
		public virtual Student Student { get; set; }
		[Required]
		public virtual Teacher Teacher { get; set; }
		[Required]
		public virtual Subject Subject { get; set; }
		[Required]
		public virtual ControlPoint ControlPoint { get; set; }
	}
}
