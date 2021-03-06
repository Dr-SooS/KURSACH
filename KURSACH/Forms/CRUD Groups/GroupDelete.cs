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
    public partial class GroupDelete : Form
    {

        CollegeContext db;
        Group selectedGroup;

        public GroupDelete()
        {
            InitializeComponent();
        }

        public GroupDelete(CollegeContext db)
        {
            InitializeComponent();
            this.db = db;

            comboBox1.Items.Add("Выберите группу");
            foreach (var sub in db.Groups)
                comboBox1.Items.Add(sub.Number.ToString());
            comboBox1.SelectedIndex = 0;

            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
	            var num = Convert.ToInt32(comboBox1.SelectedItem);
				selectedGroup = db.Groups.FirstOrDefault(s => s.Number == num);
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Groups.Remove(selectedGroup);
            db.SaveChanges();
            Close();
        }
    }
}
