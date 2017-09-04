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
    public partial class StudentDelete : Form
    {

        CollegeContext db;
        Student selectedStudent;

        public StudentDelete()
        {
            InitializeComponent();
        }

        public StudentDelete(CollegeContext db)
        {
            InitializeComponent();
            this.db = db;

            comboBox1.Items.Add("Выберите студента");
            foreach (var stud in db.Students)
                comboBox1.Items.Add(stud.FirstName + " " + stud.MiddleName + " " + stud.LastName);
            comboBox1.SelectedIndex = 0;

            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
				selectedStudent = db.Students.FirstOrDefault(stud => stud.FirstName + " " + stud.MiddleName + " " + stud.LastName == comboBox1.SelectedItem.ToString());
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Students.Remove(selectedStudent);
            db.SaveChanges();
            Close();
        }
    }
}
