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
    public partial class CRUDgroups : Form
    {
        collegeContext db;
        public CRUDgroups()
        {
            InitializeComponent();
        }

        public CRUDgroups(collegeContext db)
        {
            InitializeComponent();
            this.db = db;

            List<Group> gs = db.Groups.ToList();
            foreach (var g in gs)
            {
                dataGridView1.Rows.Add(g.Number.ToString(), g.Specialty.Name, g.Specialty.Department.Name);
            }
        }
    }
}
