namespace Tyuiu.KravchenkoDS.Sprint6.Task4.V9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxCondition_KDS = new GroupBox();
            labelCondition_KDS = new Label();
            groupBoxIn_KDS = new GroupBox();
            labelStopStep_KDS = new Label();
            labelStartStep_KDS = new Label();
            buttonDone_KDS = new Button();
            buttonSave_KDS = new Button();
            buttonHelp_KDS = new Button();
            groupBoxOut_KDS = new GroupBox();
            textBoxOut_KDS = new TextBox();
            chartF_KDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxStartStep_KDS = new TextBox();
            textBoxStopStep_KDS = new TextBox();
            groupBoxCondition_KDS.SuspendLayout();
            groupBoxIn_KDS.SuspendLayout();
            groupBoxOut_KDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartF_KDS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_KDS
            // 
            groupBoxCondition_KDS.Controls.Add(labelCondition_KDS);
            groupBoxCondition_KDS.Location = new Point(12, 12);
            groupBoxCondition_KDS.Name = "groupBoxCondition_KDS";
            groupBoxCondition_KDS.Size = new Size(471, 134);
            groupBoxCondition_KDS.TabIndex = 0;
            groupBoxCondition_KDS.TabStop = false;
            groupBoxCondition_KDS.Text = "Условие";
            // 
            // labelCondition_KDS
            // 
            labelCondition_KDS.AutoSize = true;
            labelCondition_KDS.Location = new Point(6, 23);
            labelCondition_KDS.Name = "labelCondition_KDS";
            labelCondition_KDS.Size = new Size(436, 80);
            labelCondition_KDS.TabIndex = 0;
            labelCondition_KDS.Text = resources.GetString("labelCondition_KDS.Text");
            // 
            // groupBoxIn_KDS
            // 
            groupBoxIn_KDS.Controls.Add(textBoxStopStep_KDS);
            groupBoxIn_KDS.Controls.Add(textBoxStartStep_KDS);
            groupBoxIn_KDS.Controls.Add(labelStopStep_KDS);
            groupBoxIn_KDS.Controls.Add(labelStartStep_KDS);
            groupBoxIn_KDS.Location = new Point(489, 21);
            groupBoxIn_KDS.Name = "groupBoxIn_KDS";
            groupBoxIn_KDS.Size = new Size(250, 125);
            groupBoxIn_KDS.TabIndex = 1;
            groupBoxIn_KDS.TabStop = false;
            groupBoxIn_KDS.Text = "Ввод данных";
            // 
            // labelStopStep_KDS
            // 
            labelStopStep_KDS.AutoSize = true;
            labelStopStep_KDS.Location = new Point(113, 23);
            labelStopStep_KDS.Name = "labelStopStep_KDS";
            labelStopStep_KDS.Size = new Size(91, 20);
            labelStopStep_KDS.TabIndex = 2;
            labelStopStep_KDS.Text = "Конец шага";
            // 
            // labelStartStep_KDS
            // 
            labelStartStep_KDS.AutoSize = true;
            labelStartStep_KDS.Location = new Point(6, 23);
            labelStartStep_KDS.Name = "labelStartStep_KDS";
            labelStartStep_KDS.Size = new Size(85, 20);
            labelStartStep_KDS.TabIndex = 0;
            labelStartStep_KDS.Text = "Старт шага";
            // 
            // buttonDone_KDS
            // 
            buttonDone_KDS.BackColor = Color.GreenYellow;
            buttonDone_KDS.Location = new Point(745, 50);
            buttonDone_KDS.Name = "buttonDone_KDS";
            buttonDone_KDS.Size = new Size(108, 74);
            buttonDone_KDS.TabIndex = 2;
            buttonDone_KDS.Text = "Выполнить";
            buttonDone_KDS.UseVisualStyleBackColor = false;
            buttonDone_KDS.Click += buttonDone_KDS_Click;
            // 
            // buttonSave_KDS
            // 
            buttonSave_KDS.BackColor = Color.DarkOrchid;
            buttonSave_KDS.Location = new Point(859, 50);
            buttonSave_KDS.Name = "buttonSave_KDS";
            buttonSave_KDS.Size = new Size(94, 74);
            buttonSave_KDS.TabIndex = 3;
            buttonSave_KDS.Text = "Сохранить";
            buttonSave_KDS.UseVisualStyleBackColor = false;
            buttonSave_KDS.Click += buttonSave_KDS_Click;
            // 
            // buttonHelp_KDS
            // 
            buttonHelp_KDS.BackColor = Color.Yellow;
            buttonHelp_KDS.Location = new Point(959, 50);
            buttonHelp_KDS.Name = "buttonHelp_KDS";
            buttonHelp_KDS.Size = new Size(94, 74);
            buttonHelp_KDS.TabIndex = 4;
            buttonHelp_KDS.Text = "Справка";
            buttonHelp_KDS.UseVisualStyleBackColor = false;
            buttonHelp_KDS.Click += buttonHelp_KDS_Click;
            // 
            // groupBoxOut_KDS
            // 
            groupBoxOut_KDS.Controls.Add(textBoxOut_KDS);
            groupBoxOut_KDS.Location = new Point(12, 152);
            groupBoxOut_KDS.Name = "groupBoxOut_KDS";
            groupBoxOut_KDS.Size = new Size(268, 354);
            groupBoxOut_KDS.TabIndex = 5;
            groupBoxOut_KDS.TabStop = false;
            groupBoxOut_KDS.Text = "Вывод";
            // 
            // textBoxOut_KDS
            // 
            textBoxOut_KDS.Dock = DockStyle.Fill;
            textBoxOut_KDS.Location = new Point(3, 23);
            textBoxOut_KDS.Multiline = true;
            textBoxOut_KDS.Name = "textBoxOut_KDS";
            textBoxOut_KDS.ReadOnly = true;
            textBoxOut_KDS.ScrollBars = ScrollBars.Vertical;
            textBoxOut_KDS.Size = new Size(262, 328);
            textBoxOut_KDS.TabIndex = 0;
            // 
            // chartF_KDS
            // 
            chartArea1.AxisX.Title = "Ось Х";
            chartArea1.AxisY.Title = "Ось Y";
            chartArea1.Name = "ChartArea1";
            chartF_KDS.ChartAreas.Add(chartArea1);
            chartF_KDS.Location = new Point(302, 152);
            chartF_KDS.Name = "chartF_KDS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chartF_KDS.Series.Add(series1);
            chartF_KDS.Size = new Size(751, 351);
            chartF_KDS.TabIndex = 6;
            chartF_KDS.Text = "chart1";
            title1.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title1.ForeColor = Color.LightSeaGreen;
            title1.Name = " График функции F(X)";
            title1.Text = "График функции F(X)";
            chartF_KDS.Titles.Add(title1);
            // 
            // textBoxStartStep_KDS
            // 
            textBoxStartStep_KDS.Location = new Point(14, 56);
            textBoxStartStep_KDS.Name = "textBoxStartStep_KDS";
            textBoxStartStep_KDS.Size = new Size(61, 27);
            textBoxStartStep_KDS.TabIndex = 3;
            textBoxStartStep_KDS.Text = "-5";
            // 
            // textBoxStopStep_KDS
            // 
            textBoxStopStep_KDS.Location = new Point(113, 56);
            textBoxStopStep_KDS.Name = "textBoxStopStep_KDS";
            textBoxStopStep_KDS.Size = new Size(63, 27);
            textBoxStopStep_KDS.TabIndex = 4;
            textBoxStopStep_KDS.Text = "5";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 513);
            Controls.Add(chartF_KDS);
            Controls.Add(groupBoxOut_KDS);
            Controls.Add(buttonHelp_KDS);
            Controls.Add(buttonSave_KDS);
            Controls.Add(buttonDone_KDS);
            Controls.Add(groupBoxIn_KDS);
            Controls.Add(groupBoxCondition_KDS);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6| Таск 4 |Вариант 9 |Кравченко Д.С";
            groupBoxCondition_KDS.ResumeLayout(false);
            groupBoxCondition_KDS.PerformLayout();
            groupBoxIn_KDS.ResumeLayout(false);
            groupBoxIn_KDS.PerformLayout();
            groupBoxOut_KDS.ResumeLayout(false);
            groupBoxOut_KDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartF_KDS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_KDS;
        private Label labelCondition_KDS;
        private GroupBox groupBoxIn_KDS;
        private Label labelStartStep_KDS;
        private Label labelStopStep_KDS;
        private Button buttonDone_KDS;
        private Button buttonSave_KDS;
        private Button buttonHelp_KDS;
        private GroupBox groupBoxOut_KDS;
        private TextBox textBoxOut_KDS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartF_KDS;
        private TextBox textBoxStopStep_KDS;
        private TextBox textBoxStartStep_KDS;
    }
}
