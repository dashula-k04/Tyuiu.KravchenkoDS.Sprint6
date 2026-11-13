namespace Tyuiu.KravchenkoDS.Sprint6.Task2.V15
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCondition_KDS = new GroupBox();
            labelConditional_KDS = new Label();
            groupBoxIn_KDS = new GroupBox();
            textBoxStopStep_KDS = new TextBox();
            textBoxStartStep_KDS = new TextBox();
            labelStopStep_KDS = new Label();
            labelStartStep_KDS = new Label();
            buttonHelp_KDS = new Button();
            buttonDone_KDS = new Button();
            groupBoxOut_KDS = new GroupBox();
            chartFunction_KDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult_KDS = new DataGridView();
            ColumnX_KDS = new DataGridViewTextBoxColumn();
            ColumnF_KDS = new DataGridViewTextBoxColumn();
            labelResult_KDS = new Label();
            groupBoxCondition_KDS.SuspendLayout();
            groupBoxIn_KDS.SuspendLayout();
            groupBoxOut_KDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KDS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KDS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_KDS
            // 
            groupBoxCondition_KDS.Controls.Add(labelConditional_KDS);
            groupBoxCondition_KDS.Location = new Point(37, 26);
            groupBoxCondition_KDS.Name = "groupBoxCondition_KDS";
            groupBoxCondition_KDS.Size = new Size(549, 313);
            groupBoxCondition_KDS.TabIndex = 0;
            groupBoxCondition_KDS.TabStop = false;
            groupBoxCondition_KDS.Text = "Условие";
            // 
            // labelConditional_KDS
            // 
            labelConditional_KDS.Location = new Point(9, 36);
            labelConditional_KDS.Name = "labelConditional_KDS";
            labelConditional_KDS.Size = new Size(516, 73);
            labelConditional_KDS.TabIndex = 0;
            labelConditional_KDS.Text = "Протабулировать функцию F(x) = 2sin(x)/(3x+1.2) + cos(x) − 7x·2 на заданном диапазоне [-5; 5] с шагом 1.Результат вывести в DataGridView и построить график функции";
            // 
            // groupBoxIn_KDS
            // 
            groupBoxIn_KDS.Controls.Add(textBoxStopStep_KDS);
            groupBoxIn_KDS.Controls.Add(textBoxStartStep_KDS);
            groupBoxIn_KDS.Controls.Add(labelStopStep_KDS);
            groupBoxIn_KDS.Controls.Add(labelStartStep_KDS);
            groupBoxIn_KDS.Location = new Point(40, 343);
            groupBoxIn_KDS.Name = "groupBoxIn_KDS";
            groupBoxIn_KDS.Size = new Size(326, 95);
            groupBoxIn_KDS.TabIndex = 1;
            groupBoxIn_KDS.TabStop = false;
            groupBoxIn_KDS.Text = "Ввод данных";
            // 
            // textBoxStopStep_KDS
            // 
            textBoxStopStep_KDS.Location = new Point(174, 51);
            textBoxStopStep_KDS.Name = "textBoxStopStep_KDS";
            textBoxStopStep_KDS.Size = new Size(125, 27);
            textBoxStopStep_KDS.TabIndex = 3;
            textBoxStopStep_KDS.Text = "5";
            // 
            // textBoxStartStep_KDS
            // 
            textBoxStartStep_KDS.Location = new Point(17, 51);
            textBoxStartStep_KDS.Name = "textBoxStartStep_KDS";
            textBoxStartStep_KDS.Size = new Size(125, 27);
            textBoxStartStep_KDS.TabIndex = 2;
            textBoxStartStep_KDS.Text = "-5";
            // 
            // labelStopStep_KDS
            // 
            labelStopStep_KDS.AutoSize = true;
            labelStopStep_KDS.Location = new Point(174, 23);
            labelStopStep_KDS.Name = "labelStopStep_KDS";
            labelStopStep_KDS.Size = new Size(94, 20);
            labelStopStep_KDS.TabIndex = 1;
            labelStopStep_KDS.Text = "Конец шага:";
            // 
            // labelStartStep_KDS
            // 
            labelStartStep_KDS.AutoSize = true;
            labelStartStep_KDS.Location = new Point(6, 23);
            labelStartStep_KDS.Name = "labelStartStep_KDS";
            labelStartStep_KDS.Size = new Size(88, 20);
            labelStartStep_KDS.TabIndex = 0;
            labelStartStep_KDS.Text = "Старт шага:";
            // 
            // buttonHelp_KDS
            // 
            buttonHelp_KDS.BackColor = Color.Purple;
            buttonHelp_KDS.ForeColor = Color.Black;
            buttonHelp_KDS.Location = new Point(372, 359);
            buttonHelp_KDS.Name = "buttonHelp_KDS";
            buttonHelp_KDS.Size = new Size(94, 79);
            buttonHelp_KDS.TabIndex = 2;
            buttonHelp_KDS.Text = "Справка";
            buttonHelp_KDS.UseVisualStyleBackColor = false;
            buttonHelp_KDS.Click += buttonHelp_KDS_Click;
            // 
            // buttonDone_KDS
            // 
            buttonDone_KDS.BackColor = Color.Green;
            buttonDone_KDS.Location = new Point(472, 359);
            buttonDone_KDS.Name = "buttonDone_KDS";
            buttonDone_KDS.Size = new Size(114, 79);
            buttonDone_KDS.TabIndex = 3;
            buttonDone_KDS.Text = "Выполнить";
            buttonDone_KDS.UseVisualStyleBackColor = false;
            buttonDone_KDS.Click += buttonDone_KDS_Click;
            buttonDone_KDS.MouseDown += buttonDone_KDS_MouseDown;
            buttonDone_KDS.MouseEnter += buttonDone_KDS_MouseEnter;
            buttonDone_KDS.MouseLeave += buttonDone_KDS_MouseLeave;
            // 
            // groupBoxOut_KDS
            // 
            groupBoxOut_KDS.Controls.Add(chartFunction_KDS);
            groupBoxOut_KDS.Controls.Add(dataGridViewResult_KDS);
            groupBoxOut_KDS.Controls.Add(labelResult_KDS);
            groupBoxOut_KDS.Location = new Point(592, 38);
            groupBoxOut_KDS.Name = "groupBoxOut_KDS";
            groupBoxOut_KDS.Size = new Size(507, 400);
            groupBoxOut_KDS.TabIndex = 4;
            groupBoxOut_KDS.TabStop = false;
            groupBoxOut_KDS.Text = "Вывод данных:";
            // 
            // chartFunction_KDS
            // 
            chartArea4.Name = "ChartArea1";
            chartFunction_KDS.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartFunction_KDS.Legends.Add(legend4);
            chartFunction_KDS.Location = new Point(185, 46);
            chartFunction_KDS.Name = "chartFunction_KDS";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartFunction_KDS.Series.Add(series4);
            chartFunction_KDS.Size = new Size(322, 337);
            chartFunction_KDS.TabIndex = 2;
            chartFunction_KDS.Text = "chart1";
            // 
            // dataGridViewResult_KDS
            // 
            dataGridViewResult_KDS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewResult_KDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_KDS.Columns.AddRange(new DataGridViewColumn[] { ColumnX_KDS, ColumnF_KDS });
            dataGridViewResult_KDS.Location = new Point(11, 46);
            dataGridViewResult_KDS.Name = "dataGridViewResult_KDS";
            dataGridViewResult_KDS.RowHeadersVisible = false;
            dataGridViewResult_KDS.RowHeadersWidth = 51;
            dataGridViewResult_KDS.Size = new Size(168, 337);
            dataGridViewResult_KDS.TabIndex = 1;
            // 
            // ColumnX_KDS
            // 
            ColumnX_KDS.HeaderText = "X";
            ColumnX_KDS.MinimumWidth = 6;
            ColumnX_KDS.Name = "ColumnX_KDS";
            // 
            // ColumnF_KDS
            // 
            ColumnF_KDS.HeaderText = "F(X)";
            ColumnF_KDS.MinimumWidth = 6;
            ColumnF_KDS.Name = "ColumnF_KDS";
            // 
            // labelResult_KDS
            // 
            labelResult_KDS.Location = new Point(11, 23);
            labelResult_KDS.Name = "labelResult_KDS";
            labelResult_KDS.Size = new Size(168, 20);
            labelResult_KDS.TabIndex = 0;
            labelResult_KDS.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 450);
            Controls.Add(groupBoxOut_KDS);
            Controls.Add(buttonDone_KDS);
            Controls.Add(buttonHelp_KDS);
            Controls.Add(groupBoxIn_KDS);
            Controls.Add(groupBoxCondition_KDS);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт6| Таск 2| Вариант 15| Кравченко Д.С.";
            groupBoxCondition_KDS.ResumeLayout(false);
            groupBoxIn_KDS.ResumeLayout(false);
            groupBoxIn_KDS.PerformLayout();
            groupBoxOut_KDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_KDS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KDS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_KDS;
        private Label labelConditional_KDS;
        private GroupBox groupBoxIn_KDS;
        private TextBox textBoxStopStep_KDS;
        private TextBox textBoxStartStep_KDS;
        private Label labelStopStep_KDS;
        private Label labelStartStep_KDS;
        private Button buttonHelp_KDS;
        private Button buttonDone_KDS;
        private GroupBox groupBoxOut_KDS;
        private Label labelResult_KDS;
        private DataGridView dataGridViewResult_KDS;
        private DataGridViewTextBoxColumn ColumnX_KDS;
        private DataGridViewTextBoxColumn ColumnF_KDS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KDS;
    }
}
