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
        collegeContext db;
        public TeacherCreate()
        {
            InitializeComponent();
        }

        public TeacherCreate(collegeContext db)
        {
            InitializeComponent();

            this.db = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Teachers.Add(new Teacher { FirstName = textBox1.Text, MiddleName = textBox2.Text, LastName = textBox3.Text });
            db.SaveChanges();
            Close();
        }
    }
}
