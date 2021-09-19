namespace War3BnetIconPreview
{
    partial class BNETPREVIEWICON
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.IconPreview = new System.Windows.Forms.PictureBox();
            this.SelectBackgroundColor = new System.Windows.Forms.ColorDialog();
            this.BtnColorSelect = new System.Windows.Forms.Button();
            this.iCONselect = new System.Windows.Forms.PictureBox();
            this.BtnSelectIcon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TransparentPower = new System.Windows.Forms.TrackBar();
            this.PreviewTimer = new System.Windows.Forms.Timer(this.components);
            this.colorpicker = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ColorPickTimer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.SelectPowerType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCONselect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransparentPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorpicker)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(217, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IconPreview
            // 
            this.IconPreview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IconPreview.BackgroundImage = global::War3BnetIconPreview.Properties.Resources.previewbackground;
            this.IconPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IconPreview.InitialImage = null;
            this.IconPreview.Location = new System.Drawing.Point(26, 12);
            this.IconPreview.Name = "IconPreview";
            this.IconPreview.Size = new System.Drawing.Size(156, 50);
            this.IconPreview.TabIndex = 1;
            this.IconPreview.TabStop = false;
            this.IconPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BNETPREVIEWICON_MouseDown);
            // 
            // SelectBackgroundColor
            // 
            this.SelectBackgroundColor.AnyColor = true;
            this.SelectBackgroundColor.FullOpen = true;
            this.SelectBackgroundColor.ShowHelp = true;
            // 
            // BtnColorSelect
            // 
            this.BtnColorSelect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnColorSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnColorSelect.Location = new System.Drawing.Point(26, 67);
            this.BtnColorSelect.Name = "BtnColorSelect";
            this.BtnColorSelect.Size = new System.Drawing.Size(85, 23);
            this.BtnColorSelect.TabIndex = 2;
            this.BtnColorSelect.Text = "Цвет фона";
            this.BtnColorSelect.UseVisualStyleBackColor = false;
            this.BtnColorSelect.Click += new System.EventHandler(this.BtnColorSelect_Click);
            // 
            // iCONselect
            // 
            this.iCONselect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iCONselect.Location = new System.Drawing.Point(26, 114);
            this.iCONselect.Name = "iCONselect";
            this.iCONselect.Size = new System.Drawing.Size(64, 64);
            this.iCONselect.TabIndex = 3;
            this.iCONselect.TabStop = false;
            this.iCONselect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BNETPREVIEWICON_MouseDown);
            // 
            // BtnSelectIcon
            // 
            this.BtnSelectIcon.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnSelectIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSelectIcon.Location = new System.Drawing.Point(26, 184);
            this.BtnSelectIcon.Name = "BtnSelectIcon";
            this.BtnSelectIcon.Size = new System.Drawing.Size(111, 23);
            this.BtnSelectIcon.TabIndex = 2;
            this.BtnSelectIcon.Text = "Выбрать файл";
            this.BtnSelectIcon.UseVisualStyleBackColor = false;
            this.BtnSelectIcon.Click += new System.EventHandler(this.BtnIconSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цвет прозрачности:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(26, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnColorSelectIconTransparent_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(83, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BtnSaveIcon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Усиление прозрачности:";
            // 
            // TransparentPower
            // 
            this.TransparentPower.LargeChange = 1;
            this.TransparentPower.Location = new System.Drawing.Point(26, 279);
            this.TransparentPower.Maximum = 255;
            this.TransparentPower.Name = "TransparentPower";
            this.TransparentPower.Size = new System.Drawing.Size(104, 40);
            this.TransparentPower.TabIndex = 5;
            this.TransparentPower.TickFrequency = 10;
            this.TransparentPower.Value = 1;
            this.TransparentPower.Scroll += new System.EventHandler(this.TransparentPower_Scroll);
            // 
            // PreviewTimer
            // 
            this.PreviewTimer.Enabled = true;
            this.PreviewTimer.Interval = 2000;
            this.PreviewTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // colorpicker
            // 
            this.colorpicker.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colorpicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorpicker.Location = new System.Drawing.Point(154, 67);
            this.colorpicker.Name = "colorpicker";
            this.colorpicker.Size = new System.Drawing.Size(35, 27);
            this.colorpicker.TabIndex = 6;
            this.colorpicker.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(114, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PICK";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ColorPickTimer
            // 
            this.ColorPickTimer.Tick += new System.EventHandler(this.ColorPickTimer_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тип усиления:";
            // 
            // SelectPowerType
            // 
            this.SelectPowerType.FormattingEnabled = true;
            this.SelectPowerType.Items.AddRange(new object[] {
            "Усилить во всех направлениях.",
            "Усилить по возврастающей",
            "Усилить по убывающей"});
            this.SelectPowerType.Location = new System.Drawing.Point(26, 325);
            this.SelectPowerType.Name = "SelectPowerType";
            this.SelectPowerType.Size = new System.Drawing.Size(220, 21);
            this.SelectPowerType.TabIndex = 8;
            this.SelectPowerType.Text = "Усилить во всех направлениях.";
            // 
            // BNETPREVIEWICON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(257, 400);
            this.Controls.Add(this.SelectPowerType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.colorpicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iCONselect);
            this.Controls.Add(this.IconPreview);
            this.Controls.Add(this.BtnSelectIcon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnColorSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransparentPower);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BNETPREVIEWICON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warcraft Icon Preview";
            this.Load += new System.EventHandler(this.BNETPREVIEWICON_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BNETPREVIEWICON_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.IconPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCONselect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransparentPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorpicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox IconPreview;
        private System.Windows.Forms.ColorDialog SelectBackgroundColor;
        private System.Windows.Forms.Button BtnColorSelect;
        private System.Windows.Forms.PictureBox iCONselect;
        private System.Windows.Forms.Button BtnSelectIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar TransparentPower;
        private System.Windows.Forms.Timer PreviewTimer;
        private System.Windows.Forms.PictureBox colorpicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer ColorPickTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SelectPowerType;
    }
}

