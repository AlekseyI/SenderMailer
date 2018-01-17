namespace SmtpSender
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusSend = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.MyMail = new System.Windows.Forms.ToolStripTextBox();
            this.TypeMyMail = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.MyPassword = new System.Windows.Forms.ToolStripTextBox();
            this.включитьSSLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IsSsl = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Port = new System.Windows.Forms.ToolStripTextBox();
            this.испHtmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IsHtml = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.IsAsyncSend = new System.Windows.Forms.ToolStripComboBox();
            this.MailTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeMail = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.TextBox();
            this.buttonFile = new System.Windows.Forms.Button();
            this.OpenFiles = new System.Windows.Forms.OpenFileDialog();
            this.TextMessage = new System.Windows.Forms.RichTextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.AttachFiles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusSend});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(647, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusSend
            // 
            this.StatusSend.Name = "StatusSend";
            this.StatusSend.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMail,
            this.включитьSSLToolStripMenuItem,
            this.toolStripMenuItem1,
            this.испHtmlToolStripMenuItem,
            this.toolStripMenuItem2});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // toolStripMenuItemMail
            // 
            this.toolStripMenuItemMail.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2,
            this.MyMail,
            this.TypeMyMail,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.MyPassword});
            this.toolStripMenuItemMail.Name = "toolStripMenuItemMail";
            this.toolStripMenuItemMail.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItemMail.Text = "Моя почта";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Enabled = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(150, 23);
            this.toolStripTextBox2.Text = "Почта";
            // 
            // MyMail
            // 
            this.MyMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyMail.Name = "MyMail";
            this.MyMail.Size = new System.Drawing.Size(150, 23);
            this.MyMail.Tag = "Data";
            // 
            // TypeMyMail
            // 
            this.TypeMyMail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeMyMail.Name = "TypeMyMail";
            this.TypeMyMail.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 23);
            this.toolStripTextBox1.Text = "Пароль";
            // 
            // MyPassword
            // 
            this.MyPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyPassword.Name = "MyPassword";
            this.MyPassword.Size = new System.Drawing.Size(150, 23);
            this.MyPassword.Tag = "Data";
            // 
            // включитьSSLToolStripMenuItem
            // 
            this.включитьSSLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IsSsl});
            this.включитьSSLToolStripMenuItem.Name = "включитьSSLToolStripMenuItem";
            this.включитьSSLToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.включитьSSLToolStripMenuItem.Tag = "Data";
            this.включитьSSLToolStripMenuItem.Text = "SSL";
            // 
            // IsSsl
            // 
            this.IsSsl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsSsl.Items.AddRange(new object[] {
            "Включено",
            "Выключено"});
            this.IsSsl.Name = "IsSsl";
            this.IsSsl.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Port});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItem1.Text = "Port";
            // 
            // Port
            // 
            this.Port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 23);
            this.Port.Tag = "Data";
            // 
            // испHtmlToolStripMenuItem
            // 
            this.испHtmlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IsHtml});
            this.испHtmlToolStripMenuItem.Name = "испHtmlToolStripMenuItem";
            this.испHtmlToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.испHtmlToolStripMenuItem.Text = "Исп. Html";
            // 
            // IsHtml
            // 
            this.IsHtml.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsHtml.Items.AddRange(new object[] {
            "Включено",
            "Выключено"});
            this.IsHtml.Name = "IsHtml";
            this.IsHtml.Size = new System.Drawing.Size(121, 23);
            this.IsHtml.Tag = "Data";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IsAsyncSend});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItem2.Text = "Асинхрон. отправка";
            // 
            // IsAsyncSend
            // 
            this.IsAsyncSend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsAsyncSend.Items.AddRange(new object[] {
            "Включено",
            "Выключено"});
            this.IsAsyncSend.Name = "IsAsyncSend";
            this.IsAsyncSend.Size = new System.Drawing.Size(121, 23);
            // 
            // MailTo
            // 
            this.MailTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailTo.Location = new System.Drawing.Point(102, 40);
            this.MailTo.Name = "MailTo";
            this.MailTo.Size = new System.Drawing.Size(420, 20);
            this.MailTo.TabIndex = 2;
            this.MailTo.Tag = "Data";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Почтовый ящик\r\nполучателя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeMail
            // 
            this.TypeMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeMail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TypeMail.FormattingEnabled = true;
            this.TypeMail.Location = new System.Drawing.Point(528, 40);
            this.TypeMail.Name = "TypeMail";
            this.TypeMail.Size = new System.Drawing.Size(107, 21);
            this.TypeMail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ваше имя";
            // 
            // MyName
            // 
            this.MyName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyName.Location = new System.Drawing.Point(102, 66);
            this.MyName.Name = "MyName";
            this.MyName.Size = new System.Drawing.Size(533, 20);
            this.MyName.TabIndex = 5;
            this.MyName.Tag = "Data";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тема письма";
            // 
            // Subject
            // 
            this.Subject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Subject.Location = new System.Drawing.Point(102, 92);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(533, 20);
            this.Subject.TabIndex = 7;
            this.Subject.Tag = "Data";
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(15, 118);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(117, 23);
            this.buttonFile.TabIndex = 9;
            this.buttonFile.Text = "Прикрепить файлы";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // OpenFiles
            // 
            this.OpenFiles.FileName = "FileName";
            this.OpenFiles.Multiselect = true;
            // 
            // TextMessage
            // 
            this.TextMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextMessage.BackColor = System.Drawing.SystemColors.Window;
            this.TextMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextMessage.EnableAutoDragDrop = true;
            this.TextMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextMessage.Location = new System.Drawing.Point(13, 148);
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(622, 333);
            this.TextMessage.TabIndex = 10;
            this.TextMessage.Text = "";
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.Location = new System.Drawing.Point(518, 118);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(117, 23);
            this.buttonSend.TabIndex = 11;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // AttachFiles
            // 
            this.AttachFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AttachFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AttachFiles.FormattingEnabled = true;
            this.AttachFiles.Location = new System.Drawing.Point(188, 118);
            this.AttachFiles.Name = "AttachFiles";
            this.AttachFiles.Size = new System.Drawing.Size(171, 21);
            this.AttachFiles.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Файлы";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 506);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AttachFiles);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MyName);
            this.Controls.Add(this.TypeMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MailTo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(505, 400);
            this.Name = "MainForm";
            this.Text = "Отправка сообщений";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem включитьSSLToolStripMenuItem;
        internal System.Windows.Forms.ToolStripComboBox IsSsl;
        internal System.Windows.Forms.TextBox MailTo;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox TypeMail;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox MyName;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Button buttonFile;
        internal System.Windows.Forms.OpenFileDialog OpenFiles;
        internal System.Windows.Forms.RichTextBox TextMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        internal System.Windows.Forms.ToolStripTextBox Port;
        internal System.Windows.Forms.ToolStripMenuItem испHtmlToolStripMenuItem;
        internal System.Windows.Forms.ToolStripComboBox IsHtml;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMail;
        internal System.Windows.Forms.ToolStripTextBox MyMail;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        internal System.Windows.Forms.ToolStripTextBox MyPassword;
        internal System.Windows.Forms.ToolStripComboBox TypeMyMail;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        internal System.Windows.Forms.ToolStripComboBox IsAsyncSend;
        internal System.Windows.Forms.ToolStripStatusLabel StatusSend;
        internal System.Windows.Forms.ComboBox AttachFiles;
        private System.Windows.Forms.Label label4;
    }
}

