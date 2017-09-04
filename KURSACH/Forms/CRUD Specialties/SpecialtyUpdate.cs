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
    public partial class SpecialtyUpdate : Form
    {
        CollegeContext db;
        Specialty selectedSpecialty;
        Department selectedDepartment;

        public SpecialtyUpdate()
        {
            InitializeComponent();
        }

        public SpecialtyUpdate(CollegeContext db)
        {
            InitializeComponent();
            this.db = db;

            comboBox1.Items.Add("Выберите специальности");
            foreach (var spec in db.Specialties)
                comboBox1.Items.Add(spec.Name);
            comboBox1.SelectedIndex = 0;

            foreach (var dep in db.Departments)
                comboBox2.Items.Add(dep.Name);
            comboBox2.SelectedIndex = 0;

            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                selectedSpecialty = db.Specialties.FirstOrDefault(d => d.Name == comboBox1.SelectedItem.ToString());
                textBox1.Text = selectedSpecialty.Name;
                selectedDepartment = db.Departments.FirstOrDefault(d => d.Name == selectedSpecialty.Department.Name);
                for (int i = 1; i < comboBox2.Items.Count; i++)
                    if (comboBox2.Items[i].ToString() == selectedDepartment.Name)
                    {
                        comboBox2.SelectedIndex = i;
                        break;
                    }

                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedSpecialty.Name = textBox1.Text;
            selectedSpecialty.Department = selectedDepartment;
            db.SaveChanges();
            Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != 0)
                selectedDepartment = db.Departments.FirstOrDefault(d => d.Name == comboBox2.SelectedItem.ToString());
        }
    }
}
