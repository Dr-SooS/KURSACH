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
    public partial class TeacherUpdate : Form
    {

        collegeContext db;
        Teacher selectedTeacher;
        public TeacherUpdate()
        {
            InitializeComponent();
        }

        public TeacherUpdate(collegeContext db)
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
                textBox1.Text = selectedTeacher.FirstName;
                textBox2.Text = selectedTeacher.MiddleName;
                textBox3.Text = selectedTeacher.LastName;

                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedTeacher.FirstName = textBox1.Text;
            selectedTeacher.MiddleName = textBox2.Text;
            selectedTeacher.LastName = textBox3.Text;
            db.SaveChanges();
            Close();
        }
    }
}
