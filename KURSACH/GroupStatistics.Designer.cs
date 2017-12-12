namespace KURSACH
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
			this.studentProblemsRichRextBox = new System.Windows.Forms.RichTextBox();
			this.studentMarksDataGridView = new System.Windows.Forms.DataGridView();
			this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.markCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.absCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.labCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.filtersPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupInfoPanel.SuspendLayout();
			this.studentInfoPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.studentMarksDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// filtersPanel
			// 
			this.filtersPanel.Controls.Add(this.cpComboBox);
			this.filtersPanel.Controls.Add(this.groupComboBox);
			this.filtersPanel.Controls.Add(this.specialtyComboBox);
			this.filtersPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.filtersPanel.Location = new System.Drawing.Point(0, 0);
			this.filtersPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.filtersPanel.Name = "filtersPanel";
			this.filtersPanel.Size = new System.Drawing.Size(1416, 57);
			this.filtersPanel.TabIndex = 1;
			// 
			// cpComboBox
			// 
			this.cpComboBox.FormattingEnabled = true;
			this.cpComboBox.Location = new System.Drawing.Point(464, 16);
			this.cpComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cpComboBox.Name = "cpComboBox";
			this.cpComboBox.Size = new System.Drawing.Size(200, 24);
			this.cpComboBox.TabIndex = 2;
			this.cpComboBox.SelectedIndexChanged += new System.EventHandler(this.cpComboBox_SelectedIndexChanged);
			// 
			// groupComboBox
			// 
			this.groupComboBox.FormattingEnabled = true;
			this.groupComboBox.Location = new System.Drawing.Point(241, 16);
			this.groupComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupComboBox.Name = "groupComboBox";
			this.groupComboBox.Size = new System.Drawing.Size(200, 24);
			this.groupComboBox.TabIndex = 1;
			this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
			// 
			// specialtyComboBox
			// 
			this.specialtyComboBox.FormattingEnabled = true;
			this.specialtyComboBox.Location = new System.Drawing.Point(17, 16);
			this.specialtyComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.specialtyComboBox.Name = "specialtyComboBox";
			this.specialtyComboBox.Size = new System.Drawing.Size(200, 24);
			this.specialtyComboBox.TabIndex = 0;
			this.specialtyComboBox.SelectedIndexChanged += new System.EventHandler(this.specialtyCombobox_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.studentListView);
			this.panel1.Location = new System.Drawing.Point(0, 250);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 725);
			this.panel1.TabIndex = 2;
			// 
			// studentListView
			// 
			this.studentListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.studentListView.Location = new System.Drawing.Point(0, 0);
			this.studentListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.studentListView.Name = "studentListView";
			this.studentListView.Size = new System.Drawing.Size(200, 725);
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
			this.groupInfoPanel.Location = new System.Drawing.Point(0, 57);
			this.groupInfoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupInfoPanel.Name = "groupInfoPanel";
			this.groupInfoPanel.Size = new System.Drawing.Size(1416, 193);
			this.groupInfoPanel.TabIndex = 3;
			// 
			// groupProblemsRichTextBox
			// 
			this.groupProblemsRichTextBox.Location = new System.Drawing.Point(379, 4);
			this.groupProblemsRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupProblemsRichTextBox.Name = "groupProblemsRichTextBox";
			this.groupProblemsRichTextBox.ReadOnly = true;
			this.groupProblemsRichTextBox.Size = new System.Drawing.Size(391, 180);
			this.groupProblemsRichTextBox.TabIndex = 6;
			this.groupProblemsRichTextBox.Text = "";
			// 
			// notAllLabsLabel
			// 
			this.notAllLabsLabel.AutoSize = true;
			this.notAllLabsLabel.Location = new System.Drawing.Point(257, 111);
			this.notAllLabsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.notAllLabsLabel.Name = "notAllLabsLabel";
			this.notAllLabsLabel.Size = new System.Drawing.Size(0, 17);
			this.notAllLabsLabel.TabIndex = 5;
			// 
			// manyAbsLabel
			// 
			this.manyAbsLabel.AutoSize = true;
			this.manyAbsLabel.Location = new System.Drawing.Point(249, 71);
			this.manyAbsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.manyAbsLabel.Name = "manyAbsLabel";
			this.manyAbsLabel.Size = new System.Drawing.Size(0, 17);
			this.manyAbsLabel.TabIndex = 4;
			// 
			// lowMarksLabel
			// 
			this.lowMarksLabel.AutoSize = true;
			this.lowMarksLabel.Location = new System.Drawing.Point(136, 31);
			this.lowMarksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lowMarksLabel.Name = "lowMarksLabel";
			this.lowMarksLabel.Size = new System.Drawing.Size(0, 17);
			this.lowMarksLabel.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 111);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(233, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Не сданы лабораторные работы: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 71);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(200, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Пропущено больше 8 часов: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Оценка ниже 4: ";
			// 
			// studentInfoPanel
			// 
			this.studentInfoPanel.Controls.Add(this.studentProblemsRichRextBox);
			this.studentInfoPanel.Controls.Add(this.studentMarksDataGridView);
			this.studentInfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.studentInfoPanel.Location = new System.Drawing.Point(205, 250);
			this.studentInfoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.studentInfoPanel.Name = "studentInfoPanel";
			this.studentInfoPanel.Size = new System.Drawing.Size(1211, 725);
			this.studentInfoPanel.TabIndex = 4;
			// 
			// studentProblemsRichRextBox
			// 
			this.studentProblemsRichRextBox.Location = new System.Drawing.Point(0, 500);
			this.studentProblemsRichRextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.studentProblemsRichRextBox.Name = "studentProblemsRichRextBox";
			this.studentProblemsRichRextBox.ReadOnly = true;
			this.studentProblemsRichRextBox.Size = new System.Drawing.Size(428, 210);
			this.studentProblemsRichRextBox.TabIndex = 7;
			this.studentProblemsRichRextBox.Text = "";
			// 
			// studentMarksDataGridView
			// 
			this.studentMarksDataGridView.AllowUserToAddRows = false;
			this.studentMarksDataGridView.AllowUserToDeleteRows = false;
			this.studentMarksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.studentMarksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectName,
            this.markCol,
            this.absCol,
            this.labCol});
			this.studentMarksDataGridView.Location = new System.Drawing.Point(0, 0);
			this.studentMarksDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.studentMarksDataGridView.Name = "studentMarksDataGridView";
			this.studentMarksDataGridView.ReadOnly = true;
			this.studentMarksDataGridView.Size = new System.Drawing.Size(429, 492);
			this.studentMarksDataGridView.TabIndex = 0;
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
			this.markCol.Width = 55;
			// 
			// absCol
			// 
			this.absCol.HeaderText = "Пропуски";
			this.absCol.Name = "absCol";
			this.absCol.ReadOnly = true;
			this.absCol.Width = 65;
			// 
			// labCol
			// 
			this.labCol.HeaderText = "ЛР";
			this.labCol.Name = "labCol";
			this.labCol.ReadOnly = true;
			this.labCol.Width = 50;
			// 
			// GroupStatistics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1416, 975);
			this.Controls.Add(this.studentInfoPanel);
			this.Controls.Add(this.groupInfoPanel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.filtersPanel);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "GroupStatistics";
			this.Text = "GroupStatistics";
			this.filtersPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupInfoPanel.ResumeLayout(false);
			this.groupInfoPanel.PerformLayout();
			this.studentInfoPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.studentMarksDataGridView)).EndInit();
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
		private System.Windows.Forms.DataGridView studentMarksDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn markCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn absCol;
		private System.Windows.Forms.DataGridViewTextBoxColumn labCol;
	}
}