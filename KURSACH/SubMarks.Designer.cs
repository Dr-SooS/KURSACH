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
            this.specialtyListLabel = new System.Windows.Forms.Label();
            this.specialtyComboBox = new System.Windows.Forms.ComboBox();
            this.groupListLabel = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.subjectListLabel = new System.Windows.Forms.Label();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teacherListLabel = new System.Windows.Forms.Label();
            this.teachersComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.subjectMarksDataGrid = new System.Windows.Forms.DataGridView();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gropColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectMarksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // specialtyListLabel
            // 
            this.specialtyListLabel.AutoSize = true;
            this.specialtyListLabel.Location = new System.Drawing.Point(662, 18);
            this.specialtyListLabel.Name = "specialtyListLabel";
            this.specialtyListLabel.Size = new System.Drawing.Size(109, 17);
            this.specialtyListLabel.TabIndex = 3;
            this.specialtyListLabel.Text = "Специальность";
            // 
            // specialtyComboBox
            // 
            this.specialtyComboBox.FormattingEnabled = true;
            this.specialtyComboBox.Location = new System.Drawing.Point(777, 15);
            this.specialtyComboBox.Name = "specialtyComboBox";
            this.specialtyComboBox.Size = new System.Drawing.Size(291, 24);
            this.specialtyComboBox.TabIndex = 2;
            this.specialtyComboBox.SelectedIndexChanged += new System.EventHandler(this.specialtyComboBox_SelectedIndexChanged);
            // 
            // groupListLabel
            // 
            this.groupListLabel.AutoSize = true;
            this.groupListLabel.Location = new System.Drawing.Point(1082, 18);
            this.groupListLabel.Name = "groupListLabel";
            this.groupListLabel.Size = new System.Drawing.Size(55, 17);
            this.groupListLabel.TabIndex = 5;
            this.groupListLabel.Text = "Группа";
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(1143, 15);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(121, 24);
            this.groupComboBox.TabIndex = 4;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // subjectListLabel
            // 
            this.subjectListLabel.AutoSize = true;
            this.subjectListLabel.Location = new System.Drawing.Point(19, 15);
            this.subjectListLabel.Name = "subjectListLabel";
            this.subjectListLabel.Size = new System.Drawing.Size(66, 17);
            this.subjectListLabel.TabIndex = 8;
            this.subjectListLabel.Text = "Предмет";
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(91, 12);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(121, 24);
            this.subjectComboBox.TabIndex = 7;
            this.subjectComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.teacherListLabel);
            this.panel1.Controls.Add(this.teachersComboBox);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.subjectComboBox);
            this.panel1.Controls.Add(this.subjectListLabel);
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
            // teacherListLabel
            // 
            this.teacherListLabel.AutoSize = true;
            this.teacherListLabel.Location = new System.Drawing.Point(234, 15);
            this.teacherListLabel.Name = "teacherListLabel";
            this.teacherListLabel.Size = new System.Drawing.Size(111, 17);
            this.teacherListLabel.TabIndex = 11;
            this.teacherListLabel.Text = "Преподаватель";
            // 
            // teachersComboBox
            // 
            this.teachersComboBox.FormattingEnabled = true;
            this.teachersComboBox.Location = new System.Drawing.Point(351, 12);
            this.teachersComboBox.Name = "teachersComboBox";
            this.teachersComboBox.Size = new System.Drawing.Size(280, 24);
            this.teachersComboBox.TabIndex = 10;
            this.teachersComboBox.SelectedIndexChanged += new System.EventHandler(this.teachersComboBox_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(1286, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 32);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            this.subjectMarksDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectMarksDataGrid_CellEndEdit);
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
            this.gropColumn.Width = 60;
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
        private System.Windows.Forms.Label specialtyListLabel;
        private System.Windows.Forms.ComboBox specialtyComboBox;
        private System.Windows.Forms.Label groupListLabel;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Label subjectListLabel;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView subjectMarksDataGrid;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gropColumn;
        private System.Windows.Forms.Label teacherListLabel;
        private System.Windows.Forms.ComboBox teachersComboBox;
    }
}