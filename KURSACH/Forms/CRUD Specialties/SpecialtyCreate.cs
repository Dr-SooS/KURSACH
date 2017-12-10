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

        CollegeContext db;
        Department selectedDepartment;
        public SpecialtyCreate()
        {
            InitializeComponent();
        }

        public SpecialtyCreate(CollegeContext db)
        {
            InitializeComponent();
            this.db = db;

			textBox1.KeyPress += new KeyPressEventHandler(Helper.ValidateLetter);

			comboBox1.Items.Add("Выберите отделение");
            foreach (var dep in db.Departments)
                comboBox1.Items.Add(dep.Name);
            comboBox1.SelectedIndex = 0;

            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
			if (textBox1.Text == "")
				MessageBox.Show("Заполните все поля");
			else
			{
				db.Specialties.Add(new Specialty { Name = textBox1.Text, Department = selectedDepartment });
				db.SaveChanges();
				Close();
			}
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
