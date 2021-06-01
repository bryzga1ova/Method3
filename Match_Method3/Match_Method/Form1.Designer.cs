namespace Match_Method
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
            this.SaveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.userChoice = new System.Windows.Forms.ComboBox();
            this.goingQuest = new System.Windows.Forms.Button();
            this.countVarText = new System.Windows.Forms.Label();
            this.countNum = new System.Windows.Forms.NumericUpDown();
            this.intervalText = new System.Windows.Forms.Label();
            this.intervalNum = new System.Windows.Forms.NumericUpDown();
            this.AnswerQuest = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.PickGraf = new System.Windows.Forms.Button();
            this.LinesNoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowGraficLines = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HarmNoice = new System.Windows.Forms.ComboBox();
            this.PasleNoice = new System.Windows.Forms.ComboBox();
            this.ShowGraficHarm = new System.Windows.Forms.Button();
            this.ShowGraficPulse = new System.Windows.Forms.Button();
            this.Dupl_rat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNum)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveBtn,
            this.LoadBtn});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(166, 26);
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(166, 26);
            this.LoadBtn.Text = "Загрузить";
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(67, 24);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // userChoice
            // 
            this.userChoice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.userChoice.Cursor = System.Windows.Forms.Cursors.Default;
            this.userChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userChoice.ForeColor = System.Drawing.Color.Black;
            this.userChoice.FormattingEnabled = true;
            this.userChoice.Items.AddRange(new object[] {
            "Скользящее среднее",
            "Скользящее взвешенное среднее",
            "Экспоненциальное скользящее среднее",
            "Линейно-взвешенное скользяще среднее",
            "Сглaжeннaя cкoльзящaя cpeдняя"});
            this.userChoice.Location = new System.Drawing.Point(12, 31);
            this.userChoice.Name = "userChoice";
            this.userChoice.Size = new System.Drawing.Size(776, 33);
            this.userChoice.TabIndex = 1;
            // 
            // goingQuest
            // 
            this.goingQuest.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.goingQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goingQuest.Location = new System.Drawing.Point(409, 100);
            this.goingQuest.Name = "goingQuest";
            this.goingQuest.Size = new System.Drawing.Size(378, 33);
            this.goingQuest.TabIndex = 2;
            this.goingQuest.Text = "Выполнить";
            this.goingQuest.UseVisualStyleBackColor = true;
            this.goingQuest.Click += new System.EventHandler(this.goingQuest_Click);
            // 
            // countVarText
            // 
            this.countVarText.AutoSize = true;
            this.countVarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countVarText.Location = new System.Drawing.Point(12, 73);
            this.countVarText.Name = "countVarText";
            this.countVarText.Size = new System.Drawing.Size(204, 25);
            this.countVarText.TabIndex = 3;
            this.countVarText.Text = "Кол-во переменных:";
            // 
            // countNum
            // 
            this.countNum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.countNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countNum.Location = new System.Drawing.Point(253, 70);
            this.countNum.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.countNum.Name = "countNum";
            this.countNum.Size = new System.Drawing.Size(137, 28);
            this.countNum.TabIndex = 4;
            // 
            // intervalText
            // 
            this.intervalText.AutoSize = true;
            this.intervalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intervalText.Location = new System.Drawing.Point(12, 101);
            this.intervalText.Name = "intervalText";
            this.intervalText.Size = new System.Drawing.Size(235, 25);
            this.intervalText.TabIndex = 5;
            this.intervalText.Text = "Интервал сглаживания:";
            // 
            // intervalNum
            // 
            this.intervalNum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.intervalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intervalNum.Location = new System.Drawing.Point(253, 104);
            this.intervalNum.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.intervalNum.Name = "intervalNum";
            this.intervalNum.Size = new System.Drawing.Size(137, 28);
            this.intervalNum.TabIndex = 6;
            // 
            // AnswerQuest
            // 
            this.AnswerQuest.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AnswerQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerQuest.FormattingEnabled = true;
            this.AnswerQuest.ItemHeight = 25;
            this.AnswerQuest.Location = new System.Drawing.Point(12, 290);
            this.AnswerQuest.Name = "AnswerQuest";
            this.AnswerQuest.Size = new System.Drawing.Size(775, 154);
            this.AnswerQuest.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddBtn
            // 
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.Location = new System.Drawing.Point(12, 138);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(177, 33);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBtn.Location = new System.Drawing.Point(213, 138);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(177, 33);
            this.ClearBtn.TabIndex = 9;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // PickGraf
            // 
            this.PickGraf.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PickGraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PickGraf.Location = new System.Drawing.Point(409, 138);
            this.PickGraf.Name = "PickGraf";
            this.PickGraf.Size = new System.Drawing.Size(378, 33);
            this.PickGraf.TabIndex = 10;
            this.PickGraf.Text = "Нарисовать график";
            this.PickGraf.UseVisualStyleBackColor = true;
            this.PickGraf.Click += new System.EventHandler(this.PickGraf_Click);
            // 
            // LinesNoice
            // 
            this.LinesNoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinesNoice.FormattingEnabled = true;
            this.LinesNoice.Items.AddRange(new object[] {
            "Без шумов",
            "С малыми шумами",
            "С большими шумами"});
            this.LinesNoice.Location = new System.Drawing.Point(159, 180);
            this.LinesNoice.Name = "LinesNoice";
            this.LinesNoice.Size = new System.Drawing.Size(177, 30);
            this.LinesNoice.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Линейная";
            // 
            // ShowGraficLines
            // 
            this.ShowGraficLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowGraficLines.Location = new System.Drawing.Point(342, 180);
            this.ShowGraficLines.Name = "ShowGraficLines";
            this.ShowGraficLines.Size = new System.Drawing.Size(180, 30);
            this.ShowGraficLines.TabIndex = 13;
            this.ShowGraficLines.Text = "Перевести";
            this.ShowGraficLines.UseVisualStyleBackColor = true;
            this.ShowGraficLines.Click += new System.EventHandler(this.ShowGraficLines_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Гармоничная";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Импульсная";
            // 
            // HarmNoice
            // 
            this.HarmNoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HarmNoice.FormattingEnabled = true;
            this.HarmNoice.Items.AddRange(new object[] {
            "Без шумов",
            "С малыми шумами",
            "С большими шумами"});
            this.HarmNoice.Location = new System.Drawing.Point(159, 215);
            this.HarmNoice.Name = "HarmNoice";
            this.HarmNoice.Size = new System.Drawing.Size(177, 30);
            this.HarmNoice.TabIndex = 16;
            // 
            // PasleNoice
            // 
            this.PasleNoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasleNoice.FormattingEnabled = true;
            this.PasleNoice.Items.AddRange(new object[] {
            "Без шумов",
            "С малыми шумами",
            "С большими шумами"});
            this.PasleNoice.Location = new System.Drawing.Point(159, 251);
            this.PasleNoice.Name = "PasleNoice";
            this.PasleNoice.Size = new System.Drawing.Size(177, 30);
            this.PasleNoice.TabIndex = 17;
            // 
            // ShowGraficHarm
            // 
            this.ShowGraficHarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowGraficHarm.Location = new System.Drawing.Point(342, 216);
            this.ShowGraficHarm.Name = "ShowGraficHarm";
            this.ShowGraficHarm.Size = new System.Drawing.Size(180, 30);
            this.ShowGraficHarm.TabIndex = 18;
            this.ShowGraficHarm.Text = "Перевести";
            this.ShowGraficHarm.UseVisualStyleBackColor = true;
            this.ShowGraficHarm.Click += new System.EventHandler(this.ShowGraficHarm_Click);
            // 
            // ShowGraficPulse
            // 
            this.ShowGraficPulse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowGraficPulse.Location = new System.Drawing.Point(342, 250);
            this.ShowGraficPulse.Name = "ShowGraficPulse";
            this.ShowGraficPulse.Size = new System.Drawing.Size(180, 30);
            this.ShowGraficPulse.TabIndex = 19;
            this.ShowGraficPulse.Text = "Перевести";
            this.ShowGraficPulse.UseVisualStyleBackColor = true;
            this.ShowGraficPulse.Click += new System.EventHandler(this.ShowGraficPulse_Click);
            // 
            // Dupl_rat
            // 
            this.Dupl_rat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Dupl_rat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dupl_rat.Location = new System.Drawing.Point(528, 215);
            this.Dupl_rat.Name = "Dupl_rat";
            this.Dupl_rat.Size = new System.Drawing.Size(260, 33);
            this.Dupl_rat.TabIndex = 20;
            this.Dupl_rat.Text = "Размножение оценок";
            this.Dupl_rat.UseVisualStyleBackColor = true;
            this.Dupl_rat.Click += new System.EventHandler(this.Dupl_rat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dupl_rat);
            this.Controls.Add(this.ShowGraficPulse);
            this.Controls.Add(this.ShowGraficHarm);
            this.Controls.Add(this.PasleNoice);
            this.Controls.Add(this.HarmNoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowGraficLines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LinesNoice);
            this.Controls.Add(this.PickGraf);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AnswerQuest);
            this.Controls.Add(this.intervalNum);
            this.Controls.Add(this.intervalText);
            this.Controls.Add(this.countNum);
            this.Controls.Add(this.countVarText);
            this.Controls.Add(this.goingQuest);
            this.Controls.Add(this.userChoice);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Главное окно";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ComboBox userChoice;
        private System.Windows.Forms.Button goingQuest;
        private System.Windows.Forms.Label countVarText;
        private System.Windows.Forms.NumericUpDown countNum;
        private System.Windows.Forms.Label intervalText;
        private System.Windows.Forms.NumericUpDown intervalNum;
        private System.Windows.Forms.ListBox AnswerQuest;
        private System.Windows.Forms.ToolStripMenuItem SaveBtn;
        private System.Windows.Forms.ToolStripMenuItem LoadBtn;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button PickGraf;
        private System.Windows.Forms.ComboBox LinesNoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowGraficLines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox HarmNoice;
        private System.Windows.Forms.ComboBox PasleNoice;
        private System.Windows.Forms.Button ShowGraficHarm;
        private System.Windows.Forms.Button ShowGraficPulse;
        private System.Windows.Forms.Button Dupl_rat;
    }
}

