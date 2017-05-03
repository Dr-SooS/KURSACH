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
    public partial class DepartmentDelete : Form
    {

        collegeContext db;
        Department selectedDepartment;

        public DepartmentDelete()
        {
            InitializeComponent();
        }

        public DepartmentDelete(collegeContext db)
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
                selectedDepartment = db.Departments.FirstOrDefault(s => s.Name == comboBox1.SelectedItem.ToString());
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Departments.Remove(selectedDepartment);
            db.SaveChanges();
            Close();
        }
    }
}
