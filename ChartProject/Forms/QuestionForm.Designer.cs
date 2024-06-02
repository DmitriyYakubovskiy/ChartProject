namespace ChartProject.Forms
{
    partial class QuestionForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AgeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CoreComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(843, 488);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // AgeComboBox
            // 
            this.AgeComboBox.FormattingEnabled = true;
            this.AgeComboBox.Items.AddRange(new object[] {
            "Меньше 18",
            "18 - 21",
            "Больше 21",
            "Без ограничений"});
            this.AgeComboBox.Location = new System.Drawing.Point(861, 48);
            this.AgeComboBox.Name = "AgeComboBox";
            this.AgeComboBox.Size = new System.Drawing.Size(143, 21);
            this.AgeComboBox.TabIndex = 1;
            this.AgeComboBox.SelectedIndexChanged += new System.EventHandler(this.AgesComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(899, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Возраст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(899, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пол:";
            // 
            // SexComboBox
            // 
            this.SexComboBox.BackColor = System.Drawing.Color.White;
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Items.AddRange(new object[] {
            "Мужчина",
            "Женщина",
            "Без ограничений"});
            this.SexComboBox.Location = new System.Drawing.Point(861, 126);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(143, 21);
            this.SexComboBox.TabIndex = 4;
            this.SexComboBox.SelectedIndexChanged += new System.EventHandler(this.SexComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(899, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ядро:";
            // 
            // CoreComboBox
            // 
            this.CoreComboBox.BackColor = System.Drawing.Color.White;
            this.CoreComboBox.FormattingEnabled = true;
            this.CoreComboBox.Items.AddRange(new object[] {
            "Soft",
            "Hard",
            "Без ограничений"});
            this.CoreComboBox.Location = new System.Drawing.Point(861, 210);
            this.CoreComboBox.Name = "CoreComboBox";
            this.CoreComboBox.Size = new System.Drawing.Size(143, 21);
            this.CoreComboBox.TabIndex = 6;
            this.CoreComboBox.SelectedIndexChanged += new System.EventHandler(this.CoreComboBox_SelectedIndexChanged);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 524);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CoreComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SexComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgeComboBox);
            this.Controls.Add(this.chart);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ComboBox AgeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CoreComboBox;
    }
}