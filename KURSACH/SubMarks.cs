﻿using System;
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
    public partial class SubMarks : Form
    {
        CollegeContext db;

        Specialty selectedSpecialty;
        Group selectedGroup;
        Subject selectedSubject;
        Teacher selectedTeacher;
       
        public SubMarks()
        {
            InitializeComponent();

			db = new CollegeContext();

            subjectComboBox.Items.Add("Выберите предмет");
            foreach (var sub in db.Subjects)
                subjectComboBox.Items.Add(sub.Name);
            subjectComboBox.SelectedIndex = 0;

            specialtyComboBox.Items.Add("Все специльности");
            foreach (var spec in db.Specialties)
                specialtyComboBox.Items.Add(spec.Name);
            specialtyComboBox.SelectedIndex = 0;

			exportToolStripMenuItem.Enabled = false;
        }


        public void LoadMarks()
        {
            for (int i = 2; i < subjectMarksDataGrid.ColumnCount; i++)
                for (int j = 0; j < subjectMarksDataGrid.RowCount; j++)
				{
					var date = DateTime.ParseExact(subjectMarksDataGrid.Columns[i].HeaderText, "dd.MM yyyy", null);
					var mark = BL.GetMark(db.ControlPoints.FirstOrDefault(c => c.Date == date), (Student)subjectMarksDataGrid[0, j].Value, selectedSubject);
					var abs = BL.GetAbsence(db.ControlPoints.FirstOrDefault(c => c.Date == date), (Student)subjectMarksDataGrid[0, j].Value, selectedSubject);
					var lab = BL.GetLabWork(db.ControlPoints.FirstOrDefault(c => c.Date == date), (Student)subjectMarksDataGrid[0, j].Value, selectedSubject);

					if (mark != null)
						if (mark.NoValue)
							subjectMarksDataGrid[i, j].Value = "-";
						else
							subjectMarksDataGrid[i, j].Value = mark.Value;
					else
					{
						db.Marks.Add(new Mark
						{
							ControlPoint = db.ControlPoints.FirstOrDefault(c => c.Date == date),
							Student = (Student)subjectMarksDataGrid[0, j].Value,
							Subject = selectedSubject,
							Teacher = selectedTeacher,
							NoValue = true
						});
						absencesDataGrid[i, j].Value = "-";
					}

					if (abs != null)
						absencesDataGrid[i, j].Value = abs.Count;
					else
					{
						db.Absences.Add(new Absence
						{
							ControlPoint = db.ControlPoints.FirstOrDefault(c => c.Date == date),
							Student = (Student)subjectMarksDataGrid[0, j].Value,
							Subject = selectedSubject,
							Teacher = selectedTeacher,
							Count = 0
						});
						absencesDataGrid[i, j].Value = 0; 
					}

					if (lab != null)
						labWorksDataGrid[i, j].Value = lab.NotPassed;
					else
					{
						db.LabWorks.Add(new LabWork
						{
							ControlPoint = db.ControlPoints.FirstOrDefault(c => c.Date == date),
							Student = (Student)subjectMarksDataGrid[0, j].Value,
							Subject = selectedSubject,
							Teacher = selectedTeacher,
							NotPassed = 0
						});
						labWorksDataGrid[i, j].Value = 0;
					}
				}
		}

        public void RefreshColumns()
        {
	        for (int i = 2; i < subjectMarksDataGrid.Columns.Count;)
	        {
		        subjectMarksDataGrid.Columns.RemoveAt(i);
		        absencesDataGrid.Columns.RemoveAt(i);
		        labWorksDataGrid.Columns.RemoveAt(i);
			}

	        foreach (var point in db.ControlPoints.OrderBy(p => p.Date))
            {
                subjectMarksDataGrid.Columns.Add(point.ControlPointId.ToString() + "column", point.Date.ToString("dd.MM yyyy"));
                subjectMarksDataGrid.Columns[subjectMarksDataGrid.ColumnCount - 1].Width = 45;
                subjectMarksDataGrid.Columns[subjectMarksDataGrid.ColumnCount - 1].SortMode = DataGridViewColumnSortMode.NotSortable;

                absencesDataGrid.Columns.Add(point.ControlPointId.ToString() + "column", point.Date.ToString("dd.MM yyyy"));
                absencesDataGrid.Columns[absencesDataGrid.ColumnCount - 1].Width = 45;
                absencesDataGrid.Columns[absencesDataGrid.ColumnCount - 1].SortMode = DataGridViewColumnSortMode.NotSortable;

                labWorksDataGrid.Columns.Add(point.ControlPointId.ToString() + "column", point.Date.ToString("dd.MM yyyy"));
                labWorksDataGrid.Columns[labWorksDataGrid.ColumnCount - 1].Width = 45;
                labWorksDataGrid.Columns[labWorksDataGrid.ColumnCount - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            if (subjectComboBox.SelectedIndex != 0)
                LoadMarks();
        }

		public void AddOrderedStugentsToDataGrid(IGrouping<Group, Student> g)
		{
			foreach (var stud in g.OrderBy(s => s.LastName).ThenBy(S => S.FirstName))
			{
				subjectMarksDataGrid.Rows.Add();
				subjectMarksDataGrid[0, subjectMarksDataGrid.RowCount - 1].Value = stud;
				subjectMarksDataGrid[1, subjectMarksDataGrid.RowCount - 1].Value = stud.Group.Number;

				absencesDataGrid.Rows.Add();
				absencesDataGrid[0, absencesDataGrid.RowCount - 1].Value = stud;
				absencesDataGrid[1, absencesDataGrid.RowCount - 1].Value = stud.Group.Number;

				labWorksDataGrid.Rows.Add();
				labWorksDataGrid[0, labWorksDataGrid.RowCount - 1].Value = stud;
				labWorksDataGrid[1, labWorksDataGrid.RowCount - 1].Value = stud.Group.Number;
			}
		}

		public void LoadStudents()
		{
			subjectMarksDataGrid.Rows.Clear();
			absencesDataGrid.Rows.Clear();
			labWorksDataGrid.Rows.Clear();

			if (selectedGroup == null)
				if(selectedSpecialty == null)
				{
					foreach (var g in db.Students.GroupBy(s => s.Group))
						AddOrderedStugentsToDataGrid(g);
				}
				else
				{
					foreach (var g in db.Students.Where(s => s.Group.Specialty.Name == specialtyComboBox.SelectedItem.ToString()).GroupBy(s => s.Group))
						AddOrderedStugentsToDataGrid(g);
				}
			else
			{
				foreach (var g in db.Students.Where(s => s.Group.Number == selectedGroup.Number).GroupBy(s => s.Group))
					AddOrderedStugentsToDataGrid(g);
			}
		}

        private void specialtyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (specialtyComboBox.SelectedIndex != 0)
            {
                selectedSpecialty = db.Specialties.FirstOrDefault(s => s.Name == specialtyComboBox.SelectedItem.ToString());
                groupComboBox.Items.Clear();
                groupComboBox.Items.Add("Все группы");
                foreach (var g in db.Groups.Where(g => g.Specialty.SpecialtyId == selectedSpecialty.SpecialtyId))
                    groupComboBox.Items.Add(g.Number.ToString());
                groupComboBox.SelectedIndex = 0;
            }
            else
            {
				selectedSpecialty = null;
                groupComboBox.Items.Clear();
                groupComboBox.Items.Add("Все группы");
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
            }
            else
            {
				selectedGroup = null;
            }
			LoadStudents();
        }

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subjectComboBox.SelectedIndex != 0)
            {
                selectedSubject = db.Subjects.FirstOrDefault(s => s.Name == subjectComboBox.SelectedItem.ToString());
                teachersComboBox.Enabled = true;
				teachersComboBox.Items.Clear();

				teachersComboBox.Items.Add("Выберите преподавателя");
				foreach (var teacher in db.Teachers)
					if(teacher.Subjects.Contains(selectedSubject.Name))
						teachersComboBox.Items.Add(teacher.LastName + " " + teacher.FirstName + " " + teacher.MiddleName);
				teachersComboBox.SelectedIndex = 0;

				exportToolStripMenuItem.Enabled = true;
			}
            else
            {
                subjectMarksDataGrid.Enabled = false;

                absencesDataGrid.Enabled = false;
                labWorksDataGrid.Enabled = false;
                teachersComboBox.Enabled = false;
				exportToolStripMenuItem.Enabled = false;
				teachersComboBox.Items.Clear();
            }
            RefreshColumns();
        }

        private void teachersComboBox_SelectedIndexChanged(object sender, EventArgs e)

        {
	        if (teachersComboBox.SelectedIndex != 0)
	        {
		        selectedTeacher = db.Teachers.FirstOrDefault(t => t.LastName + " " + t.FirstName + " " + t.MiddleName == teachersComboBox.SelectedItem.ToString());
		        subjectMarksDataGrid.Enabled = true;
		        absencesDataGrid.Enabled = true;
		        labWorksDataGrid.Enabled = true;
	        }
	        else
	        {
		        subjectMarksDataGrid.Enabled = false;
		        absencesDataGrid.Enabled = false;
		        labWorksDataGrid.Enabled = false;
	        }
        }


        private void subjectMarksDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cell = subjectMarksDataGrid.CurrentCell;
            var date = DateTime.ParseExact(subjectMarksDataGrid.Columns[cell.ColumnIndex].HeaderText, "dd.MM yyyy", null);
			if (cell.Value == null)
				cell.Value = "-";
			BL.EditMark(db, db.ControlPoints.FirstOrDefault(c => c.Date == date), (Student)subjectMarksDataGrid[0, cell.RowIndex].Value, selectedSubject, selectedTeacher, cell.Value.ToString());
        }

	    private void absencesDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	    {
		    var cell = absencesDataGrid.CurrentCell;
			var date = DateTime.ParseExact(subjectMarksDataGrid.Columns[cell.ColumnIndex].HeaderText, "dd.MM yyyy", null);
			if (cell.Value == null)
				cell.Value = "0";
			BL.EditAbsence(db, db.ControlPoints.FirstOrDefault(c => c.Date == date), (Student)subjectMarksDataGrid[0, cell.RowIndex].Value, selectedSubject, selectedTeacher, cell.Value.ToString());
		}

		private void labWorksDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	    {
			var cell = labWorksDataGrid.CurrentCell;
			var date = DateTime.ParseExact(subjectMarksDataGrid.Columns[cell.ColumnIndex].HeaderText, "dd.MM yyyy", null);
			if (cell.Value == null)
				cell.Value = "0";
			BL.EditLabWork(db, db.ControlPoints.FirstOrDefault(c => c.Date == date), (Student)subjectMarksDataGrid[0, cell.RowIndex].Value, selectedSubject, selectedTeacher, cell.Value.ToString());
		}


		private void saveButton_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        //КТ
        private void добавитьКТToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CPCreateDialog(db).ShowDialog();
            RefreshColumns();
        }

        private void удалитьКТToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CPDeleteDialog(db).ShowDialog();
            RefreshColumns();
        }

        private void изменитьКТToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CPUpdateDialog(db).ShowDialog();
            RefreshColumns();
        }


        //Преподаватели
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TeacherCreate(db).ShowDialog();

            teachersComboBox.Items.Clear();
            teachersComboBox.Items.Add("Все преподаватели");
            foreach (var teacher in db.Teachers)
                teachersComboBox.Items.Add(teacher.LastName + " " + teacher.FirstName + " " + teacher.MiddleName);
            teachersComboBox.SelectedIndex = 0;
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TeacherUpdate(db).ShowDialog();

            teachersComboBox.Items.Clear();
            teachersComboBox.Items.Add("Все преподаватели");
            foreach (var teacher in db.Teachers)
                teachersComboBox.Items.Add(teacher.LastName + " " + teacher.FirstName + " " + teacher.MiddleName);
            teachersComboBox.SelectedIndex = 0;
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TeacherDelete(db).ShowDialog();

            teachersComboBox.Items.Clear();
            teachersComboBox.Items.Add("Все преподаватели");
            foreach (var teacher in db.Teachers)
                teachersComboBox.Items.Add(teacher.LastName + " " + teacher.FirstName + " " + teacher.MiddleName);
            teachersComboBox.SelectedIndex = 0;
        }


        //Предметы
        private void добавитьПредметToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SubjectCreate(db).ShowDialog();

            subjectComboBox.Items.Clear();
            subjectComboBox.Items.Add("Выберите предмет");
            foreach (var sub in db.Subjects)
                subjectComboBox.Items.Add(sub.Name);
            subjectComboBox.SelectedIndex = 0;
        }

        private void изменитьПредметToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SubjectUpdate(db).ShowDialog();

            subjectComboBox.Items.Clear();
            subjectComboBox.Items.Add("Выберите предмет");
            foreach (var sub in db.Subjects)
                subjectComboBox.Items.Add(sub.Name);
            subjectComboBox.SelectedIndex = 0;
        }

        private void удалитьПредметToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SubjectDelete(db).ShowDialog();

            subjectComboBox.Items.Clear();
            subjectComboBox.Items.Add("Выберите предмет");
            foreach (var sub in db.Subjects)
                subjectComboBox.Items.Add(sub.Name);
            subjectComboBox.SelectedIndex = 0;
        }

        //Отделения
        private void создатьОтделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DepartmentCreate(db).ShowDialog();
        }

        private void изменитьОтделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DepartmentUpdate(db).ShowDialog();
        }

        private void удалитьОтделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DepartmentDelete(db).ShowDialog();

            specialtyComboBox.Items.Add("Все специльности");
            foreach (var spec in db.Specialties)
                specialtyComboBox.Items.Add(spec.Name);
            specialtyComboBox.SelectedIndex = 0;
        }

        //Специальности
        private void добавитьСпециальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SpecialtyCreate(db).ShowDialog();

            specialtyComboBox.Items.Clear();
            specialtyComboBox.Items.Add("Все специльности");
            foreach (var spec in db.Specialties)
                specialtyComboBox.Items.Add(spec.Name);
            specialtyComboBox.SelectedIndex = 0;
        }

        private void изменитьСпециальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SpecialtyUpdate(db).ShowDialog();

            specialtyComboBox.Items.Clear();
            specialtyComboBox.Items.Add("Все специльности");
            foreach (var spec in db.Specialties)
                specialtyComboBox.Items.Add(spec.Name);
            specialtyComboBox.SelectedIndex = 0;
        }

		private void удалитьСпециальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SpecialtyDelete(db).ShowDialog();

            specialtyComboBox.Items.Clear();
            specialtyComboBox.Items.Add("Все специльности");
            foreach (var spec in db.Specialties)
                specialtyComboBox.Items.Add(spec.Name);
            specialtyComboBox.SelectedIndex = 0;
        }

		//Группы
		private void добавитьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new GroupCreate(db).ShowDialog();

			groupComboBox.Items.Clear();
			groupComboBox.Items.Add("Все группы");
			foreach (var g in db.Groups)
				groupComboBox.Items.Add(g.Number.ToString());
			groupComboBox.SelectedIndex = 0;
		}

	    private void изменитьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
	    {
		    new GroupUpdate(db).ShowDialog();

		    groupComboBox.Items.Clear();
		    groupComboBox.Items.Add("Все группы");
		    foreach (var g in db.Groups)
			    groupComboBox.Items.Add(g.Number.ToString());
		    groupComboBox.SelectedIndex = 0;
		}

		private void удалитьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new GroupDelete(db).ShowDialog();

			groupComboBox.Items.Clear();
			groupComboBox.Items.Add("Все группы");
			foreach (var g in db.Groups)
				groupComboBox.Items.Add(g.Number.ToString());
			groupComboBox.SelectedIndex = 0;
		}

		//Студенты
		private void добавитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new StudentCreate(db).ShowDialog();
			groupComboBox.SelectedIndex = 0;
			LoadStudents();
		}

		private void изменитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new StudentUpdate(db).ShowDialog();
			groupComboBox.SelectedIndex = 0;
			LoadStudents();
		}

		private void удалитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new StudentDelete(db).ShowDialog();
			groupComboBox.SelectedIndex = 0;
			LoadStudents();
		}

		private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new GroupStatistics(db).Show();
		}

		private void subjectMarksDataGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			e.Control.KeyPress += new KeyPressEventHandler(Helper.ValidateMark);
		}

		private void absencesDataGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			e.Control.KeyPress += new KeyPressEventHandler(Helper.ValidateDigit);
			e.Control.KeyPress += new KeyPressEventHandler(Helper.ValidateInt);
		}

		private void labWorksDataGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			e.Control.KeyPress += new KeyPressEventHandler(Helper.ValidateDigit);
			e.Control.KeyPress += new KeyPressEventHandler(Helper.ValidateInt);
		}

		private void seedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			db.SeedDb(1);
		}

		private void exportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				BL.StatsToExcel(sfd.FileName, this);
			}
			else
			{

			}
		}
	}
}
