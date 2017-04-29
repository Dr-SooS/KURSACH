namespace KURSACH
{
    partial class SubMarks
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
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentListLabel = new System.Windows.Forms.Label();
            this.specialtyListLabel = new System.Windows.Forms.Label();
            this.specialtyComboBox = new System.Windows.Forms.ComboBox();
            this.groupListLabel = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.subjectListLabel = new System.Windows.Forms.Label();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subjectMarksDataGrid = new System.Windows.Forms.DataGridView();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gropColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectMarksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(111, 12);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(260, 24);
            this.departmentComboBox.TabIndex = 0;
            this.departmentComboBox.SelectedIndexChanged += new System.EventHandler(this.departmentComboBox_SelectedIndexChanged);
            // 
            // departmentListLabel
            // 
            this.departmentListLabel.AutoSize = true;
            this.departmentListLabel.Location = new System.Drawing.Point(23, 15);
            this.departmentListLabel.Name = "departmentListLabel";
            this.departmentListLabel.Size = new System.Drawing.Size(82, 17);
            this.departmentListLabel.TabIndex = 1;
            this.departmentListLabel.Text = "Отделение";
            // 
            // specialtyListLabel
            // 
            this.specialtyListLabel.AutoSize = true;
            this.specialtyListLabel.Location = new System.Drawing.Point(377, 15);
            this.specialtyListLabel.Name = "specialtyListLabel";
            this.specialtyListLabel.Size = new System.Drawing.Size(109, 17);
            this.specialtyListLabel.TabIndex = 3;
            this.specialtyListLabel.Text = "Специальность";
            // 
            // specialtyComboBox
            // 
            this.specialtyComboBox.FormattingEnabled = true;
            this.specialtyComboBox.Location = new System.Drawing.Point(492, 12);
            this.specialtyComboBox.Name = "specialtyComboBox";
            this.specialtyComboBox.Size = new System.Drawing.Size(121, 24);
            this.specialtyComboBox.TabIndex = 2;
            this.specialtyComboBox.SelectedIndexChanged += new System.EventHandler(this.specialtyComboBox_SelectedIndexChanged);
            // 
            // groupListLabel
            // 
            this.groupListLabel.AutoSize = true;
            this.groupListLabel.Location = new System.Drawing.Point(647, 15);
            this.groupListLabel.Name = "groupListLabel";
            this.groupListLabel.Size = new System.Drawing.Size(55, 17);
            this.groupListLabel.TabIndex = 5;
            this.groupListLabel.Text = "Группа";
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(708, 12);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(121, 24);
            this.groupComboBox.TabIndex = 4;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // subjectListLabel
            // 
            this.subjectListLabel.AutoSize = true;
            this.subjectListLabel.Location = new System.Drawing.Point(857, 15);
            this.subjectListLabel.Name = "subjectListLabel";
            this.subjectListLabel.Size = new System.Drawing.Size(66, 17);
            this.subjectListLabel.TabIndex = 8;
            this.subjectListLabel.Text = "Предмет";
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(929, 12);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(121, 24);
            this.subjectComboBox.TabIndex = 7;
            this.subjectComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.subjectComboBox);
            this.panel1.Controls.Add(this.subjectListLabel);
            this.panel1.Controls.Add(this.departmentComboBox);
            this.panel1.Controls.Add(this.departmentListLabel);
            this.panel1.Controls.Add(this.groupListLabel);
            this.panel1.Controls.Add(this.specialtyComboBox);
            this.panel1.Controls.Add(this.groupComboBox);
            this.panel1.Controls.Add(this.specialtyListLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1403, 50);
            this.panel1.TabIndex = 9;
            // 
            // subjectMarksDataGrid
            // 
            this.subjectMarksDataGrid.AllowUserToAddRows = false;
            this.subjectMarksDataGrid.AllowUserToDeleteRows = false;
            this.subjectMarksDataGrid.AllowUserToResizeRows = false;
            this.subjectMarksDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentName,
            this.gropColumn});
            this.subjectMarksDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectMarksDataGrid.Location = new System.Drawing.Point(0, 50);
            this.subjectMarksDataGrid.Name = "subjectMarksDataGrid";
            this.subjectMarksDataGrid.Size = new System.Drawing.Size(1403, 545);
            this.subjectMarksDataGrid.TabIndex = 0;
            // 
            // studentName
            // 
            this.studentName.Frozen = true;
            this.studentName.HeaderText = "Имя";
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            this.studentName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.studentName.Width = 200;
            // 
            // gropColumn
            // 
            this.gropColumn.Frozen = true;
            this.gropColumn.HeaderText = "Группа";
            this.gropColumn.Name = "gropColumn";
            this.gropColumn.ReadOnly = true;
            this.gropColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SubMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 595);
            this.Controls.Add(this.subjectMarksDataGrid);
            this.Controls.Add(this.panel1);
            this.Name = "SubMarks";
            this.Text = "SubMarks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectMarksDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label departmentListLabel;
        private System.Windows.Forms.Label specialtyListLabel;
        private System.Windows.Forms.ComboBox specialtyComboBox;
        private System.Windows.Forms.Label groupListLabel;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Label subjectListLabel;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView subjectMarksDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gropColumn;
    }
}