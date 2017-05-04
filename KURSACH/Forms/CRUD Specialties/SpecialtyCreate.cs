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
    public partial class SpecialtyCreate : Form
    {

        collegeContext db;
        Department selectedDepartment;
        public SpecialtyCreate()
        {
            InitializeComponent();
        }

        public SpecialtyCreate(collegeContext db)
        {
            InitializeComponent();
            this.db = db;

            comboBox1.Items.Add("Выберите отделение");
            foreach (var dep in db.Departments)
                comboBox1.Items.Add(dep.Name);
            comboBox1.SelectedIndex = 0;

            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Specialties.Add(new Specialty { Name = textBox1.Text, Department = selectedDepartment });
            db.SaveChanges();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                selectedDepartment = db.Departments.FirstOrDefault(d => d.Name == comboBox1.SelectedItem.ToString());
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }
    }
}
