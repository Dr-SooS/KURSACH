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

        public SubMarks()
        {
            InitializeComponent();
        }

        public SubMarks(collegeContext db)
        {
            InitializeComponent();
            this.db = db;

            departmentComboBox.Items.Add("Все отделения");
            foreach (var dep in db.Departments)
                departmentComboBox.Items.Add(dep.Name);
            departmentComboBox.SelectedIndex = 0;

            groupComboBox.Items.Add("Все группы");
            foreach (var group in db.Groups)
                groupComboBox.Items.Add(group.Number.ToString());
            groupComboBox.SelectedIndex = 0;
        }

        public void ReloadTable()
        {
            selectedDep = db.Departments.FirstOrDefault(dep => dep.Name == departmentComboBox.SelectedItem.ToString());
            selectedSpecialty = db.Specialties.FirstOrDefault(s => s.Name == specialtyComboBox.SelectedItem.ToString());
            selectedGroup = db.Groups.FirstOrDefault(g => g.Number.ToString() == groupComboBox.SelectedItem.ToString());
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
    }
}
