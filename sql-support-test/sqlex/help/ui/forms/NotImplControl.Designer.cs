namespace sql_support_test.sqlex.help.ui.forms
{
    partial class NotImplControl
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
            this.BGoAWay = new System.Windows.Forms.Button();
            this.BHello = new System.Windows.Forms.Button();
            this.LCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BGoAWay
            // 
            this.BGoAWay.Location = new System.Drawing.Point(152, 130);
            this.BGoAWay.Name = "BGoAWay";
            this.BGoAWay.Size = new System.Drawing.Size(90, 28);
            this.BGoAWay.TabIndex = 2;
            this.BGoAWay.Text = "В ниикуда";
            this.BGoAWay.UseVisualStyleBackColor = true;
            this.BGoAWay.Click += new System.EventHandler(this.BGoAWay_Click);
            // 
            // BHello
            // 
            this.BHello.AccessibleName = "Пока не реализовано";
            this.BHello.Location = new System.Drawing.Point(39, 130);
            this.BHello.Name = "BHello";
            this.BHello.Size = new System.Drawing.Size(90, 27);
            this.BHello.TabIndex = 3;
            this.BHello.Text = "В начало";
            this.BHello.UseVisualStyleBackColor = true;
            this.BHello.Click += new System.EventHandler(this.BHello_Click);
            // 
            // LCaption
            // 
            this.LCaption.AccessibleName = "Template Phase Name";
            this.LCaption.AutoSize = true;
            this.LCaption.Font = new System.Drawing.Font("Liberation Sans", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LCaption.Location = new System.Drawing.Point(20, 27);
            this.LCaption.Name = "LCaption";
            this.LCaption.Size = new System.Drawing.Size(244, 25);
            this.LCaption.TabIndex = 4;
            this.LCaption.Text = "Пока не реализовано:(";
            // 
            // NotImplControl
            // 
            this.AccessibleName = "Пока не реализовано :(";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LCaption);
            this.Controls.Add(this.BHello);
            this.Controls.Add(this.BGoAWay);
            this.Name = "NotImplControl";
            this.Size = new System.Drawing.Size(279, 264);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BGoAWay;
        private System.Windows.Forms.Button BHello;
        private System.Windows.Forms.Label LCaption;
    }
}
