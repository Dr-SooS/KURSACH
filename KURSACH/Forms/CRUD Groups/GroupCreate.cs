﻿using System;
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
    public partial class GroupCreate : Form
    {

        CollegeContext db;
        Specialty selectedSpecialty;
        public GroupCreate()
        {
            InitializeComponent();
        }

        public GroupCreate(CollegeContext db)
        {
            InitializeComponent();
			textBox1.KeyPress += new KeyPressEventHandler(Helper.ValidateDigit);
			this.db = db;

            comboBox1.Items.Add("Выберите специальность");
            foreach (var sp in db.Specialties)
                comboBox1.Items.Add(sp.Name);
            comboBox1.SelectedIndex = 0;

            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
			if (textBox1.Text == "")
				MessageBox.Show("Заполните все поля");
			else
			{
				db.Groups.Add(new Group { Number = Convert.ToInt32(textBox1.Text), Specialty = selectedSpecialty });
				db.SaveChanges();
				Close();
			}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                selectedSpecialty = db.Specialties.FirstOrDefault(s => s.Name == comboBox1.SelectedItem.ToString());
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }
    }
}
