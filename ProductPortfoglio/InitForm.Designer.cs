namespace ProductPortfoglio
{
    partial class InitForm
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
            this.startBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.exitBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startBtn.AutoSize = true;
            this.startBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.startBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.startBtn.Location = new System.Drawing.Point(323, 317);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(314, 52);
            this.startBtn.Style = MetroFramework.MetroColorStyle.Magenta;
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Начать";
            this.startBtn.UseSelectable = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(345, 167);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(273, 75);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Программа-портфолио проектов\r\nСтудента группы ИП-17-3\r\nЗыкина Германа Леонидовича" +
    "";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitBtn.AutoSize = true;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.exitBtn.Location = new System.Drawing.Point(323, 465);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(314, 52);
            this.exitBtn.Style = MetroFramework.MetroColorStyle.Magenta;
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Выйти";
            this.exitBtn.UseSelectable = true;
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.startBtn);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "InitForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Портфолио продуктов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton startBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton exitBtn;
    }
}

