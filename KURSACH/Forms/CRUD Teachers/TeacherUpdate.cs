using KURSACH.Forms.CRUD_Teachers;
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

        public CollegeContext db;
        Teacher selectedTeacher;
		public string teacherSubjects;
		public Subject selectedSubject;
        public TeacherUpdate()
        {
            InitializeComponent();
        }

        public TeacherUpdate(CollegeContext db)
        {
            InitializeComponent();

			teacherSubjects = "";

			textBox1.KeyPress += new KeyPressEventHandler(Helper.ValidateLetter);
			textBox2.KeyPress += new KeyPressEventHandler(Helper.ValidateLetter);
			textBox3.KeyPress += new KeyPressEventHandler(Helper.ValidateLetter);

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
				teacherSubjects = selectedTeacher.Subjects;

                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
			if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
				MessageBox.Show("Заполните все поля");
			else
			{
				selectedTeacher.FirstName = textBox1.Text;
				selectedTeacher.MiddleName = textBox2.Text;
				selectedTeacher.LastName = textBox3.Text;
				selectedTeacher.Subjects = teacherSubjects.Remove(teacherSubjects.Length - 1);
				db.SaveChanges();
				Close();
			}
        }

		private void button3_Click(object sender, EventArgs e)
		{
			new EditTeacherSubject(this, true).ShowDialog();
			teacherSubjects += $"{selectedSubject.Name};";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			new EditTeacherSubject(this, false).ShowDialog();
			teacherSubjects = teacherSubjects.Remove(teacherSubjects.Length - 1);
			var subjectsArray = teacherSubjects.Split(';');
			teacherSubjects = "";
			foreach (var subject in subjectsArray)
				if (subject != selectedSubject.Name)
					teacherSubjects += $"{subject};";
		}
	}
}
