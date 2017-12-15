using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSACH.Forms.CRUD_Teachers
{
	public partial class EditTeacherSubject : Form
	{
		CollegeContext db;
		dynamic parent;
		bool create;

		public EditTeacherSubject()
		{
			InitializeComponent();
		}

		public EditTeacherSubject(TeacherCreate parent, bool create)
		{
			InitializeComponent();
			db = parent.db;
			this.parent = parent;
			this.create = create;

			comboBox1.Items.Add("Выберите предмет");
			if (create)
			{
				foreach (var subject in db.Subjects.ToList())
					if (!parent.teacherSubjects.Contains(subject.Name))
						comboBox1.Items.Add(subject.Name);
			}
			else
			{
				foreach (var subject in db.Subjects.ToList())
					if (parent.teacherSubjects.Contains(subject.Name))
						comboBox1.Items.Add(subject.Name);
			}
			comboBox1.SelectedIndex = 0;

			button1.Enabled = false;
		}

		public EditTeacherSubject(TeacherUpdate parent, bool create)
		{
			InitializeComponent();
			db = parent.db;
			this.parent = parent;
			this.create = create;

			comboBox1.Items.Add("Выберите предмет");
			if (create)
			{
				foreach (var subject in db.Subjects.ToList())
					if (!parent.teacherSubjects.Contains(subject.Name))
						comboBox1.Items.Add(subject.Name);
			}
			else
			{
				foreach (var subject in db.Subjects.ToList())
					if (parent.teacherSubjects.Contains(subject.Name))
						comboBox1.Items.Add(subject.Name);
			}
			comboBox1.SelectedIndex = 0;

			button1.Enabled = false;
		}


		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex != 0)
			{
				parent.selectedSubject = db.Subjects.FirstOrDefault(s => s.Name == comboBox1.SelectedItem.ToString());
				button1.Enabled = true;
			}
			else
			{
				parent.selectedSubject = null;
				button1.Enabled = false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
