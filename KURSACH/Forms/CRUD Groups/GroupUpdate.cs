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
    public partial class GroupUpdate : Form
    {
        CollegeContext db;
        Group selectedGroup;
        Specialty selectedSpecialty;

        public GroupUpdate()
        {
            InitializeComponent();
        }

        public GroupUpdate(CollegeContext db)
        {
            InitializeComponent();

			textBox1.KeyPress += new KeyPressEventHandler(Helper.ValidateDigit);

			this.db = db;

            comboBox1.Items.Add("Выберите группу");
            foreach (var spec in db.Groups)
                comboBox1.Items.Add(spec.Number.ToString());
            comboBox1.SelectedIndex = 0;

            foreach (var sp in db.Specialties)
                comboBox2.Items.Add(sp.Name);
            comboBox2.SelectedIndex = 0;

            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
	            var num = Convert.ToInt32(comboBox1.SelectedItem);
				selectedGroup = db.Groups.FirstOrDefault(d => d.Number == num);
                textBox1.Text = selectedGroup.Number.ToString();
                selectedSpecialty = db.Specialties.FirstOrDefault(d => d.Name == selectedGroup.Specialty.Name);
                for (int i = 1; i < comboBox2.Items.Count; i++)
                    if (comboBox2.Items[i].ToString() == selectedSpecialty.Name)
                    {
                        comboBox2.SelectedIndex = i;
                        break;
                    }

                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
			if (textBox1.Text == "")
				MessageBox.Show("Заполните все поля");
			else
			{
				selectedGroup.Number = Convert.ToInt32(textBox1.Text);
				selectedGroup.Specialty = selectedSpecialty;
				db.SaveChanges();
				Close();
			}
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != 0)
                selectedSpecialty = db.Specialties.FirstOrDefault(d => d.Name == comboBox2.SelectedItem.ToString());
        }
    }
}
