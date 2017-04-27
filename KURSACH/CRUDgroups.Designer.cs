namespace KURSACH
{
    partial class CRUDgroups
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupNaumberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupSpecialtyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDepCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentListLabel = new System.Windows.Forms.Label();
            this.specialtyComboBox = new System.Windows.Forms.ComboBox();
            this.specialtyListLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.departmentComboBox);
            this.panel1.Controls.Add(this.departmentListLabel);
            this.panel1.Controls.Add(this.specialtyListLabel);
            this.panel1.Controls.Add(this.specialtyComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 67);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNaumberCol,
            this.groupSpecialtyCol,
            this.groupDepCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1386, 448);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupNaumberCol
            // 
            this.groupNaumberCol.HeaderText = "Номер";
            this.groupNaumberCol.Name = "groupNaumberCol";
            this.groupNaumberCol.ReadOnly = true;
            // 
            // groupSpecialtyCol
            // 
            this.groupSpecialtyCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.groupSpecialtyCol.HeaderText = "Специальность";
            this.groupSpecialtyCol.Name = "groupSpecialtyCol";
            this.groupSpecialtyCol.ReadOnly = true;
            // 
            // groupDepCol
            // 
            this.groupDepCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.groupDepCol.HeaderText = "Отделение";
            this.groupDepCol.Name = "groupDepCol";
            this.groupDepCol.ReadOnly = true;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(99, 31);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(260, 24);
            this.departmentComboBox.TabIndex = 4;
            // 
            // departmentListLabel
            // 
            this.departmentListLabel.AutoSize = true;
            this.departmentListLabel.Location = new System.Drawing.Point(11, 34);
            this.departmentListLabel.Name = "departmentListLabel";
            this.departmentListLabel.Size = new System.Drawing.Size(82, 17);
            this.departmentListLabel.TabIndex = 5;
            this.departmentListLabel.Text = "Отделение";
            // 
            // specialtyComboBox
            // 
            this.specialtyComboBox.FormattingEnabled = true;
            this.specialtyComboBox.Location = new System.Drawing.Point(480, 31);
            this.specialtyComboBox.Name = "specialtyComboBox";
            this.specialtyComboBox.Size = new System.Drawing.Size(121, 24);
            this.specialtyComboBox.TabIndex = 6;
            // 
            // specialtyListLabel
            // 
            this.specialtyListLabel.AutoSize = true;
            this.specialtyListLabel.Location = new System.Drawing.Point(365, 34);
            this.specialtyListLabel.Name = "specialtyListLabel";
            this.specialtyListLabel.Size = new System.Drawing.Size(109, 17);
            this.specialtyListLabel.TabIndex = 7;
            this.specialtyListLabel.Text = "Специальность";
            // 
            // CRUDgroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 515);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "CRUDgroups";
            this.Text = "CRUDdeps";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNaumberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupSpecialtyCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDepCol;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label departmentListLabel;
        private System.Windows.Forms.Label specialtyListLabel;
        private System.Windows.Forms.ComboBox specialtyComboBox;
    }
}