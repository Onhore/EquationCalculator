namespace Equ
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint34 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(-5D, 25D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint35 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(-4D, 16D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint36 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(-3D, 9D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint37 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(-2D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint38 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(-1D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint39 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint40 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint41 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint42 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 9D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint43 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 16D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint44 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 25D);
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.labelStep = new System.Windows.Forms.Label();
            this.buttonEnterCalculate = new System.Windows.Forms.Button();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.labelInputC = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelInputB = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelInputA = new System.Windows.Forms.Label();
            this.labelInputHead = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.extra = new System.Windows.Forms.Label();
            this.labelExtraHead = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.answer = new System.Windows.Forms.Label();
            this.labelAnswerHead = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxRadiusSize = new System.Windows.Forms.TextBox();
            this.labelRadiusSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graph.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.graph.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            this.graph.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea4);
            this.graph.Location = new System.Drawing.Point(94, 3);
            this.graph.Name = "graph";
            this.graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.LabelBorderWidth = 5;
            series4.MarkerSize = 1;
            series4.Name = "Series1";
            series4.Points.Add(dataPoint34);
            series4.Points.Add(dataPoint35);
            series4.Points.Add(dataPoint36);
            series4.Points.Add(dataPoint37);
            series4.Points.Add(dataPoint38);
            series4.Points.Add(dataPoint39);
            series4.Points.Add(dataPoint40);
            series4.Points.Add(dataPoint41);
            series4.Points.Add(dataPoint42);
            series4.Points.Add(dataPoint43);
            series4.Points.Add(dataPoint44);
            this.graph.Series.Add(series4);
            this.graph.Size = new System.Drawing.Size(899, 379);
            this.graph.TabIndex = 0;
            this.graph.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.Name = "Title";
            title4.Text = "График квадратичной функции";
            this.graph.Titles.Add(title4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxRadiusSize);
            this.panel1.Controls.Add(this.labelRadiusSize);
            this.panel1.Controls.Add(this.buttonEnterCalculate);
            this.panel1.Controls.Add(this.textBoxStep);
            this.panel1.Controls.Add(this.textBoxC);
            this.panel1.Controls.Add(this.labelStep);
            this.panel1.Controls.Add(this.labelInputC);
            this.panel1.Controls.Add(this.textBoxB);
            this.panel1.Controls.Add(this.labelInputB);
            this.panel1.Controls.Add(this.textBoxA);
            this.panel1.Controls.Add(this.labelInputA);
            this.panel1.Controls.Add(this.labelInputHead);
            this.panel1.Location = new System.Drawing.Point(12, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 221);
            this.panel1.TabIndex = 4;
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(127, 120);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(177, 20);
            this.textBoxStep.TabIndex = 9;
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStep.Location = new System.Drawing.Point(91, 121);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(30, 15);
            this.labelStep.TabIndex = 8;
            this.labelStep.Text = "Шаг";
            // 
            // buttonEnterCalculate
            // 
            this.buttonEnterCalculate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEnterCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnterCalculate.Location = new System.Drawing.Point(22, 179);
            this.buttonEnterCalculate.Name = "buttonEnterCalculate";
            this.buttonEnterCalculate.Size = new System.Drawing.Size(282, 33);
            this.buttonEnterCalculate.TabIndex = 7;
            this.buttonEnterCalculate.Text = "Вычислить";
            this.buttonEnterCalculate.UseVisualStyleBackColor = false;
            this.buttonEnterCalculate.Click += new System.EventHandler(this.buttonEnterCalculate_Click);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(127, 95);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(177, 20);
            this.textBoxC.TabIndex = 6;
            // 
            // labelInputC
            // 
            this.labelInputC.AutoSize = true;
            this.labelInputC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputC.Location = new System.Drawing.Point(19, 96);
            this.labelInputC.Name = "labelInputC";
            this.labelInputC.Size = new System.Drawing.Size(101, 15);
            this.labelInputC.TabIndex = 5;
            this.labelInputC.Text = "Коэффициент c";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(127, 69);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(177, 20);
            this.textBoxB.TabIndex = 4;
            // 
            // labelInputB
            // 
            this.labelInputB.AutoSize = true;
            this.labelInputB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputB.Location = new System.Drawing.Point(19, 70);
            this.labelInputB.Name = "labelInputB";
            this.labelInputB.Size = new System.Drawing.Size(102, 15);
            this.labelInputB.TabIndex = 3;
            this.labelInputB.Text = "Коэффициент b";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(127, 43);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(177, 20);
            this.textBoxA.TabIndex = 2;
            // 
            // labelInputA
            // 
            this.labelInputA.AutoSize = true;
            this.labelInputA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputA.Location = new System.Drawing.Point(19, 44);
            this.labelInputA.Name = "labelInputA";
            this.labelInputA.Size = new System.Drawing.Size(102, 15);
            this.labelInputA.TabIndex = 1;
            this.labelInputA.Text = "Коэффициент a";
            // 
            // labelInputHead
            // 
            this.labelInputHead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInputHead.AutoSize = true;
            this.labelInputHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputHead.Location = new System.Drawing.Point(100, 13);
            this.labelInputHead.Name = "labelInputHead";
            this.labelInputHead.Size = new System.Drawing.Size(130, 16);
            this.labelInputHead.TabIndex = 0;
            this.labelInputHead.Text = "Введите значения";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.extra);
            this.panel2.Controls.Add(this.labelExtraHead);
            this.panel2.Location = new System.Drawing.Point(719, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 221);
            this.panel2.TabIndex = 5;
            // 
            // extra
            // 
            this.extra.AutoSize = true;
            this.extra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extra.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.extra.Location = new System.Drawing.Point(17, 43);
            this.extra.Name = "extra";
            this.extra.Size = new System.Drawing.Size(290, 16);
            this.extra.TabIndex = 10;
            this.extra.Text = "Здесь будет дополнительная информация.";
            // 
            // labelExtraHead
            // 
            this.labelExtraHead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelExtraHead.AutoSize = true;
            this.labelExtraHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExtraHead.Location = new System.Drawing.Point(88, 13);
            this.labelExtraHead.Name = "labelExtraHead";
            this.labelExtraHead.Size = new System.Drawing.Size(204, 16);
            this.labelExtraHead.TabIndex = 10;
            this.labelExtraHead.Text = "Дополнительная информация";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.answer);
            this.panel3.Controls.Add(this.labelAnswerHead);
            this.panel3.Location = new System.Drawing.Point(353, 406);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 221);
            this.panel3.TabIndex = 6;
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.answer.Location = new System.Drawing.Point(14, 43);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(152, 16);
            this.answer.TabIndex = 9;
            this.answer.Text = "Здесь будет решение.";
            // 
            // labelAnswerHead
            // 
            this.labelAnswerHead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAnswerHead.AutoSize = true;
            this.labelAnswerHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswerHead.Location = new System.Drawing.Point(145, 13);
            this.labelAnswerHead.Name = "labelAnswerHead";
            this.labelAnswerHead.Size = new System.Drawing.Size(66, 16);
            this.labelAnswerHead.TabIndex = 8;
            this.labelAnswerHead.Text = "Решение";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.graph);
            this.panel4.Location = new System.Drawing.Point(12, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1082, 387);
            this.panel4.TabIndex = 7;
            // 
            // textBoxRadiusSize
            // 
            this.textBoxRadiusSize.Location = new System.Drawing.Point(160, 149);
            this.textBoxRadiusSize.Name = "textBoxRadiusSize";
            this.textBoxRadiusSize.Size = new System.Drawing.Size(144, 20);
            this.textBoxRadiusSize.TabIndex = 11;
            // 
            // labelRadiusSize
            // 
            this.labelRadiusSize.AutoSize = true;
            this.labelRadiusSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRadiusSize.Location = new System.Drawing.Point(19, 142);
            this.labelRadiusSize.Name = "labelRadiusSize";
            this.labelRadiusSize.Size = new System.Drawing.Size(135, 30);
            this.labelRadiusSize.TabIndex = 10;
            this.labelRadiusSize.Text = "Радиус видимой\r\nобласти определения\r\n";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1106, 639);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Калькулятор квадратных уравнений";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelInputHead;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonEnterCalculate;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelInputC;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelInputB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelInputA;
        private System.Windows.Forms.Label extra;
        private System.Windows.Forms.Label labelExtraHead;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label labelAnswerHead;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.TextBox textBoxRadiusSize;
        private System.Windows.Forms.Label labelRadiusSize;
        private System.Windows.Forms.Panel panel4;
    }
}

