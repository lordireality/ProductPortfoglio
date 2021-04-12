namespace ProductPortfoglio
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
            this.addBtn = new MetroFramework.Controls.MetroButton();
            this.projectList = new System.Windows.Forms.ListBox();
            this.ProjectPanel = new System.Windows.Forms.Panel();
            this.execApp = new MetroFramework.Controls.MetroButton();
            this.editBtn = new MetroFramework.Controls.MetroButton();
            this.pictureNumLabel = new MetroFramework.Controls.MetroLabel();
            this.projectDescTextBox = new System.Windows.Forms.RichTextBox();
            this.openInBrowser = new MetroFramework.Controls.MetroButton();
            this.projectNameLabel = new MetroFramework.Controls.MetroLabel();
            this.prevImgBtn = new System.Windows.Forms.Button();
            this.nextImgBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.ProjectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addBtn.AutoSize = true;
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.addBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addBtn.Location = new System.Drawing.Point(23, 454);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(276, 52);
            this.addBtn.Style = MetroFramework.MetroColorStyle.Magenta;
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseSelectable = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // projectList
            // 
            this.projectList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.projectList.FormattingEnabled = true;
            this.projectList.Items.AddRange(new object[] {
            "Project1",
            "Project1",
            "Project1",
            "Project1",
            "Project1",
            "Project1",
            "Project1"});
            this.projectList.Location = new System.Drawing.Point(23, 63);
            this.projectList.Name = "projectList";
            this.projectList.Size = new System.Drawing.Size(276, 368);
            this.projectList.TabIndex = 3;
            this.projectList.SelectedIndexChanged += new System.EventHandler(this.projectList_SelectedIndexChanged);
            // 
            // ProjectPanel
            // 
            this.ProjectPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProjectPanel.Controls.Add(this.deleteBtn);
            this.ProjectPanel.Controls.Add(this.execApp);
            this.ProjectPanel.Controls.Add(this.editBtn);
            this.ProjectPanel.Controls.Add(this.pictureNumLabel);
            this.ProjectPanel.Controls.Add(this.projectDescTextBox);
            this.ProjectPanel.Controls.Add(this.openInBrowser);
            this.ProjectPanel.Controls.Add(this.projectNameLabel);
            this.ProjectPanel.Controls.Add(this.prevImgBtn);
            this.ProjectPanel.Controls.Add(this.nextImgBtn);
            this.ProjectPanel.Controls.Add(this.pictureBox1);
            this.ProjectPanel.Location = new System.Drawing.Point(306, 64);
            this.ProjectPanel.Name = "ProjectPanel";
            this.ProjectPanel.Size = new System.Drawing.Size(631, 442);
            this.ProjectPanel.TabIndex = 5;
            // 
            // execApp
            // 
            this.execApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.execApp.AutoSize = true;
            this.execApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.execApp.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.execApp.ForeColor = System.Drawing.SystemColors.Control;
            this.execApp.Location = new System.Drawing.Point(468, 401);
            this.execApp.Name = "execApp";
            this.execApp.Size = new System.Drawing.Size(158, 36);
            this.execApp.Style = MetroFramework.MetroColorStyle.Magenta;
            this.execApp.TabIndex = 11;
            this.execApp.Text = "Запустить приложение";
            this.execApp.UseSelectable = true;
            this.execApp.Click += new System.EventHandler(this.execApp_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editBtn.AutoSize = true;
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.editBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.editBtn.Location = new System.Drawing.Point(3, 401);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(136, 36);
            this.editBtn.Style = MetroFramework.MetroColorStyle.Magenta;
            this.editBtn.TabIndex = 10;
            this.editBtn.Text = "Редактировать";
            this.editBtn.UseSelectable = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // pictureNumLabel
            // 
            this.pictureNumLabel.AutoSize = true;
            this.pictureNumLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.pictureNumLabel.Location = new System.Drawing.Point(262, 171);
            this.pictureNumLabel.Name = "pictureNumLabel";
            this.pictureNumLabel.Size = new System.Drawing.Size(121, 19);
            this.pictureNumLabel.TabIndex = 9;
            this.pictureNumLabel.Text = "Изображение 1/3";
            this.pictureNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectDescTextBox
            // 
            this.projectDescTextBox.Location = new System.Drawing.Point(12, 237);
            this.projectDescTextBox.Name = "projectDescTextBox";
            this.projectDescTextBox.ReadOnly = true;
            this.projectDescTextBox.Size = new System.Drawing.Size(598, 98);
            this.projectDescTextBox.TabIndex = 8;
            this.projectDescTextBox.Text = "Description placeholder";
            // 
            // openInBrowser
            // 
            this.openInBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openInBrowser.AutoSize = true;
            this.openInBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openInBrowser.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.openInBrowser.ForeColor = System.Drawing.SystemColors.Control;
            this.openInBrowser.Location = new System.Drawing.Point(468, 359);
            this.openInBrowser.Name = "openInBrowser";
            this.openInBrowser.Size = new System.Drawing.Size(158, 36);
            this.openInBrowser.Style = MetroFramework.MetroColorStyle.Magenta;
            this.openInBrowser.TabIndex = 6;
            this.openInBrowser.Text = "Смотреть в браузере";
            this.openInBrowser.UseSelectable = true;
            this.openInBrowser.Click += new System.EventHandler(this.openInBrowser_Click);
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.projectNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.projectNameLabel.Location = new System.Drawing.Point(238, 209);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(173, 25);
            this.projectNameLabel.TabIndex = 7;
            this.projectNameLabel.Text = "Название проекта";
            this.projectNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prevImgBtn
            // 
            this.prevImgBtn.Location = new System.Drawing.Point(12, 18);
            this.prevImgBtn.Name = "prevImgBtn";
            this.prevImgBtn.Size = new System.Drawing.Size(57, 150);
            this.prevImgBtn.TabIndex = 6;
            this.prevImgBtn.Text = "←\r\n←\r\n←";
            this.prevImgBtn.UseVisualStyleBackColor = true;
            this.prevImgBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // nextImgBtn
            // 
            this.nextImgBtn.Location = new System.Drawing.Point(553, 18);
            this.nextImgBtn.Name = "nextImgBtn";
            this.nextImgBtn.Size = new System.Drawing.Size(57, 150);
            this.nextImgBtn.TabIndex = 5;
            this.nextImgBtn.Text = "→\r\n→\r\n→";
            this.nextImgBtn.UseVisualStyleBackColor = true;
            this.nextImgBtn.Click += new System.EventHandler(this.nextImgBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::ProductPortfoglio.Properties.Resources.GUIBack_2;
            this.pictureBox1.Location = new System.Drawing.Point(86, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteBtn.AutoSize = true;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteBtn.Location = new System.Drawing.Point(145, 401);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(136, 36);
            this.deleteBtn.Style = MetroFramework.MetroColorStyle.Magenta;
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 529);
            this.Controls.Add(this.ProjectPanel);
            this.Controls.Add(this.projectList);
            this.Controls.Add(this.addBtn);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Портфолио продуктов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ProjectPanel.ResumeLayout(false);
            this.ProjectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton addBtn;
        private System.Windows.Forms.ListBox projectList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel ProjectPanel;
        private System.Windows.Forms.Button prevImgBtn;
        private System.Windows.Forms.Button nextImgBtn;
        private System.Windows.Forms.RichTextBox projectDescTextBox;
        private MetroFramework.Controls.MetroButton openInBrowser;
        private MetroFramework.Controls.MetroLabel projectNameLabel;
        private MetroFramework.Controls.MetroLabel pictureNumLabel;
        private MetroFramework.Controls.MetroButton editBtn;
        private MetroFramework.Controls.MetroButton execApp;
        private MetroFramework.Controls.MetroButton deleteBtn;
    }
}

