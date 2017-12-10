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
        CollegeContext db;
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

			this.db = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
			if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
				MessageBox.Show("Заполните все поля");
            else
			{
				db.Teachers.Add(new Teacher { FirstName = textBox1.Text, MiddleName = textBox2.Text, LastName = textBox3.Text });
				db.SaveChanges();
				Close();
			}
        }
    }
}
