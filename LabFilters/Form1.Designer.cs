namespace LabFilters
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
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чёрнобелоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрГауссаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрСобеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тиснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сдвигToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.влевоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.направоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЧасовойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.противЧасовойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поГоризонталиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВертикалиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.эффектСтеклаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сФРезкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдГраницЩарраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдГраницПрюиттаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменаДействияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.отменаДействияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1111, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.чёрнобелоеToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.яркостьToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // чёрнобелоеToolStripMenuItem
            // 
            this.чёрнобелоеToolStripMenuItem.Name = "чёрнобелоеToolStripMenuItem";
            this.чёрнобелоеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.чёрнобелоеToolStripMenuItem.Text = "Чёрно-белое";
            this.чёрнобелоеToolStripMenuItem.Click += new System.EventHandler(this.чёрнобелоеToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // яркостьToolStripMenuItem
            // 
            this.яркостьToolStripMenuItem.Name = "яркостьToolStripMenuItem";
            this.яркостьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.яркостьToolStripMenuItem.Text = "Яркость++";
            this.яркостьToolStripMenuItem.Click += new System.EventHandler(this.яркостьToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.фильтрГауссаToolStripMenuItem,
            this.фильтрСобеляToolStripMenuItem,
            this.резкостьToolStripMenuItem,
            this.тиснениеToolStripMenuItem,
            this.медианныйФильтрToolStripMenuItem,
            this.сдвигToolStripMenuItem,
            this.поворотToolStripMenuItem,
            this.волныToolStripMenuItem,
            this.эффектСтеклаToolStripMenuItem,
            this.motionBlurToolStripMenuItem,
            this.сФРезкостьToolStripMenuItem,
            this.выдГраницЩарраToolStripMenuItem,
            this.выдГраницПрюиттаToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // фильтрГауссаToolStripMenuItem
            // 
            this.фильтрГауссаToolStripMenuItem.Name = "фильтрГауссаToolStripMenuItem";
            this.фильтрГауссаToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.фильтрГауссаToolStripMenuItem.Text = "Фильтр Гаусса";
            this.фильтрГауссаToolStripMenuItem.Click += new System.EventHandler(this.фильтрГауссаToolStripMenuItem_Click);
            // 
            // фильтрСобеляToolStripMenuItem
            // 
            this.фильтрСобеляToolStripMenuItem.Name = "фильтрСобеляToolStripMenuItem";
            this.фильтрСобеляToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.фильтрСобеляToolStripMenuItem.Text = "Фильтр Собеля";
            this.фильтрСобеляToolStripMenuItem.Click += new System.EventHandler(this.фильтрСобеляToolStripMenuItem_Click);
            // 
            // резкостьToolStripMenuItem
            // 
            this.резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            this.резкостьToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.резкостьToolStripMenuItem.Text = "Резкость++";
            this.резкостьToolStripMenuItem.Click += new System.EventHandler(this.резкостьToolStripMenuItem_Click);
            // 
            // тиснениеToolStripMenuItem
            // 
            this.тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            this.тиснениеToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.тиснениеToolStripMenuItem.Text = "Тиснение";
            this.тиснениеToolStripMenuItem.Click += new System.EventHandler(this.тиснениеToolStripMenuItem_Click);
            // 
            // медианныйФильтрToolStripMenuItem
            // 
            this.медианныйФильтрToolStripMenuItem.Name = "медианныйФильтрToolStripMenuItem";
            this.медианныйФильтрToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.медианныйФильтрToolStripMenuItem.Text = "Медианный фильтр";
            this.медианныйФильтрToolStripMenuItem.Click += new System.EventHandler(this.медианныйФильтрToolStripMenuItem_Click);
            // 
            // сдвигToolStripMenuItem
            // 
            this.сдвигToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.влевоToolStripMenuItem,
            this.направоToolStripMenuItem});
            this.сдвигToolStripMenuItem.Name = "сдвигToolStripMenuItem";
            this.сдвигToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.сдвигToolStripMenuItem.Text = "Сдвиг";
            // 
            // влевоToolStripMenuItem
            // 
            this.влевоToolStripMenuItem.Name = "влевоToolStripMenuItem";
            this.влевоToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.влевоToolStripMenuItem.Text = "Влево";
            this.влевоToolStripMenuItem.Click += new System.EventHandler(this.влевоToolStripMenuItem_Click);
            // 
            // направоToolStripMenuItem
            // 
            this.направоToolStripMenuItem.Name = "направоToolStripMenuItem";
            this.направоToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.направоToolStripMenuItem.Text = "Вправо";
            this.направоToolStripMenuItem.Click += new System.EventHandler(this.направоToolStripMenuItem_Click);
            // 
            // поворотToolStripMenuItem
            // 
            this.поворотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поЧасовойToolStripMenuItem,
            this.противЧасовойToolStripMenuItem});
            this.поворотToolStripMenuItem.Name = "поворотToolStripMenuItem";
            this.поворотToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.поворотToolStripMenuItem.Text = "Поворот";
            // 
            // поЧасовойToolStripMenuItem
            // 
            this.поЧасовойToolStripMenuItem.Name = "поЧасовойToolStripMenuItem";
            this.поЧасовойToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.поЧасовойToolStripMenuItem.Text = "По часовой";
            this.поЧасовойToolStripMenuItem.Click += new System.EventHandler(this.поЧасовойToolStripMenuItem_Click);
            // 
            // противЧасовойToolStripMenuItem
            // 
            this.противЧасовойToolStripMenuItem.Name = "противЧасовойToolStripMenuItem";
            this.противЧасовойToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.противЧасовойToolStripMenuItem.Text = "Против часовой";
            this.противЧасовойToolStripMenuItem.Click += new System.EventHandler(this.противЧасовойToolStripMenuItem_Click);
            // 
            // волныToolStripMenuItem
            // 
            this.волныToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поГоризонталиToolStripMenuItem,
            this.поВертикалиToolStripMenuItem});
            this.волныToolStripMenuItem.Name = "волныToolStripMenuItem";
            this.волныToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.волныToolStripMenuItem.Text = "Волны";
            // 
            // поГоризонталиToolStripMenuItem
            // 
            this.поГоризонталиToolStripMenuItem.Name = "поГоризонталиToolStripMenuItem";
            this.поГоризонталиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.поГоризонталиToolStripMenuItem.Text = "По горизонтали";
            this.поГоризонталиToolStripMenuItem.Click += new System.EventHandler(this.поГоризонталиToolStripMenuItem_Click);
            // 
            // поВертикалиToolStripMenuItem
            // 
            this.поВертикалиToolStripMenuItem.Name = "поВертикалиToolStripMenuItem";
            this.поВертикалиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.поВертикалиToolStripMenuItem.Text = "По вертикали";
            this.поВертикалиToolStripMenuItem.Click += new System.EventHandler(this.поВертикалиToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1111, 546);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 579);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(876, 56);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(894, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // эффектСтеклаToolStripMenuItem
            // 
            this.эффектСтеклаToolStripMenuItem.Name = "эффектСтеклаToolStripMenuItem";
            this.эффектСтеклаToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.эффектСтеклаToolStripMenuItem.Text = "Эффект стекла";
            this.эффектСтеклаToolStripMenuItem.Click += new System.EventHandler(this.эффектСтеклаToolStripMenuItem_Click);
            // 
            // motionBlurToolStripMenuItem
            // 
            this.motionBlurToolStripMenuItem.Name = "motionBlurToolStripMenuItem";
            this.motionBlurToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.motionBlurToolStripMenuItem.Text = "Motion Blur";
            this.motionBlurToolStripMenuItem.Click += new System.EventHandler(this.motionBlurToolStripMenuItem_Click);
            // 
            // сФРезкостьToolStripMenuItem
            // 
            this.сФРезкостьToolStripMenuItem.Name = "сФРезкостьToolStripMenuItem";
            this.сФРезкостьToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.сФРезкостьToolStripMenuItem.Text = "СФ резкость ";
            this.сФРезкостьToolStripMenuItem.Click += new System.EventHandler(this.сФРезкостьToolStripMenuItem_Click);
            // 
            // выдГраницЩарраToolStripMenuItem
            // 
            this.выдГраницЩарраToolStripMenuItem.Name = "выдГраницЩарраToolStripMenuItem";
            this.выдГраницЩарраToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.выдГраницЩарраToolStripMenuItem.Text = "Выд. границ Щарра";
            this.выдГраницЩарраToolStripMenuItem.Click += new System.EventHandler(this.выдГраницЩарраToolStripMenuItem_Click);
            // 
            // выдГраницПрюиттаToolStripMenuItem
            // 
            this.выдГраницПрюиттаToolStripMenuItem.Name = "выдГраницПрюиттаToolStripMenuItem";
            this.выдГраницПрюиттаToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.выдГраницПрюиттаToolStripMenuItem.Text = "Выд. границ Прюитта";
            this.выдГраницПрюиттаToolStripMenuItem.Click += new System.EventHandler(this.выдГраницПрюиттаToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить ";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // отменаДействияToolStripMenuItem
            // 
            this.отменаДействияToolStripMenuItem.Name = "отменаДействияToolStripMenuItem";
            this.отменаДействияToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.отменаДействияToolStripMenuItem.Text = "Отмена действия";
            this.отменаДействияToolStripMenuItem.Click += new System.EventHandler(this.отменаДействияToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 647);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрГауссаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чёрнобелоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яркостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрСобеляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тиснениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медианныйФильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сдвигToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem влевоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem направоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поворотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЧасовойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem противЧасовойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поГоризонталиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВертикалиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффектСтеклаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motionBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сФРезкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выдГраницЩарраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выдГраницПрюиттаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменаДействияToolStripMenuItem;
    }
}

