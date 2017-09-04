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
    public partial class CPUpdateDialog : Form
    {
        CollegeContext db;

        ControlPoint selectedCP;

        public CPUpdateDialog()
        {
            InitializeComponent();
        }

        public CPUpdateDialog(CollegeContext db)
        {
            InitializeComponent();
            this.db = db;

            comboBox1.Items.Add("---");
            foreach (var date in db.ControlPoints.OrderBy(d => d.Date))
            {
                comboBox1.Items.Add(date.Date.ToString("dd.MM yyyy"));
            }
            comboBox1.SelectedIndex = 0;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            selectedCP.Date = dateTimePicker1.Value.Date;
            db.SaveChanges();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                var date = Convert.ToDateTime(comboBox1.SelectedItem.ToString());
                selectedCP = db.ControlPoints.FirstOrDefault(cp => cp.Date == date);
                okButton.Enabled = true;
            }
            else
                okButton.Enabled = false;
        }
    }
}
