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

        Department selectedDep;
        Specialty selectedSpecialty;
        Group selectedGroup;
        Subject selectedSubject;

        public SubMarks()
        {
            InitializeComponent();
        }

        public SubMarks(collegeContext db)
        {
            InitializeComponent();
            this.db = db;

            //departmentComboBox.Items.Add("Все отделения");
            //foreach (var dep in db.Departments)
            //    departmentComboBox.Items.Add(dep.Name);
            //departmentComboBox.SelectedIndex = 0;

            subjectComboBox.Items.Add("Все предметы");
            foreach (var sub in db.Subjects)
                subjectComboBox.Items.Add(sub.Name);
            subjectComboBox.SelectedIndex = 0;

            foreach (var point in db.ControlPoints.OrderBy(p => p.Date))
            {
                subjectMarksDataGrid.Columns.Add(point.ControlPointId.ToString() + "column", point.Date.ToString("dd.MM yyyy"));
                subjectMarksDataGrid.Columns[subjectMarksDataGrid.ColumnCount - 1].Width = 45;
                subjectMarksDataGrid.Columns[subjectMarksDataGrid.ColumnCount - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (var g in db.Students.GroupBy(s => s.Group))
                foreach (var stud in g.OrderBy(s => s.LastName).ThenBy(S => S.FirstName))
                {
                    subjectMarksDataGrid.Rows.Add();
                    subjectMarksDataGrid[0, subjectMarksDataGrid.RowCount - 1].Value = stud.LastName + " " + stud.FirstName;
                    subjectMarksDataGrid[1, subjectMarksDataGrid.RowCount - 1].Value = stud.Group.Number;
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

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(departmentComboBox.SelectedIndex != 0)
            {
                selectedDep = db.Departments.FirstOrDefault(dep => dep.Name == departmentComboBox.SelectedItem.ToString());
                specialtyComboBox.Items.Clear();
                specialtyComboBox.Items.Add("Все специальности");
                foreach (var sp in db.Specialties.Where(s => s.Department.DepartmentId == selectedDep.DepartmentId))
                    specialtyComboBox.Items.Add(sp.Name);
                specialtyComboBox.SelectedIndex = 0;
            }
            else
            {
                selectedDep = null;
                specialtyComboBox.Items.Clear();
                specialtyComboBox.Items.Add("Все специальности");
                foreach (var spec in db.Specialties)
                    specialtyComboBox.Items.Add(spec.Name);
                specialtyComboBox.SelectedIndex = 0;
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
            }
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupComboBox.SelectedIndex != 0)
                ReloadTable();
        }

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subjectComboBox.SelectedIndex != 0)
            {
                selectedSubject = db.Subjects.FirstOrDefault(s => s.Name == subjectComboBox.SelectedItem.ToString());
                ReloadTable();
            }
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
                    db.Marks.Add(new Mark { Value = cell.Value.ToString(), Subject = selectedSubject, Student = stud, ControlPoint = cp });
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}
