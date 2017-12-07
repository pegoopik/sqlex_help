namespace sql_support_test.sqlex.help.ui.forms
{
    partial class DefaultUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LCaption = new System.Windows.Forms.Label();
            this.BGoAWay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LCaption
            // 
            this.LCaption.AccessibleName = "Template Phase Name";
            this.LCaption.AutoSize = true;
            this.LCaption.Font = new System.Drawing.Font("Liberation Sans", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LCaption.Location = new System.Drawing.Point(16, 9);
            this.LCaption.Name = "LCaption";
            this.LCaption.Size = new System.Drawing.Size(206, 25);
            this.LCaption.TabIndex = 0;
            this.LCaption.Text = "Шаблон Заголовка";
            // 
            // BGoAWay
            // 
            this.BGoAWay.Location = new System.Drawing.Point(21, 167);
            this.BGoAWay.Name = "BGoAWay";
            this.BGoAWay.Size = new System.Drawing.Size(90, 28);
            this.BGoAWay.TabIndex = 1;
            this.BGoAWay.Text = "В ниикуда";
            this.BGoAWay.UseVisualStyleBackColor = true;
            this.BGoAWay.Click += new System.EventHandler(this.BGoAWay_Click);
            // 
            // DefaultUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BGoAWay);
            this.Controls.Add(this.LCaption);
            this.Name = "DefaultUserControl";
            this.Size = new System.Drawing.Size(397, 330);
            this.Load += new System.EventHandler(this.DefaultUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LCaption;
        private System.Windows.Forms.Button BGoAWay;
    }
}
