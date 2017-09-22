﻿namespace KURSACH
{
	partial class GroupStatistics
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.filtersPanel = new System.Windows.Forms.Panel();
			this.cpComboBox = new System.Windows.Forms.ComboBox();
			this.groupComboBox = new System.Windows.Forms.ComboBox();
			this.specialtyComboBox = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.studentListView = new System.Windows.Forms.ListView();
			this.groupInfoPanel = new System.Windows.Forms.Panel();
			this.groupProblemsRichTextBox = new System.Windows.Forms.RichTextBox();
			this.notAllLabsLabel = new System.Windows.Forms.Label();
			this.manyAbsLabel = new System.Windows.Forms.Label();
			this.lowMarksLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.studentInfoPanel = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.studentProblemsRichRextBox = new System.Windows.Forms.RichTextBox();
			this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.markCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.absCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.labCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.filtersPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupInfoPanel.SuspendLayout();
			this.studentInfoPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// filtersPanel
			// 
			this.filtersPanel.Controls.Add(this.cpComboBox);
			this.filtersPanel.Controls.Add(this.groupComboBox);
			this.filtersPanel.Controls.Add(this.specialtyComboBox);
			this.filtersPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.filtersPanel.Location = new System.Drawing.Point(0, 0);
			this.filtersPanel.Margin = new System.Windows.Forms.Padding(2);
			this.filtersPanel.Name = "filtersPanel";
			this.filtersPanel.Size = new System.Drawing.Size(1062, 46);
			this.filtersPanel.TabIndex = 1;
			// 
			// cpComboBox
			// 
			this.cpComboBox.FormattingEnabled = true;
			this.cpComboBox.Location = new System.Drawing.Point(348, 13);
			this.cpComboBox.Name = "cpComboBox";
			this.cpComboBox.Size = new System.Drawing.Size(151, 21);
			this.cpComboBox.TabIndex = 2;
			this.cpComboBox.SelectedIndexChanged += new System.EventHandler(this.cpComboBox_SelectedIndexChanged);
			// 
			// groupComboBox
			// 
			this.groupComboBox.FormattingEnabled = true;
			this.groupComboBox.Location = new System.Drawing.Point(181, 13);
			this.groupComboBox.Name = "groupComboBox";
			this.groupComboBox.Size = new System.Drawing.Size(151, 21);
			this.groupComboBox.TabIndex = 1;
			this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
			// 
			// specialtyComboBox
			// 
			this.specialtyComboBox.FormattingEnabled = true;
			this.specialtyComboBox.Location = new System.Drawing.Point(13, 13);
			this.specialtyComboBox.Name = "specialtyComboBox";
			this.specialtyComboBox.Size = new System.Drawing.Size(151, 21);
			this.specialtyComboBox.TabIndex = 0;
			this.specialtyComboBox.SelectedIndexChanged += new System.EventHandler(this.specialtyCombobox_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.studentListView);
			this.panel1.Location = new System.Drawing.Point(0, 203);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(150, 589);
			this.panel1.TabIndex = 2;
			// 
			// studentListView
			// 
			this.studentListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.studentListView.Location = new System.Drawing.Point(0, 0);
			this.studentListView.Margin = new System.Windows.Forms.Padding(2);
			this.studentListView.Name = "studentListView";
			this.studentListView.Size = new System.Drawing.Size(150, 589);
			this.studentListView.TabIndex = 0;
			this.studentListView.UseCompatibleStateImageBehavior = false;
			this.studentListView.View = System.Windows.Forms.View.List;
			this.studentListView.SelectedIndexChanged += new System.EventHandler(this.studentListView_SelectedIndexChanged);
			// 
			// groupInfoPanel
			// 
			this.groupInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.groupInfoPanel.Controls.Add(this.groupProblemsRichTextBox);
			this.groupInfoPanel.Controls.Add(this.notAllLabsLabel);
			this.groupInfoPanel.Controls.Add(this.manyAbsLabel);
			this.groupInfoPanel.Controls.Add(this.lowMarksLabel);
			this.groupInfoPanel.Controls.Add(this.label3);
			this.groupInfoPanel.Controls.Add(this.label2);
			this.groupInfoPanel.Controls.Add(this.label1);
			this.groupInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupInfoPanel.Location = new System.Drawing.Point(0, 46);
			this.groupInfoPanel.Margin = new System.Windows.Forms.Padding(2);
			this.groupInfoPanel.Name = "groupInfoPanel";
			this.groupInfoPanel.Size = new System.Drawing.Size(1062, 157);
			this.groupInfoPanel.TabIndex = 3;
			// 
			// groupProblemsRichTextBox
			// 
			this.groupProblemsRichTextBox.Location = new System.Drawing.Point(154, 3);
			this.groupProblemsRichTextBox.Name = "groupProblemsRichTextBox";
			this.groupProblemsRichTextBox.ReadOnly = true;
			this.groupProblemsRichTextBox.Size = new System.Drawing.Size(294, 147);
			this.groupProblemsRichTextBox.TabIndex = 6;
			this.groupProblemsRichTextBox.Text = "";
			// 
			// notAllLabsLabel
			// 
			this.notAllLabsLabel.AutoSize = true;
			this.notAllLabsLabel.Location = new System.Drawing.Point(102, 90);
			this.notAllLabsLabel.Name = "notAllLabsLabel";
			this.notAllLabsLabel.Size = new System.Drawing.Size(0, 13);
			this.notAllLabsLabel.TabIndex = 5;
			// 
			// manyAbsLabel
			// 
			this.manyAbsLabel.AutoSize = true;
			this.manyAbsLabel.Location = new System.Drawing.Point(102, 58);
			this.manyAbsLabel.Name = "manyAbsLabel";
			this.manyAbsLabel.Size = new System.Drawing.Size(0, 13);
			this.manyAbsLabel.TabIndex = 4;
			// 
			// lowMarksLabel
			// 
			this.lowMarksLabel.AutoSize = true;
			this.lowMarksLabel.Location = new System.Drawing.Point(102, 25);
			this.lowMarksLabel.Name = "lowMarksLabel";
			this.lowMarksLabel.Size = new System.Drawing.Size(0, 13);
			this.lowMarksLabel.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Не сдана лаба:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Больше 8:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ниже 4:";
			// 
			// studentInfoPanel
			// 
			this.studentInfoPanel.Controls.Add(this.studentProblemsRichRextBox);
			this.studentInfoPanel.Controls.Add(this.dataGridView1);
			this.studentInfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.studentInfoPanel.Location = new System.Drawing.Point(154, 203);
			this.studentInfoPanel.Margin = new System.Windows.Forms.Padding(2);
			this.studentInfoPanel.Name = "studentInfoPanel";
			this.studentInfoPanel.Size = new System.Drawing.Size(908, 589);
			this.studentInfoPanel.TabIndex = 4;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectName,
            this.markCol,
            this.absCol,
            this.labCol});
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(501, 400);
			this.dataGridView1.TabIndex = 0;
			// 
			// studentProblemsRichRextBox
			// 
			this.studentProblemsRichRextBox.Location = new System.Drawing.Point(0, 406);
			this.studentProblemsRichRextBox.Name = "studentProblemsRichRextBox";
			this.studentProblemsRichRextBox.ReadOnly = true;
			this.studentProblemsRichRextBox.Size = new System.Drawing.Size(322, 171);
			this.studentProblemsRichRextBox.TabIndex = 7;
			this.studentProblemsRichRextBox.Text = "";
			// 
			// subjectName
			// 
			this.subjectName.HeaderText = "Предмет";
			this.subjectName.Name = "subjectName";
			this.subjectName.ReadOnly = true;
			// 
			// markCol
			// 
			this.markCol.HeaderText = "Оценка";
			this.markCol.Name = "markCol";
			this.markCol.ReadOnly = true;
			// 
			// absCol
			// 
			this.absCol.HeaderText = "Пропуски";
			this.absCol.Name = "absCol";
			this.absCol.ReadOnly = true;
			// 
			// labCol
			// 
			this.labCol.HeaderText = "ЛР";
			this.labCol.Name = "labCol";
			this.labCol.ReadOnly = true;
			// 
			// GroupStatistics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1062, 792);
			this.Controls.Add(this.studentInfoPanel);
			this.Controls.Add(this.groupInfoPanel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.filtersPanel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "GroupStatistics";
			this.Text = "GroupStatistics";
			this.filtersPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupInfoPanel.ResumeLayout(false);
			this.groupInfoPanel.PerformLayout();
			this.studentInfoPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel filtersPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel groupInfoPanel;
		private System.Windows.Forms.Panel studentInfoPanel;
		private System.Windows.Forms.ComboBox cpComboBox;
		private System.Windows.Forms.ComboBox groupComboBox;
		private System.Windows.Forms.ComboBox specialtyComboBox;
		private System.Windows.Forms.Label notAllLabsLabel;
		private System.Windows.Forms.Label manyAbsLabel;
		private System.Windows.Forms.Label lowMarksLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView studentListView;
		private System.Windows.Forms.RichTextBox groupProblemsRichTextBox;
		private System.Windows.Forms.RichTextBox studentProblemsRichRextBox;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn markCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn absCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn labCol;
	}
}