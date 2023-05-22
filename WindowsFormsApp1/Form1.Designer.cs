
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.Move = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.substratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radiationAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.x10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.математическаяМодельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эволюционнаяМодельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картаПоверхностейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видоваяКартаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фотосинтезирующиеКлеткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.освещенностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Move
            // 
            this.Move.Interval = 1000;
            this.Move.Tick += new System.EventHandler(this.Move_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.graphicsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.typeToolStripMenuItem,
            this.картаПоверхностейToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulateToolStripMenuItem,
            this.substratToolStripMenuItem,
            this.defaultSizeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.settingsToolStripMenuItem.Text = "Настройки\\Начать";
            // 
            // simulateToolStripMenuItem
            // 
            this.simulateToolStripMenuItem.Name = "simulateToolStripMenuItem";
            this.simulateToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.simulateToolStripMenuItem.Text = "Начать";
            this.simulateToolStripMenuItem.Click += new System.EventHandler(this.simulateToolStripMenuItem_Click);
            // 
            // substratToolStripMenuItem
            // 
            this.substratToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightAmountToolStripMenuItem,
            this.radiationAmountToolStripMenuItem});
            this.substratToolStripMenuItem.Name = "substratToolStripMenuItem";
            this.substratToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.substratToolStripMenuItem.Text = "Мировые параметры";
            // 
            // lightAmountToolStripMenuItem
            // 
            this.lightAmountToolStripMenuItem.Name = "lightAmountToolStripMenuItem";
            this.lightAmountToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.lightAmountToolStripMenuItem.Text = "Освещенность субстрата";
            this.lightAmountToolStripMenuItem.Click += new System.EventHandler(this.lightAmountToolStripMenuItem_Click);
            // 
            // radiationAmountToolStripMenuItem
            // 
            this.radiationAmountToolStripMenuItem.Name = "radiationAmountToolStripMenuItem";
            this.radiationAmountToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.radiationAmountToolStripMenuItem.Text = "Радиация";
            this.radiationAmountToolStripMenuItem.Click += new System.EventHandler(this.radiationAmountToolStripMenuItem_Click);
            // 
            // defaultSizeToolStripMenuItem
            // 
            this.defaultSizeToolStripMenuItem.Name = "defaultSizeToolStripMenuItem";
            this.defaultSizeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.defaultSizeToolStripMenuItem.Text = "SIZEFIX(dev)";
            this.defaultSizeToolStripMenuItem.Click += new System.EventHandler(this.defaultSizeToolStripMenuItem_Click);
            // 
            // graphicsToolStripMenuItem
            // 
            this.graphicsToolStripMenuItem.Name = "graphicsToolStripMenuItem";
            this.graphicsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.graphicsToolStripMenuItem.Text = "Статистика";
            this.graphicsToolStripMenuItem.Click += new System.EventHandler(this.graphicsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.x10ToolStripMenuItem,
            this.x1ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 20);
            this.toolStripMenuItem1.Text = "Скорость модели";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.stopToolStripMenuItem.Text = "Остановить";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem3.Text = "0,1x Минимум";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem4.Text = "0,5x ";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem5.Text = "1x Стандарт";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // x10ToolStripMenuItem
            // 
            this.x10ToolStripMenuItem.Name = "x10ToolStripMenuItem";
            this.x10ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.x10ToolStripMenuItem.Text = "10x ";
            this.x10ToolStripMenuItem.Click += new System.EventHandler(this.x10ToolStripMenuItem_Click);
            // 
            // x1ToolStripMenuItem
            // 
            this.x1ToolStripMenuItem.Name = "x1ToolStripMenuItem";
            this.x1ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.x1ToolStripMenuItem.Text = "100x Максимум";
            this.x1ToolStripMenuItem.Click += new System.EventHandler(this.x1ToolStripMenuItem_Click);
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.математическаяМодельToolStripMenuItem,
            this.эволюционнаяМодельToolStripMenuItem});
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(235, 20);
            this.typeToolStripMenuItem.Text = "Тип симуляции (Требуется перезапуск)";
            // 
            // математическаяМодельToolStripMenuItem
            // 
            this.математическаяМодельToolStripMenuItem.Name = "математическаяМодельToolStripMenuItem";
            this.математическаяМодельToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.математическаяМодельToolStripMenuItem.Text = "Математическая модель";
            // 
            // эволюционнаяМодельToolStripMenuItem
            // 
            this.эволюционнаяМодельToolStripMenuItem.Name = "эволюционнаяМодельToolStripMenuItem";
            this.эволюционнаяМодельToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.эволюционнаяМодельToolStripMenuItem.Text = "Эволюционная модель";
            this.эволюционнаяМодельToolStripMenuItem.Click += new System.EventHandler(this.эволюционнаяМодельToolStripMenuItem_Click);
            // 
            // картаПоверхностейToolStripMenuItem
            // 
            this.картаПоверхностейToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видоваяКартаToolStripMenuItem,
            this.фотосинтезирующиеКлеткиToolStripMenuItem,
            this.освещенностьToolStripMenuItem});
            this.картаПоверхностейToolStripMenuItem.Name = "картаПоверхностейToolStripMenuItem";
            this.картаПоверхностейToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.картаПоверхностейToolStripMenuItem.Text = "Карта поверхностей";
            // 
            // видоваяКартаToolStripMenuItem
            // 
            this.видоваяКартаToolStripMenuItem.Name = "видоваяКартаToolStripMenuItem";
            this.видоваяКартаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.видоваяКартаToolStripMenuItem.Text = "Видовая карта";
            this.видоваяКартаToolStripMenuItem.Click += new System.EventHandler(this.видоваяКартаToolStripMenuItem_Click);
            // 
            // фотосинтезирующиеКлеткиToolStripMenuItem
            // 
            this.фотосинтезирующиеКлеткиToolStripMenuItem.Name = "фотосинтезирующиеКлеткиToolStripMenuItem";
            this.фотосинтезирующиеКлеткиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.фотосинтезирующиеКлеткиToolStripMenuItem.Text = "Тип энергообмена";
            this.фотосинтезирующиеКлеткиToolStripMenuItem.Click += new System.EventHandler(this.фотосинтезирующиеКлеткиToolStripMenuItem_Click);
            // 
            // освещенностьToolStripMenuItem
            // 
            this.освещенностьToolStripMenuItem.Name = "освещенностьToolStripMenuItem";
            this.освещенностьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.освещенностьToolStripMenuItem.Text = "Освещенность";
            this.освещенностьToolStripMenuItem.Click += new System.EventHandler(this.освещенностьToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(540, 19);
            this.textBox1.TabIndex = 3;
            this.textBox1.Tag = "0";
            this.textBox1.Text = "timer";
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(12, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 19);
            this.textBox2.TabIndex = 4;
            this.textBox2.Tag = "0";
            this.textBox2.Text = "Herbivourous count";
            this.textBox2.Visible = false;
            // 
            // Clock
            // 
            this.Clock.Enabled = true;
            this.Clock.Interval = 1;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(12, 77);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(245, 19);
            this.textBox4.TabIndex = 6;
            this.textBox4.Tag = "0";
            this.textBox4.Text = "Plants count";
            this.textBox4.Visible = false;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1904, 1017);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "1";
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1904, 1017);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(0, 24);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(1904, 1017);
            this.textBox8.TabIndex = 12;
            this.textBox8.Text = "\r\n";
            this.textBox8.Visible = false;
            this.textBox8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox8_KeyDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(0, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1904, 1017);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Toolkit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Move;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem x10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulateToolStripMenuItem;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.ToolStripMenuItem defaultSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem substratToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ToolStripMenuItem lightAmountToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ToolStripMenuItem radiationAmountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem математическаяМодельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эволюционнаяМодельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картаПоверхностейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видоваяКартаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фотосинтезирующиеКлеткиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem освещенностьToolStripMenuItem;
    }
}

