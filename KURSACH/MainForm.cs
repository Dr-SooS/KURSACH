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
        collegeContext db;
        public MainForm()
        {
            InitializeComponent();
            db = new collegeContext();
            MessageBox.Show(db.Marks.FirstOrDefault().Value.ToString());
        }

        private void crudBtn_Click(object sender, EventArgs e)
        {
            new CRUDgroups(db).Show();
        }
    }
}
