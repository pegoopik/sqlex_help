namespace sql_support_test.sqlex.help.ui.forms
{
    partial class LoginControl
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
            this.BLogin = new System.Windows.Forms.Button();
            this.TBUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LUserName = new System.Windows.Forms.Label();
            this.BGoAWay = new System.Windows.Forms.Button();
            this.LCaption = new System.Windows.Forms.Label();
            this.RBAdmin = new System.Windows.Forms.RadioButton();
            this.RBModerator = new System.Windows.Forms.RadioButton();
            this.RBUser = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(99, 181);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(75, 23);
            this.BLogin.TabIndex = 0;
            this.BLogin.Text = "Войти";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // TBUserName
            // 
            this.TBUserName.Location = new System.Drawing.Point(99, 143);
            this.TBUserName.Name = "TBUserName";
            this.TBUserName.Size = new System.Drawing.Size(162, 20);
            this.TBUserName.TabIndex = 2;
            this.TBUserName.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите права";
            // 
            // LUserName
            // 
            this.LUserName.AutoSize = true;
            this.LUserName.Location = new System.Drawing.Point(12, 146);
            this.LUserName.Name = "LUserName";
            this.LUserName.Size = new System.Drawing.Size(81, 13);
            this.LUserName.TabIndex = 4;
            this.LUserName.Text = "Введите логин";
            // 
            // BGoAWay
            // 
            this.BGoAWay.Location = new System.Drawing.Point(99, 220);
            this.BGoAWay.Name = "BGoAWay";
            this.BGoAWay.Size = new System.Drawing.Size(75, 23);
            this.BGoAWay.TabIndex = 6;
            this.BGoAWay.Text = "В ниикуда";
            this.BGoAWay.UseVisualStyleBackColor = true;
            this.BGoAWay.Click += new System.EventHandler(this.BGoAWay_Click);
            // 
            // LCaption
            // 
            this.LCaption.AutoSize = true;
            this.LCaption.Font = new System.Drawing.Font("Liberation Sans", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LCaption.Location = new System.Drawing.Point(38, 17);
            this.LCaption.Name = "LCaption";
            this.LCaption.Size = new System.Drawing.Size(181, 25);
            this.LCaption.TabIndex = 7;
            this.LCaption.Text = "Выполните вход";
            // 
            // RBAdmin
            // 
            this.RBAdmin.AutoSize = true;
            this.RBAdmin.Checked = true;
            this.RBAdmin.Location = new System.Drawing.Point(99, 63);
            this.RBAdmin.Name = "RBAdmin";
            this.RBAdmin.Size = new System.Drawing.Size(104, 17);
            this.RBAdmin.TabIndex = 8;
            this.RBAdmin.TabStop = true;
            this.RBAdmin.Text = "Администратор";
            this.RBAdmin.UseVisualStyleBackColor = true;
            // 
            // RBModerator
            // 
            this.RBModerator.AutoSize = true;
            this.RBModerator.Location = new System.Drawing.Point(99, 86);
            this.RBModerator.Name = "RBModerator";
            this.RBModerator.Size = new System.Drawing.Size(81, 17);
            this.RBModerator.TabIndex = 9;
            this.RBModerator.Text = "Модератор";
            this.RBModerator.UseVisualStyleBackColor = true;
            // 
            // RBUser
            // 
            this.RBUser.AutoSize = true;
            this.RBUser.Location = new System.Drawing.Point(99, 109);
            this.RBUser.Name = "RBUser";
            this.RBUser.Size = new System.Drawing.Size(98, 17);
            this.RBUser.TabIndex = 10;
            this.RBUser.Text = "Пользователь";
            this.RBUser.UseVisualStyleBackColor = true;
            // 
            // LoginControl
            // 
            this.AccessibleName = "Аутентификация";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RBUser);
            this.Controls.Add(this.RBModerator);
            this.Controls.Add(this.RBAdmin);
            this.Controls.Add(this.LCaption);
            this.Controls.Add(this.BGoAWay);
            this.Controls.Add(this.LUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBUserName);
            this.Controls.Add(this.BLogin);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(323, 298);
            this.Load += new System.EventHandler(this.LoginControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.TextBox TBUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LUserName;
        private System.Windows.Forms.Button BGoAWay;
        private System.Windows.Forms.Label LCaption;
        private System.Windows.Forms.RadioButton RBAdmin;
        private System.Windows.Forms.RadioButton RBModerator;
        private System.Windows.Forms.RadioButton RBUser;
    }
}
