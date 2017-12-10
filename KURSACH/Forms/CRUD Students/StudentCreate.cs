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
    public partial class StudentCreate : Form
    {

        CollegeContext db;
        Group selectedGroup;
        public StudentCreate()
        {
            InitializeComponent();
        }

        public StudentCreate(CollegeContext db)
        {

            InitializeComponent();

			textBox1.KeyPress += new KeyPressEventHandler(Helper.ValidateLetter);
			textBox2.KeyPress += new KeyPressEventHandler(Helper.ValidateLetter);
			textBox3.KeyPress += new KeyPressEventHandler(Helper.ValidateLetter);

			this.db = db;

            comboBox1.Items.Add("Выберите группу");
            foreach (var g in db.Groups)
                comboBox1.Items.Add(g.Number.ToString());
            comboBox1.SelectedIndex = 0;

            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
			if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
				MessageBox.Show("Заполните все поля");
			else
			{
				db.Students.Add(new Student { FirstName = textBox1.Text, MiddleName = textBox2.Text, LastName = textBox3.Text, Enterance = dateTimePicker1.Value.Date, Group = selectedGroup });
				db.SaveChanges();
				Close();
			}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
	            var num = Convert.ToInt32(comboBox1.SelectedItem);
                selectedGroup = db.Groups.FirstOrDefault(g => g.Number == num);
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }
	}
}
