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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кТToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКТToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьКТToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКТToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПредметToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьПредметToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПредметToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectMarksDataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 28);
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
            this.subjectMarksDataGrid.Location = new System.Drawing.Point(0, 78);
            this.subjectMarksDataGrid.Name = "subjectMarksDataGrid";
            this.subjectMarksDataGrid.Size = new System.Drawing.Size(1403, 517);
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1403, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кТToolStripMenuItem,
            this.преподавателиToolStripMenuItem,
            this.предметыToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // кТToolStripMenuItem
            // 
            this.кТToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКТToolStripMenuItem1,
            this.изменитьКТToolStripMenuItem1,
            this.удалитьКТToolStripMenuItem1});
            this.кТToolStripMenuItem.Name = "кТToolStripMenuItem";
            this.кТToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.кТToolStripMenuItem.Text = "КТ";
            // 
            // добавитьКТToolStripMenuItem1
            // 
            this.добавитьКТToolStripMenuItem1.Name = "добавитьКТToolStripMenuItem1";
            this.добавитьКТToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.добавитьКТToolStripMenuItem1.Text = "Добавить КТ";
            this.добавитьКТToolStripMenuItem1.Click += new System.EventHandler(this.добавитьКТToolStripMenuItem_Click);
            // 
            // изменитьКТToolStripMenuItem1
            // 
            this.изменитьКТToolStripMenuItem1.Name = "изменитьКТToolStripMenuItem1";
            this.изменитьКТToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.изменитьКТToolStripMenuItem1.Text = "Изменить КТ ";
            this.изменитьКТToolStripMenuItem1.Click += new System.EventHandler(this.изменитьКТToolStripMenuItem_Click);
            // 
            // удалитьКТToolStripMenuItem1
            // 
            this.удалитьКТToolStripMenuItem1.Name = "удалитьКТToolStripMenuItem1";
            this.удалитьКТToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.удалитьКТToolStripMenuItem1.Text = "Удалить КТ";
            this.удалитьКТToolStripMenuItem1.Click += new System.EventHandler(this.удалитьКТToolStripMenuItem_Click);
            // 
            // преподавателиToolStripMenuItem
            // 
            this.преподавателиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            this.преподавателиToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.преподавателиToolStripMenuItem.Text = "Преподаватели";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить преподавателя";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить преподавателя";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить преподавателя";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // предметыToolStripMenuItem
            // 
            this.предметыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПредметToolStripMenuItem,
            this.изменитьПредметToolStripMenuItem,
            this.удалитьПредметToolStripMenuItem});
            this.предметыToolStripMenuItem.Name = "предметыToolStripMenuItem";
            this.предметыToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.предметыToolStripMenuItem.Text = "Предметы";
            // 
            // добавитьПредметToolStripMenuItem
            // 
            this.добавитьПредметToolStripMenuItem.Name = "добавитьПредметToolStripMenuItem";
            this.добавитьПредметToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.добавитьПредметToolStripMenuItem.Text = "Добавить предмет";
            this.добавитьПредметToolStripMenuItem.Click += new System.EventHandler(this.добавитьПредметToolStripMenuItem_Click);
            // 
            // изменитьПредметToolStripMenuItem
            // 
            this.изменитьПредметToolStripMenuItem.Name = "изменитьПредметToolStripMenuItem";
            this.изменитьПредметToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.изменитьПредметToolStripMenuItem.Text = "Изменить предмет";
            this.изменитьПредметToolStripMenuItem.Click += new System.EventHandler(this.изменитьПредметToolStripMenuItem_Click);
            // 
            // удалитьПредметToolStripMenuItem
            // 
            this.удалитьПредметToolStripMenuItem.Name = "удалитьПредметToolStripMenuItem";
            this.удалитьПредметToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.удалитьПредметToolStripMenuItem.Text = "Удалить предмет";
            this.удалитьПредметToolStripMenuItem.Click += new System.EventHandler(this.удалитьПредметToolStripMenuItem_Click);
            // 
            // SubMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 595);
            this.Controls.Add(this.subjectMarksDataGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SubMarks";
            this.Text = "SubMarks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectMarksDataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кТToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКТToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьКТToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьКТToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem преподавателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПредметToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьПредметToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПредметToolStripMenuItem;
    }
}