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
    public partial class TeacherCreate : Form
    {
        public CollegeContext db;
		public string teacherSubjects;
		public Subject selectedSubject;
        public TeacherCreate()
        {
            InitializeComponent();
        }

        public TeacherCreate(CollegeContext db)
        {
            InitializeComponent();

			textBox1.KeyPress += new KeyPressEventHandler(Helper.ValidateLetter);
			textBox2.KeyPress += new KeyPressEventHandler(Helper.ValidateLetter);
			textBox3.KeyPress += new KeyPressEventHandler(Helper.ValidateLetter);

			teacherSubjects = "";

			this.db = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
			if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
				MessageBox.Show("Заполните все поля");
            else
			{
				db.Teachers.Add(new Teacher { FirstName = textBox1.Text, MiddleName = textBox2.Text, LastName = textBox3.Text, Subjects = teacherSubjects.Remove(teacherSubjects.Length - 1) });
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
