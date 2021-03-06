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
    public partial class SpecialtyDelete : Form
    {

        CollegeContext db;
        Specialty selectedSpecialty;

        public SpecialtyDelete()
        {
            InitializeComponent();
        }

        public SpecialtyDelete(CollegeContext db)
        {
            InitializeComponent();
            this.db = db;

            comboBox1.Items.Add("Выберите специальность");
            foreach (var sub in db.Specialties)
                comboBox1.Items.Add(sub.Name);
            comboBox1.SelectedIndex = 0;

            button1.Enabled = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            db.Specialties.Remove(selectedSpecialty);
            db.SaveChanges();
            Close();
        }
    }
}
