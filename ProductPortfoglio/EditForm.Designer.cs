namespace ProductPortfoglio
{
    partial class EditForm
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
            this.editBtn = new MetroFramework.Controls.MetroButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descTextBox = new System.Windows.Forms.RichTextBox();
            this.hasPath = new System.Windows.Forms.CheckBox();
            this.hasLink = new System.Windows.Forms.CheckBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.pictureNumLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editBtn.AutoSize = true;
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.editBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.editBtn.Location = new System.Drawing.Point(237, 328);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(136, 36);
            this.editBtn.Style = MetroFramework.MetroColorStyle.Magenta;
            this.editBtn.TabIndex = 11;
            this.editBtn.Text = "Редактировать";
            this.editBtn.UseSelectable = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(143, 80);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(434, 20);
            this.nameTextBox.TabIndex = 12;
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(143, 107);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(434, 96);
            this.descTextBox.TabIndex = 13;
            this.descTextBox.Text = "";
            // 
            // hasPath
            // 
            this.hasPath.AutoSize = true;
            this.hasPath.Location = new System.Drawing.Point(23, 210);
            this.hasPath.Name = "hasPath";
            this.hasPath.Size = new System.Drawing.Size(217, 17);
            this.hasPath.TabIndex = 14;
            this.hasPath.Text = "Есть ли путь к исполняемому файлу?";
            this.hasPath.UseVisualStyleBackColor = true;
            this.hasPath.CheckedChanged += new System.EventHandler(this.hasPath_CheckedChanged);
            // 
            // hasLink
            // 
            this.hasLink.AutoSize = true;
            this.hasLink.Location = new System.Drawing.Point(23, 268);
            this.hasLink.Name = "hasLink";
            this.hasLink.Size = new System.Drawing.Size(180, 17);
            this.hasLink.TabIndex = 15;
            this.hasLink.Text = "Есть ли ссылка на веб-ресурс";
            this.hasLink.UseVisualStyleBackColor = true;
            this.hasLink.CheckedChanged += new System.EventHandler(this.hasLink_CheckedChanged);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Enabled = false;
            this.pathTextBox.Location = new System.Drawing.Point(112, 233);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(465, 20);
            this.pathTextBox.TabIndex = 16;
            // 
            // linkTextBox
            // 
            this.linkTextBox.Enabled = false;
            this.linkTextBox.Location = new System.Drawing.Point(112, 291);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(465, 20);
            this.linkTextBox.TabIndex = 17;
            // 
            // pictureNumLabel
            // 
            this.pictureNumLabel.AutoSize = true;
            this.pictureNumLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.pictureNumLabel.Location = new System.Drawing.Point(23, 80);
            this.pictureNumLabel.Name = "pictureNumLabel";
            this.pictureNumLabel.Size = new System.Drawing.Size(104, 19);
            this.pictureNumLabel.TabIndex = 18;
            this.pictureNumLabel.Text = "Наименование";
            this.pictureNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 116);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Описание";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 234);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Путь";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(23, 292);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Адрес";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 387);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureNumLabel);
            this.Controls.Add(this.linkTextBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.hasLink);
            this.Controls.Add(this.hasPath);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.editBtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 387);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 387);
            this.Name = "EditForm";
            this.Text = "Редактирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton editBtn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RichTextBox descTextBox;
        private System.Windows.Forms.CheckBox hasPath;
        private System.Windows.Forms.CheckBox hasLink;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.TextBox linkTextBox;
        private MetroFramework.Controls.MetroLabel pictureNumLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}