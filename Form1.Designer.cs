namespace maoi_5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxOften1 = new System.Windows.Forms.TextBox();
            this.textBoxAmplitude1 = new System.Windows.Forms.TextBox();
            this.textBoxFaza1 = new System.Windows.Forms.TextBox();
            this.textBoxFaza2 = new System.Windows.Forms.TextBox();
            this.textBoxAmplitude2 = new System.Windows.Forms.TextBox();
            this.textBoxOften2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIteration = new System.Windows.Forms.TextBox();
            this.chartOutput = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewOtput = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSend = new System.Windows.Forms.Button();
            this.chartDFT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDFT)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOften1
            // 
            this.textBoxOften1.Location = new System.Drawing.Point(138, 29);
            this.textBoxOften1.Name = "textBoxOften1";
            this.textBoxOften1.Size = new System.Drawing.Size(66, 27);
            this.textBoxOften1.TabIndex = 0;
            this.textBoxOften1.Text = "420";
            // 
            // textBoxAmplitude1
            // 
            this.textBoxAmplitude1.Location = new System.Drawing.Point(138, 62);
            this.textBoxAmplitude1.Name = "textBoxAmplitude1";
            this.textBoxAmplitude1.Size = new System.Drawing.Size(66, 27);
            this.textBoxAmplitude1.TabIndex = 1;
            this.textBoxAmplitude1.Text = "30";
            // 
            // textBoxFaza1
            // 
            this.textBoxFaza1.Location = new System.Drawing.Point(138, 95);
            this.textBoxFaza1.Name = "textBoxFaza1";
            this.textBoxFaza1.Size = new System.Drawing.Size(66, 27);
            this.textBoxFaza1.TabIndex = 2;
            this.textBoxFaza1.Text = "12";
            // 
            // textBoxFaza2
            // 
            this.textBoxFaza2.Location = new System.Drawing.Point(210, 95);
            this.textBoxFaza2.Name = "textBoxFaza2";
            this.textBoxFaza2.Size = new System.Drawing.Size(60, 27);
            this.textBoxFaza2.TabIndex = 5;
            this.textBoxFaza2.Text = "14";
            // 
            // textBoxAmplitude2
            // 
            this.textBoxAmplitude2.Location = new System.Drawing.Point(210, 62);
            this.textBoxAmplitude2.Name = "textBoxAmplitude2";
            this.textBoxAmplitude2.Size = new System.Drawing.Size(60, 27);
            this.textBoxAmplitude2.TabIndex = 4;
            this.textBoxAmplitude2.Text = "40";
            // 
            // textBoxOften2
            // 
            this.textBoxOften2.Location = new System.Drawing.Point(210, 29);
            this.textBoxOften2.Name = "textBoxOften2";
            this.textBoxOften2.Size = new System.Drawing.Size(60, 27);
            this.textBoxOften2.TabIndex = 3;
            this.textBoxOften2.Text = "600";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Частота сигнала:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Амплитуда:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Фаза:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wave 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Wave 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Частота выборки:";
            // 
            // textBoxIteration
            // 
            this.textBoxIteration.Location = new System.Drawing.Point(138, 129);
            this.textBoxIteration.Name = "textBoxIteration";
            this.textBoxIteration.Size = new System.Drawing.Size(132, 27);
            this.textBoxIteration.TabIndex = 12;
            this.textBoxIteration.Text = "20";
            // 
            // chartOutput
            // 
            chartArea1.Name = "ChartArea1";
            this.chartOutput.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartOutput.Legends.Add(legend1);
            this.chartOutput.Location = new System.Drawing.Point(3, 203);
            this.chartOutput.Name = "chartOutput";
            this.chartOutput.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Wave 1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Wave 2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Sinewave";
            this.chartOutput.Series.Add(series1);
            this.chartOutput.Series.Add(series2);
            this.chartOutput.Series.Add(series3);
            this.chartOutput.Size = new System.Drawing.Size(487, 369);
            this.chartOutput.TabIndex = 13;
            this.chartOutput.Text = "chart1";
            // 
            // dataGridViewOtput
            // 
            this.dataGridViewOtput.AllowUserToAddRows = false;
            this.dataGridViewOtput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOtput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.dataGridViewOtput.Location = new System.Drawing.Point(276, 10);
            this.dataGridViewOtput.Name = "dataGridViewOtput";
            this.dataGridViewOtput.Size = new System.Drawing.Size(707, 187);
            this.dataGridViewOtput.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Wave 1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Wave 2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sinewave";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DFT";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Goertzel";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "OptiGoertzel";
            this.Column5.Name = "Column5";
            // 
            // buttonSend
            // 
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Location = new System.Drawing.Point(138, 162);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(132, 32);
            this.buttonSend.TabIndex = 15;
            this.buttonSend.Text = "Обработать";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // chartDFT
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDFT.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDFT.Legends.Add(legend2);
            this.chartDFT.Location = new System.Drawing.Point(496, 203);
            this.chartDFT.Name = "chartDFT";
            this.chartDFT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "DFT";
            this.chartDFT.Series.Add(series4);
            this.chartDFT.Size = new System.Drawing.Size(487, 369);
            this.chartDFT.TabIndex = 16;
            this.chartDFT.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 584);
            this.Controls.Add(this.chartDFT);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.dataGridViewOtput);
            this.Controls.Add(this.chartOutput);
            this.Controls.Add(this.textBoxIteration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFaza2);
            this.Controls.Add(this.textBoxAmplitude2);
            this.Controls.Add(this.textBoxOften2);
            this.Controls.Add(this.textBoxFaza1);
            this.Controls.Add(this.textBoxAmplitude1);
            this.Controls.Add(this.textBoxOften1);
            this.Font = new System.Drawing.Font("Proxima Nova Cn Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "Л/Р 7";
            ((System.ComponentModel.ISupportInitialize)(this.chartOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOtput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDFT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOften1;
        private System.Windows.Forms.TextBox textBoxAmplitude1;
        private System.Windows.Forms.TextBox textBoxFaza1;
        private System.Windows.Forms.TextBox textBoxFaza2;
        private System.Windows.Forms.TextBox textBoxAmplitude2;
        private System.Windows.Forms.TextBox textBoxOften2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIteration;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutput;
        private System.Windows.Forms.DataGridView dataGridViewOtput;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDFT;
    }
}

