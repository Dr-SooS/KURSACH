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
    public partial class CPCreateDialog : Form
    {
        public CPCreateDialog()
        {
            InitializeComponent();
        }

        collegeContext db;
        public CPCreateDialog(collegeContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            db.ControlPoints.Add(new ControlPoint { Date = dateTimePicker1.Value.Date });
            db.SaveChanges();
            Close();
        }
    }
}
