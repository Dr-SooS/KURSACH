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
    public partial class TeacherDelete : Form
    {
        CollegeContext db;
        Teacher selectedTeacher;

        public TeacherDelete()
        {
            InitializeComponent();
        }

        public TeacherDelete(CollegeContext db)
        {
            InitializeComponent();
            this.db = db;

            comboBox1.Items.Add("Выберите преподавателя");
            foreach (var teacher in db.Teachers)
                comboBox1.Items.Add(teacher.FirstName + " " + teacher.MiddleName + " " + teacher.LastName);
            comboBox1.SelectedIndex = 0;

            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                selectedTeacher = db.Teachers.FirstOrDefault(t => t.FirstName + " " + t.MiddleName + " " + t.LastName == comboBox1.SelectedItem.ToString());
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Teachers.Remove(selectedTeacher);
            db.SaveChanges();
            Close();
        }
    }
}
