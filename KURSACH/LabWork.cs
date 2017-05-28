using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH
{
	public class LabWork
	{
		public int LabWorkId { get; set; }
		public string Passed { get; set; }
		public string NotPassed { get; set; }

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
