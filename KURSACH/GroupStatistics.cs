using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSACH
{
	public partial class GroupStatistics : Form
	{
		CollegeContext db;

		Specialty selectedSpecialty;
		Group selectedGroup;
		ControlPoint selectedCP;
		Student selectedStudent;

		public GroupStatistics(CollegeContext db)
		{
			InitializeComponent();

			this.db = db;

			specialtyComboBox.Items.Add("Все специльности");
			foreach (var spec in db.Specialties)
				specialtyComboBox.Items.Add(spec.Name);
			specialtyComboBox.SelectedIndex = 0;

			cpComboBox.Items.Add("Выберите КТ");
			foreach (var cp in db.ControlPoints)
				cpComboBox.Items.Add(cp.Date.ToString("dd.MM yyyy"));
			cpComboBox.SelectedIndex = 0;
		}

		public void LoadStudentMarks()
		{
			studentMarksDataGridView.Rows.Clear();
			if (selectedStudent != null)
			{
				var stats = BL.GetStudentStats(selectedCP, selectedStudent);
				foreach (var stat in stats)
				{
					if (stat.Mark.NoValue)
						studentMarksDataGridView.Rows.Add(stat.Mark.Subject.Name, "-", stat.Absence.Count.ToString(), stat.LabWork.NotPassed.ToString());
					else
						studentMarksDataGridView.Rows.Add(stat.Mark.Subject.Name, stat.Mark.Value.ToString(), stat.Absence.Count.ToString(), stat.LabWork.NotPassed.ToString());
				}
			}
		}

		public void WriteGroupStatistics()
		{
			groupProblemsRichTextBox.Clear();
			if (selectedCP != null && selectedGroup != null)
			{
				lowMarksLabel.Text = BL.CountStudentsWithBadMarks(db, selectedGroup, selectedCP).ToString();
				notAllLabsLabel.Text = BL.CountStudentsWithNotPassedLabs(db, selectedGroup, selectedCP).ToString();
				manyAbsLabel.Text = BL.CountStudentsWithALotOfAbsences(db, selectedGroup, selectedCP).ToString();
				foreach (var problem in BL.GetGroupProblemSubjectsTeschers(db, selectedGroup, selectedCP))
					groupProblemsRichTextBox.AppendText(problem.Item1.LastName + " - " + problem.Item2.Name + Environment.NewLine);
			}
		}

		public void WriteStudentStatistics()
		{
			studentProblemsRichRextBox.Clear();
			if (selectedStudent != null)
			{
				foreach (var problem in BL.GetStudentProblemSubjectsTeschers(selectedStudent, selectedCP))
					studentProblemsRichRextBox.AppendText(problem.Item1.LastName + " - " + problem.Item2.Name + Environment.NewLine);
			}
		}

		public void LoadStudents()
		{
			studentListView.Items.Clear();
			if (selectedGroup != null)
				foreach (var student in db.Students.Where(s => s.Group.GroupId == selectedGroup.GroupId).OrderBy(s => s.LastName).ThenBy(s => s.FirstName).ToList())
					if (BL.IfStudentHasProblems(student, selectedCP))
						studentListView.Items.Add(student.ToString()).BackColor = Color.Goldenrod;
					else
						studentListView.Items.Add(student.ToString());
		}

		private void specialtyCombobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (specialtyComboBox.SelectedIndex != 0)
			{
				selectedSpecialty = db.Specialties.FirstOrDefault(s => s.Name == specialtyComboBox.SelectedItem.ToString());
				groupComboBox.Items.Clear();
				groupComboBox.Items.Add("Выберите группу");
				foreach (var g in db.Groups.Where(g => g.Specialty.SpecialtyId == selectedSpecialty.SpecialtyId))
					groupComboBox.Items.Add(g.Number.ToString());
				groupComboBox.SelectedIndex = 0;
			}
			else
			{
				selectedSpecialty = null;
				groupComboBox.Items.Clear();
				groupComboBox.Items.Add("Выберите группу");
				foreach (var g in db.Groups)
					groupComboBox.Items.Add(g.Number.ToString());
				groupComboBox.SelectedIndex = 0;
			}
		}

		private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (groupComboBox.SelectedIndex != 0)
			{
				int num = Convert.ToInt32(groupComboBox.SelectedItem);
				selectedGroup = db.Groups.FirstOrDefault(g => g.Number == num);

				LoadStudents();

				if (selectedCP != null)
					WriteGroupStatistics();
			}
			else
			{
				selectedGroup = null;
				studentListView.Items.Clear();
			}
		}

		private void cpComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cpComboBox.SelectedIndex != 0)
			{
				foreach (ControlPoint cp in db.ControlPoints)
					if (cp.Date.ToString("dd.MM yyyy") == cpComboBox.SelectedItem.ToString())
					{
						selectedCP = cp;
						break;
					}
				specialtyComboBox.Enabled = true;
				groupComboBox.Enabled = true;
				WriteGroupStatistics();
				LoadStudents();
			}
			else
			{
				selectedCP = null;
				groupComboBox.SelectedIndex = 0;
				specialtyComboBox.Enabled = false;
				groupComboBox.Enabled = false;
				lowMarksLabel.Text = "";
				notAllLabsLabel.Text = "";
				manyAbsLabel.Text = "";
			}
		}

		private void studentListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (studentListView.SelectedItems.Count > 0)
			{
				var stud = studentListView.SelectedItems[0].Text;
				selectedStudent = db.Students.FirstOrDefault(s => s.LastName + " " + s.FirstName == stud);
			}
			else
				selectedStudent = null;
			LoadStudentMarks();
			WriteStudentStatistics();
		}
	}
}
