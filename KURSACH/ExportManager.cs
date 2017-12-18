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
	public partial class ExportManager : Form
	{
		public ExportManager()
		{
			InitializeComponent();
		}

		CollegeContext db;
		ControlPoint selectedCP;
		string file;

		public ExportManager(CollegeContext db)
		{
			InitializeComponent();
			this.db = db;
			button1.Enabled = false;

			comboBox1.Items.Add("---");
			foreach (var cp in db.ControlPoints)
				comboBox1.Items.Add(cp.Date.ToString("dd.MM yyyy"));
			comboBox1.SelectedIndex = 0;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				file = sfd.FileName;
				button1.Enabled = true;
			}
			else
				button1.Enabled = false;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex != 0)
			{
				var date = Convert.ToDateTime(comboBox1.SelectedItem.ToString());
				selectedCP = db.ControlPoints.FirstOrDefault(cp => cp.Date == date);
				button3.Enabled = true;
			}
			else
			{
				button3.Enabled = false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			BL.StatsToExcel(file, db, selectedCP);
			Close();
		}
	}
}
