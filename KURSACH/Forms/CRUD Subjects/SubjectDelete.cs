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
    public partial class SubjectDelete : Form
    {

        collegeContext db;
        Subject selectedSubject;

        public SubjectDelete()
        {
            InitializeComponent();
        }

        public SubjectDelete(collegeContext db)
        {
            InitializeComponent();
            this.db = db;

            comboBox1.Items.Add("Выберите предмет");
            foreach (var sub in db.Subjects)
                comboBox1.Items.Add(sub.Name);
            comboBox1.SelectedIndex = 0;

            button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                selectedSubject = db.Subjects.FirstOrDefault(s => s.Name == comboBox1.SelectedItem.ToString());
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Subjects.Remove(selectedSubject);
            db.SaveChanges();
            Close();
        }
    }
}
