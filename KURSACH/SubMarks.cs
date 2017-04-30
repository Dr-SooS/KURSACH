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
    public partial class SubMarks : Form
    {
        collegeContext db;

        Specialty selectedSpecialty;
        Group selectedGroup;
        Subject selectedSubject;
        Teacher selectedTeacher;

        public SubMarks()
        {
            InitializeComponent();
        }

        public SubMarks(collegeContext db)
        {
            InitializeComponent();
            this.db = db;

            subjectComboBox.Items.Add("Все предметы");
            foreach (var sub in db.Subjects)
                subjectComboBox.Items.Add(sub.Name);
            subjectComboBox.SelectedIndex = 0;

            teachersComboBox.Items.Add("Все преподаватели");
            foreach (var teacher in db.Teachers)
                teachersComboBox.Items.Add(teacher.LastName + " " + teacher.FirstName + " " + teacher.MiddleName);
            teachersComboBox.SelectedIndex = 0;

            specialtyComboBox.Items.Add("Все специльности");
            foreach (var spec in db.Specialties)
                specialtyComboBox.Items.Add(spec.Name);
            specialtyComboBox.SelectedIndex = 0;

            foreach (var point in db.ControlPoints.OrderBy(p => p.Date))
            {
                subjectMarksDataGrid.Columns.Add(point.ControlPointId.ToString() + "column", point.Date.ToString("dd.MM yyyy"));
                subjectMarksDataGrid.Columns[subjectMarksDataGrid.ColumnCount - 1].Width = 45;
                subjectMarksDataGrid.Columns[subjectMarksDataGrid.ColumnCount - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public void ReloadTable()
        {
            for (int i = 2; i < subjectMarksDataGrid.ColumnCount; i++)
                for (int j = 0; j < subjectMarksDataGrid.RowCount; j++)
                    foreach (var mark in db.Marks)
                        if ((mark.ControlPoint.Date.ToString("dd.MM yyyy") == subjectMarksDataGrid.Columns[i].HeaderText) && 
                            (mark.Student.LastName + " " + mark.Student.FirstName == subjectMarksDataGrid[0, j].Value.ToString()) &&
                            (mark.Subject.Name == selectedSubject.Name))
                            subjectMarksDataGrid[i, j].Value = mark.Value;
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

                subjectMarksDataGrid.Rows.Clear();
                foreach (var g in db.Students.Where(s => s.Group.Specialty.Name == specialtyComboBox.SelectedItem.ToString()).GroupBy(s => s.Group))
                    foreach (var stud in g.OrderBy(s => s.LastName).ThenBy(S => S.FirstName))
                    {
                        subjectMarksDataGrid.Rows.Add();
                        subjectMarksDataGrid[0, subjectMarksDataGrid.RowCount - 1].Value = stud.LastName + " " + stud.FirstName;
                        subjectMarksDataGrid[1, subjectMarksDataGrid.RowCount - 1].Value = stud.Group.Number;
                    }
            }
            else
            {
                groupComboBox.Items.Clear();
                groupComboBox.Items.Add("Все группы");
                foreach (var g in db.Groups)
                    groupComboBox.Items.Add(g.Number.ToString());
                groupComboBox.SelectedIndex = 0;

                subjectMarksDataGrid.Rows.Clear();
                foreach (var g in db.Students.GroupBy(s => s.Group))
                    foreach (var stud in g.OrderBy(s => s.LastName).ThenBy(S => S.FirstName))
                    {
                        subjectMarksDataGrid.Rows.Add();
                        subjectMarksDataGrid[0, subjectMarksDataGrid.RowCount - 1].Value = stud.LastName + " " + stud.FirstName;
                        subjectMarksDataGrid[1, subjectMarksDataGrid.RowCount - 1].Value = stud.Group.Number;
                    }
            }
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupComboBox.SelectedIndex != 0)
            {
                int num = Convert.ToInt32(groupComboBox.SelectedItem);
                selectedGroup = db.Groups.FirstOrDefault(g => g.Number == num);

                subjectMarksDataGrid.Rows.Clear();
                foreach (var g in db.Students.Where(s => s.Group.Number == selectedGroup.Number).GroupBy(s => s.Group))
                    foreach (var stud in g.OrderBy(s => s.LastName).ThenBy(S => S.FirstName))
                    {
                        subjectMarksDataGrid.Rows.Add();
                        subjectMarksDataGrid[0, subjectMarksDataGrid.RowCount - 1].Value = stud.LastName + " " + stud.FirstName;
                        subjectMarksDataGrid[1, subjectMarksDataGrid.RowCount - 1].Value = stud.Group.Number;
                    }
            }
            else
            {
                if (specialtyComboBox.SelectedIndex != 0)
                {
                    subjectMarksDataGrid.Rows.Clear();
                    foreach (var g in db.Students.Where(s => s.Group.Specialty.Name == specialtyComboBox.SelectedItem.ToString()).GroupBy(s => s.Group))
                        foreach (var stud in g.OrderBy(s => s.LastName).ThenBy(S => S.FirstName))
                        {
                            subjectMarksDataGrid.Rows.Add();
                            subjectMarksDataGrid[0, subjectMarksDataGrid.RowCount - 1].Value = stud.LastName + " " + stud.FirstName;
                            subjectMarksDataGrid[1, subjectMarksDataGrid.RowCount - 1].Value = stud.Group.Number;
                        }
                }
                else
                {
                    subjectMarksDataGrid.Rows.Clear();
                    foreach (var g in db.Students.GroupBy(s => s.Group))
                        foreach (var stud in g.OrderBy(s => s.LastName).ThenBy(S => S.FirstName))
                        {
                            subjectMarksDataGrid.Rows.Add();
                            subjectMarksDataGrid[0, subjectMarksDataGrid.RowCount - 1].Value = stud.LastName + " " + stud.FirstName;
                            subjectMarksDataGrid[1, subjectMarksDataGrid.RowCount - 1].Value = stud.Group.Number;
                        }
                }
            }
        }

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subjectComboBox.SelectedIndex != 0)
            {
                selectedSubject = db.Subjects.FirstOrDefault(s => s.Name == subjectComboBox.SelectedItem.ToString());
                teachersComboBox.Enabled = true;
                ReloadTable();
            }
            else
            {
                subjectMarksDataGrid.Enabled = false;
                teachersComboBox.Enabled = false;
            }
        }

        private void teachersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teachersComboBox.SelectedIndex != 0)
            {
                selectedTeacher = db.Teachers.FirstOrDefault(t => t.LastName + " " + t.FirstName + " " + t.MiddleName == teachersComboBox.SelectedItem.ToString());
                subjectMarksDataGrid.Enabled = true;
                ReloadTable();
            }
            else
                subjectMarksDataGrid.Enabled = false;
        }

        private void subjectMarksDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cell = subjectMarksDataGrid.CurrentCell;
            var date = Convert.ToDateTime(subjectMarksDataGrid.Columns[cell.ColumnIndex].HeaderText);
            var lname = subjectMarksDataGrid[0, cell.RowIndex].Value.ToString().Split(' ')[0];
            var fname = subjectMarksDataGrid[0, cell.RowIndex].Value.ToString().Split(' ')[1];
            Mark mark = db.Marks.FirstOrDefault(
                m => (m.ControlPoint.Date == date) &&
                (m.Student.FirstName == fname) &&
                (m.Student.LastName == lname));

            if (cell.Value == null)
            {
                if (mark != null)
                    db.Marks.Remove(mark);
            }
            else
            {
                if (mark != null)
                    mark.Value = cell.Value.ToString();
                else
                {
                    var cp = db.ControlPoints.FirstOrDefault(c => c.Date == date);
                    var stud = db.Students.FirstOrDefault(st => (st.FirstName == fname) && (st.LastName == lname));
                    db.Marks.Add(new Mark { Value = cell.Value.ToString(), Subject = selectedSubject, Student = stud, ControlPoint = cp, Teacher = selectedTeacher });
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}
