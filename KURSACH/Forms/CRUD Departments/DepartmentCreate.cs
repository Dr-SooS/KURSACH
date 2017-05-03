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
    public partial class DepartmentCreate : Form
    {

        collegeContext db;
        public DepartmentCreate()
        {
            InitializeComponent();
        }

        public DepartmentCreate(collegeContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Departments.Add(new Department { Name = textBox1.Text });
            db.SaveChanges();
            Close();
        }
    }
}
