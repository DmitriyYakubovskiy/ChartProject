namespace ChartProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FirstQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SecondQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThirdQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FourQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FithQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "это приложения для просмотра и ввода данных для опроса:\r\n";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InputToolStripMenuItem,
            this.OutputToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InputToolStripMenuItem
            // 
            this.InputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SurveyToolStripMenuItem});
            this.InputToolStripMenuItem.Name = "InputToolStripMenuItem";
            this.InputToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.InputToolStripMenuItem.Text = "Ввод";
            // 
            // SurveyToolStripMenuItem
            // 
            this.SurveyToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.SurveyToolStripMenuItem.Name = "SurveyToolStripMenuItem";
            this.SurveyToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.SurveyToolStripMenuItem.Text = "Опрос";
            this.SurveyToolStripMenuItem.Click += new System.EventHandler(this.SurveyToolStripMenuItem_Click);
            // 
            // OutputToolStripMenuItem
            // 
            this.OutputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FirstQuestionToolStripMenuItem,
            this.SecondQuestionToolStripMenuItem,
            this.ThirdQuestionToolStripMenuItem,
            this.FourQuestionToolStripMenuItem,
            this.FithQuestionToolStripMenuItem});
            this.OutputToolStripMenuItem.Name = "OutputToolStripMenuItem";
            this.OutputToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.OutputToolStripMenuItem.Text = "Вывод";
            // 
            // FirstQuestionToolStripMenuItem
            // 
            this.FirstQuestionToolStripMenuItem.Name = "FirstQuestionToolStripMenuItem";
            this.FirstQuestionToolStripMenuItem.Size = new System.Drawing.Size(573, 22);
            this.FirstQuestionToolStripMenuItem.Text = "Негативные эффекты после использования цифровых устройств";
            this.FirstQuestionToolStripMenuItem.Click += new System.EventHandler(this.FirstQuestionToolStripMenuItem_Click);
            // 
            // SecondQuestionToolStripMenuItem
            // 
            this.SecondQuestionToolStripMenuItem.Name = "SecondQuestionToolStripMenuItem";
            this.SecondQuestionToolStripMenuItem.Size = new System.Drawing.Size(573, 22);
            this.SecondQuestionToolStripMenuItem.Text = "Популярное приложение";
            this.SecondQuestionToolStripMenuItem.Click += new System.EventHandler(this.SecondQuestionToolStripMenuItem_Click);
            // 
            // ThirdQuestionToolStripMenuItem
            // 
            this.ThirdQuestionToolStripMenuItem.Name = "ThirdQuestionToolStripMenuItem";
            this.ThirdQuestionToolStripMenuItem.Size = new System.Drawing.Size(573, 22);
            this.ThirdQuestionToolStripMenuItem.Text = "Занятия в свободное время";
            this.ThirdQuestionToolStripMenuItem.Click += new System.EventHandler(this.ThirdQuestionToolStripMenuItem_Click);
            // 
            // FourQuestionToolStripMenuItem
            // 
            this.FourQuestionToolStripMenuItem.Name = "FourQuestionToolStripMenuItem";
            this.FourQuestionToolStripMenuItem.Size = new System.Drawing.Size(573, 22);
            this.FourQuestionToolStripMenuItem.Text = "Среднее количество часов в телефоне";
            this.FourQuestionToolStripMenuItem.Click += new System.EventHandler(this.FourQuestionToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.label2.Location = new System.Drawing.Point(258, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Здравствуйте!!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(91, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(560, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "\"Цифровой минимализм в молодежной среде\"";
            // 
            // FithQuestionToolStripMenuItem
            // 
            this.FithQuestionToolStripMenuItem.Name = "FithQuestionToolStripMenuItem";
            this.FithQuestionToolStripMenuItem.Size = new System.Drawing.Size(573, 22);
            this.FithQuestionToolStripMenuItem.Text = "Вы часто проводите в социальных сетях больше времени, чем планировали изначально?" +
    "";
            this.FithQuestionToolStripMenuItem.Click += new System.EventHandler(this.FithQuestionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 201);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SurveyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FirstQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SecondQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThirdQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FourQuestionToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem FithQuestionToolStripMenuItem;
    }
}

