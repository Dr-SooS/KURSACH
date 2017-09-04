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
    public partial class DepartmentUpdate : Form
    {
        CollegeContext db;
        Department selectedDepartment;

        public DepartmentUpdate()
        {
            InitializeComponent();
        }

        public DepartmentUpdate(CollegeContext db)
        {
            InitializeComponent();
            this.db = db;

            comboBox1.Items.Add("Выберите отделение");
            foreach (var sub in db.Departments)
                comboBox1.Items.Add(sub.Name);
            comboBox1.SelectedIndex = 0;

            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                selectedDepartment = db.Departments.FirstOrDefault(d => d.Name == comboBox1.SelectedItem.ToString());
                textBox1.Text = selectedDepartment.Name;

                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedDepartment.Name = textBox1.Text;
            db.SaveChanges();
            Close();
        }
    }
}
