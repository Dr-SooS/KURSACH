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
    public partial class DepartmentCreate : Form
    {

        CollegeContext db;
        public DepartmentCreate()
        {
            InitializeComponent();
        }

        public DepartmentCreate(CollegeContext db)
        {
            InitializeComponent();

			textBox1.KeyPress += new KeyPressEventHandler(Helper.ValidateLetter);

			this.db = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
			if (textBox1.Text == "")
				MessageBox.Show("Заполните все поля");
			else
			{
				db.Departments.Add(new Department { Name = textBox1.Text });
				db.SaveChanges();
				Close();
			}
        }
    }
}
