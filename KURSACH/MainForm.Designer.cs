namespace KURSACH
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.crudBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crudBtn
            // 
            this.crudBtn.Location = new System.Drawing.Point(42, 39);
            this.crudBtn.Name = "crudBtn";
            this.crudBtn.Size = new System.Drawing.Size(385, 38);
            this.crudBtn.TabIndex = 0;
            this.crudBtn.Text = "CRUD Отделений, групп, специальностей";
            this.crudBtn.UseVisualStyleBackColor = true;
            this.crudBtn.Click += new System.EventHandler(this.crudBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 253);
            this.Controls.Add(this.crudBtn);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button crudBtn;
    }
}

