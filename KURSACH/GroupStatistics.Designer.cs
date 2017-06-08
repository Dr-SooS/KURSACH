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
			this.groupListBox = new System.Windows.Forms.ListBox();
			this.filtersPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupInfoPanel = new System.Windows.Forms.Panel();
			this.StudentListPanel = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupListBox
			// 
			this.groupListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupListBox.FormattingEnabled = true;
			this.groupListBox.ItemHeight = 16;
			this.groupListBox.Location = new System.Drawing.Point(0, 0);
			this.groupListBox.Name = "groupListBox";
			this.groupListBox.Size = new System.Drawing.Size(200, 708);
			this.groupListBox.TabIndex = 0;
			this.groupListBox.SelectedIndexChanged += new System.EventHandler(this.groupListBox_SelectedIndexChanged);
			// 
			// filtersPanel
			// 
			this.filtersPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.filtersPanel.Location = new System.Drawing.Point(0, 0);
			this.filtersPanel.Name = "filtersPanel";
			this.filtersPanel.Size = new System.Drawing.Size(1219, 60);
			this.filtersPanel.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupListBox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 60);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 708);
			this.panel1.TabIndex = 2;
			// 
			// groupInfoPanel
			// 
			this.groupInfoPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupInfoPanel.Location = new System.Drawing.Point(200, 60);
			this.groupInfoPanel.Name = "groupInfoPanel";
			this.groupInfoPanel.Size = new System.Drawing.Size(288, 708);
			this.groupInfoPanel.TabIndex = 3;
			// 
			// StudentListPanel
			// 
			this.StudentListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StudentListPanel.Location = new System.Drawing.Point(488, 60);
			this.StudentListPanel.Name = "StudentListPanel";
			this.StudentListPanel.Size = new System.Drawing.Size(731, 708);
			this.StudentListPanel.TabIndex = 4;
			// 
			// GroupStatistics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1219, 768);
			this.Controls.Add(this.StudentListPanel);
			this.Controls.Add(this.groupInfoPanel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.filtersPanel);
			this.Name = "GroupStatistics";
			this.Text = "GroupStatistics";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox groupListBox;
		private System.Windows.Forms.Panel filtersPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel groupInfoPanel;
		private System.Windows.Forms.Panel StudentListPanel;
	}
}