namespace Laba23_GraficPaint
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квадратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кругToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поллинияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.карандашToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветЗаливкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зеркальноОтобразитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотНа90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.рисоватьToolStripMenuItem,
            this.цветToolStripMenuItem,
            this.цветЗаливкиToolStripMenuItem,
            this.копироватьToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(156, 639);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.закрытьВсеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.сохранитьToolStripMenuItem.Text = "Закрыть";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // закрытьВсеToolStripMenuItem
            // 
            this.закрытьВсеToolStripMenuItem.Name = "закрытьВсеToolStripMenuItem";
            this.закрытьВсеToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.закрытьВсеToolStripMenuItem.Text = "Закрыть все";
            this.закрытьВсеToolStripMenuItem.Click += new System.EventHandler(this.закрытьВсеToolStripMenuItem_Click);
            // 
            // рисоватьToolStripMenuItem
            // 
            this.рисоватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.квадратToolStripMenuItem,
            this.линияToolStripMenuItem,
            this.кругToolStripMenuItem,
            this.поллинияToolStripMenuItem,
            this.текстToolStripMenuItem});
            this.рисоватьToolStripMenuItem.Name = "рисоватьToolStripMenuItem";
            this.рисоватьToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.рисоватьToolStripMenuItem.Text = "Рисовать";
            // 
            // квадратToolStripMenuItem
            // 
            this.квадратToolStripMenuItem.Name = "квадратToolStripMenuItem";
            this.квадратToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.квадратToolStripMenuItem.Text = "Квадрат";
            this.квадратToolStripMenuItem.Click += new System.EventHandler(this.квадратToolStripMenuItem_Click);
            // 
            // линияToolStripMenuItem
            // 
            this.линияToolStripMenuItem.Name = "линияToolStripMenuItem";
            this.линияToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.линияToolStripMenuItem.Text = "Линия";
            this.линияToolStripMenuItem.Click += new System.EventHandler(this.линияToolStripMenuItem_Click);
            // 
            // кругToolStripMenuItem
            // 
            this.кругToolStripMenuItem.Name = "кругToolStripMenuItem";
            this.кругToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.кругToolStripMenuItem.Text = "Круг";
            this.кругToolStripMenuItem.Click += new System.EventHandler(this.кругToolStripMenuItem_Click);
            // 
            // поллинияToolStripMenuItem
            // 
            this.поллинияToolStripMenuItem.Name = "поллинияToolStripMenuItem";
            this.поллинияToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.поллинияToolStripMenuItem.Text = "поллиния";
            this.поллинияToolStripMenuItem.Click += new System.EventHandler(this.поллинияToolStripMenuItem_Click);
            // 
            // текстToolStripMenuItem
            // 
            this.текстToolStripMenuItem.Name = "текстToolStripMenuItem";
            this.текстToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.текстToolStripMenuItem.Text = "текст";
            this.текстToolStripMenuItem.Click += new System.EventHandler(this.текстToolStripMenuItem_Click);
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.карандашToolStripMenuItem});
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.цветToolStripMenuItem.Text = "Цвет";
            // 
            // карандашToolStripMenuItem
            // 
            this.карандашToolStripMenuItem.Name = "карандашToolStripMenuItem";
            this.карандашToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.карандашToolStripMenuItem.Text = "Карандаш";
            this.карандашToolStripMenuItem.Click += new System.EventHandler(this.карандашToolStripMenuItem_Click);
            // 
            // цветЗаливкиToolStripMenuItem
            // 
            this.цветЗаливкиToolStripMenuItem.Name = "цветЗаливкиToolStripMenuItem";
            this.цветЗаливкиToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.цветЗаливкиToolStripMenuItem.Text = "Цвет заливки";
            this.цветЗаливкиToolStripMenuItem.Click += new System.EventHandler(this.цветЗаливкиToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem1,
            this.зеркальноОтобразитьToolStripMenuItem,
            this.поворотНа90ToolStripMenuItem});
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.копироватьToolStripMenuItem.Text = "инструменты";
            // 
            // копироватьToolStripMenuItem1
            // 
            this.копироватьToolStripMenuItem1.Name = "копироватьToolStripMenuItem1";
            this.копироватьToolStripMenuItem1.Size = new System.Drawing.Size(249, 26);
            this.копироватьToolStripMenuItem1.Text = "копировать";
            this.копироватьToolStripMenuItem1.Click += new System.EventHandler(this.копироватьToolStripMenuItem1_Click);
            // 
            // зеркальноОтобразитьToolStripMenuItem
            // 
            this.зеркальноОтобразитьToolStripMenuItem.Name = "зеркальноОтобразитьToolStripMenuItem";
            this.зеркальноОтобразитьToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.зеркальноОтобразитьToolStripMenuItem.Text = "зеркально отобразить";
            this.зеркальноОтобразитьToolStripMenuItem.Click += new System.EventHandler(this.зеркальноОтобразитьToolStripMenuItem_Click);
            // 
            // поворотНа90ToolStripMenuItem
            // 
            this.поворотНа90ToolStripMenuItem.Name = "поворотНа90ToolStripMenuItem";
            this.поворотНа90ToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.поворотНа90ToolStripMenuItem.Text = "поворот на 25";
            this.поворотНа90ToolStripMenuItem.Click += new System.EventHandler(this.поворотНа90ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "стоп";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.закрытьВсеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1162, 639);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Photoshop 2020";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квадратToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кругToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem карандашToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поллинияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветЗаливкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem зеркальноОтобразитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поворотНа90ToolStripMenuItem;
    }
}

