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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            using(collegeContext db = new collegeContext())
            {
                Mark mk = new Mark();
                mk.Student = db.Students.FirstOrDefault();
                mk.Teacher = db.Teachers.FirstOrDefault();
                mk.Subject = db.Subjects.FirstOrDefault();
                mk.Type = "LR";
                mk.Value = "8";
                mk.Date = DateTime.Now;

                db.Marks.Add(mk);
                db.SaveChanges();
            }
        }
    }
}
