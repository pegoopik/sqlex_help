namespace sql_support_test.sqlex.help.ui.forms
{
    partial class TicketListControl
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
            this.PTop = new System.Windows.Forms.Panel();
            this.PBottom = new System.Windows.Forms.Panel();
            this.PBody = new System.Windows.Forms.Panel();
            this.WBBody = new System.Windows.Forms.WebBrowser();
            this.PBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // PTop
            // 
            this.PTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PTop.BackColor = System.Drawing.SystemColors.Info;
            this.PTop.Location = new System.Drawing.Point(0, 0);
            this.PTop.Margin = new System.Windows.Forms.Padding(1);
            this.PTop.Name = "PTop";
            this.PTop.Size = new System.Drawing.Size(607, 60);
            this.PTop.TabIndex = 0;
            this.PTop.Paint += new System.Windows.Forms.PaintEventHandler(this.PTop_Paint);
            // 
            // PBottom
            // 
            this.PBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBottom.BackColor = System.Drawing.SystemColors.Info;
            this.PBottom.Location = new System.Drawing.Point(0, 323);
            this.PBottom.Margin = new System.Windows.Forms.Padding(1);
            this.PBottom.Name = "PBottom";
            this.PBottom.Size = new System.Drawing.Size(606, 106);
            this.PBottom.TabIndex = 1;
            // 
            // PBody
            // 
            this.PBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBody.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PBody.Controls.Add(this.WBBody);
            this.PBody.Location = new System.Drawing.Point(0, 59);
            this.PBody.Margin = new System.Windows.Forms.Padding(1);
            this.PBody.Name = "PBody";
            this.PBody.Size = new System.Drawing.Size(606, 262);
            this.PBody.TabIndex = 2;
            // 
            // WBBody
            // 
            this.WBBody.AccessibleName = "Список тикетов";
            this.WBBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WBBody.Location = new System.Drawing.Point(3, 3);
            this.WBBody.Margin = new System.Windows.Forms.Padding(1);
            this.WBBody.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBBody.Name = "WBBody";
            this.WBBody.Size = new System.Drawing.Size(602, 258);
            this.WBBody.TabIndex = 0;
            this.WBBody.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // TicketListControl
            // 
            this.AccessibleName = "Список тикетов";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.PBody);
            this.Controls.Add(this.PBottom);
            this.Controls.Add(this.PTop);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TicketListControl";
            this.Size = new System.Drawing.Size(607, 430);
            this.PBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PTop;
        private System.Windows.Forms.Panel PBottom;
        private System.Windows.Forms.Panel PBody;
        private System.Windows.Forms.WebBrowser WBBody;
    }
}
