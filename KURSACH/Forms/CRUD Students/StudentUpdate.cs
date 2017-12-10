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
    public partial class StudentUpdate : Form
    {
        CollegeContext db;
        Student selectedStudent;
        Group selectedGroup;

        public StudentUpdate()
        {
            InitializeComponent();
        }

        public StudentUpdate(CollegeContext db)
        {
            InitializeComponent();

			textBox1.KeyPress += new KeyPressEventHandler(Helper.ValidateLetter);
			textBox2.KeyPress += new KeyPressEventHandler(Helper.ValidateLetter);
			textBox3.KeyPress += new KeyPressEventHandler(Helper.ValidateLetter);

			this.db = db;

	        comboBox2.Items.Add("Выберите студента");
	        foreach (var stud in db.Students)
		        comboBox2.Items.Add(stud.FirstName + " " + stud.MiddleName + " " + stud.LastName);
	        comboBox2.SelectedIndex = 0;

			foreach (var g in db.Groups)
                comboBox1.Items.Add(g.Number.ToString());
            comboBox1.SelectedIndex = 0;

            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != 0)
            {
				selectedStudent = db.Students.FirstOrDefault(stud => stud.FirstName + " " + stud.MiddleName + " " + stud.LastName == comboBox2.SelectedItem.ToString());
				selectedGroup = db.Groups.FirstOrDefault(g => g.Number == selectedStudent.Group.Number);

	            textBox1.Text = selectedStudent.FirstName;
	            textBox2.Text = selectedStudent.MiddleName;
	            textBox3.Text = selectedStudent.LastName;
	            //dateTimePicker1.Value = selectedStudent.Enterance;
                for (int i = 1; i < comboBox1.Items.Count; i++)
                    if (Convert.ToInt32(comboBox1.Items[i]) == selectedGroup.Number)
                    {
                        comboBox1.SelectedIndex = i;
                        break;
                    }

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
				selectedStudent.Group = selectedGroup;
				selectedStudent.Enterance = dateTimePicker1.Value.Date;
				selectedStudent.FirstName = textBox1.Text;
				selectedStudent.MiddleName = textBox2.Text;
				selectedStudent.LastName = textBox3.Text;
				db.SaveChanges();
				Close();
			}
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
	        var num = Convert.ToInt32(comboBox1.SelectedItem);
            if (comboBox1.SelectedIndex != 0)
                selectedGroup = db.Groups.FirstOrDefault(d => d.Number == num);
        }
    }
}
