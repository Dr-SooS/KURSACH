﻿using System;
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
	public partial class GroupStatistics : Form
	{
		CollegeContext db;

		Specialty selectedSpecialty;
		Group selectedGroup;
		ControlPoint selectedCP;

		public GroupStatistics(CollegeContext db)
		{
			InitializeComponent();

			this.db = db;

			specialtyComboBox.Items.Add("Все специльности");
			foreach (var spec in db.Specialties)
				specialtyComboBox.Items.Add(spec.Name);
			specialtyComboBox.SelectedIndex = 0;

			cpComboBox.Items.Add("Выберите КТ");
			foreach (var cp in db.ControlPoints)
				cpComboBox.Items.Add(cp.Date.ToString("dd.MM yyyy"));
			cpComboBox.SelectedIndex = 0;
		}

		public void WriteStatistics()
		{
			lowMarksLabel.Text = CalculationUtils.CountStudentsWithBadMarks(db, selectedGroup, selectedCP).ToString();
			notAllLabsLabel.Text = CalculationUtils.CountStudentsWithNotPassedLabs(db, selectedGroup, selectedCP).ToString();
			manyAbsLabel.Text = CalculationUtils.CountStudentsWithALotOfAbsences(db, selectedGroup, selectedCP).ToString();
		}

		private void specialtyCombobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (specialtyComboBox.SelectedIndex != 0)
			{
				selectedSpecialty = db.Specialties.FirstOrDefault(s => s.Name == specialtyComboBox.SelectedItem.ToString());
				groupComboBox.Items.Clear();
				groupComboBox.Items.Add("Выберите группу");
				foreach (var g in db.Groups.Where(g => g.Specialty.SpecialtyId == selectedSpecialty.SpecialtyId))
					groupComboBox.Items.Add(g.Number.ToString());
				groupComboBox.SelectedIndex = 0;
			}
			else
			{
				selectedSpecialty = null;
				groupComboBox.Items.Clear();
				groupComboBox.Items.Add("Выберите группу");
				foreach (var g in db.Groups)
					groupComboBox.Items.Add(g.Number.ToString());
				groupComboBox.SelectedIndex = 0;
			}
		}

		private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (groupComboBox.SelectedIndex != 0)
			{
				int num = Convert.ToInt32(groupComboBox.SelectedItem);
				selectedGroup = db.Groups.FirstOrDefault(g => g.Number == num);

				studentListBox.Items.Clear();
				foreach (var student in db.Students.Where(s => s.Group.Number == selectedGroup.Number).OrderBy(s => s.LastName).ThenBy(s => s.FirstName))
					studentListBox.Items.Add(student.LastName + " " + student.FirstName);

				if (selectedCP != null)
					WriteStatistics();
			}
			else
			{
				selectedGroup = null;
				studentListBox.Items.Clear();
			}
		}

		private void cpComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cpComboBox.SelectedIndex != 0)
			{
				foreach (ControlPoint cp in db.ControlPoints)
					if (cp.Date.ToString("dd.MM yyyy") == cpComboBox.SelectedItem.ToString())
					{
						selectedCP = cp;
						break;
					}
				WriteStatistics();
			}
			else
			{
				selectedCP = null;
				lowMarksLabel.Text = "";
				notAllLabsLabel.Text = "";
				manyAbsLabel.Text = "";
			}
		}
	}
}
