namespace sql_support_test.sqlex.help.ui.forms
{
    partial class HelloControl
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
            this.LCaption = new System.Windows.Forms.Label();
            this.BLogin = new System.Windows.Forms.Button();
            this.LStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BGoAWay
            // 
            this.BGoAWay.Location = new System.Drawing.Point(23, 208);
            this.BGoAWay.Name = "BGoAWay";
            this.BGoAWay.Size = new System.Drawing.Size(90, 28);
            this.BGoAWay.TabIndex = 2;
            this.BGoAWay.Text = "В ниикуда";
            this.BGoAWay.UseVisualStyleBackColor = true;
            this.BGoAWay.Click += new System.EventHandler(this.BGoAWay_Click);
            // 
            // LCaption
            // 
            this.LCaption.AutoSize = true;
            this.LCaption.Font = new System.Drawing.Font("Liberation Sans", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LCaption.Location = new System.Drawing.Point(18, 24);
            this.LCaption.Name = "LCaption";
            this.LCaption.Size = new System.Drawing.Size(366, 25);
            this.LCaption.TabIndex = 3;
            this.LCaption.Text = "Добро пожаловать в Sql-Ex Helper";
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(23, 153);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(90, 28);
            this.BLogin.TabIndex = 4;
            this.BLogin.Text = "Продолжить";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // LStats
            // 
            this.LStats.AutoSize = true;
            this.LStats.Location = new System.Drawing.Point(28, 69);
            this.LStats.Name = "LStats";
            this.LStats.Size = new System.Drawing.Size(282, 13);
            this.LStats.TabIndex = 5;
            this.LStats.Text = "TODO вывести информацию о загруженных объектах";
            // 
            // HelloControl
            // 
            this.AccessibleName = "Добро пожаловать!";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LStats);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.LCaption);
            this.Controls.Add(this.BGoAWay);
            this.Name = "HelloControl";
            this.Size = new System.Drawing.Size(423, 293);
            this.Load += new System.EventHandler(this.HelloControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BGoAWay;
        private System.Windows.Forms.Label LCaption;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.Label LStats;
    }
}
