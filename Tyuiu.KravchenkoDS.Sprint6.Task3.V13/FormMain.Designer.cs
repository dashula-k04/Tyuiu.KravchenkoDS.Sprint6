namespace Tyuiu.KravchenkoDS.Sprint6.Task3.V13
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
            groupBoxCondition_KDS = new GroupBox();
            labelCondition_KDS = new Label();
            groupBoxOut_KDS = new GroupBox();
            dataGridViewOut_KDS = new DataGridView();
            buttonDone_KDS = new Button();
            buttonHelp_KDS = new Button();
            labelResult_KDS = new Label();
            groupBoxCondition_KDS.SuspendLayout();
            groupBoxOut_KDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KDS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_KDS
            // 
            groupBoxCondition_KDS.Controls.Add(labelCondition_KDS);
            groupBoxCondition_KDS.Location = new Point(29, 26);
            groupBoxCondition_KDS.Name = "groupBoxCondition_KDS";
            groupBoxCondition_KDS.Size = new Size(380, 412);
            groupBoxCondition_KDS.TabIndex = 0;
            groupBoxCondition_KDS.TabStop = false;
            groupBoxCondition_KDS.Text = "Условие";
            // 
            // labelCondition_KDS
            // 
            labelCondition_KDS.Location = new Point(6, 23);
            labelCondition_KDS.Name = "labelCondition_KDS";
            labelCondition_KDS.Size = new Size(323, 191);
            labelCondition_KDS.TabIndex = 0;
            labelCondition_KDS.Text = "Дан массив 5 на 5 элементов.\r\n-7  34  -2  25   5\r\n -16 -12  30  -3  17 \r\n 3 -15  12   5  -5 \r\n17  22  -3  32 -11\r\n9  28   1  -9  -2. \r\nВыполнить сортировку по возрастанию во втором столбце";
            // 
            // groupBoxOut_KDS
            // 
            groupBoxOut_KDS.Controls.Add(dataGridViewOut_KDS);
            groupBoxOut_KDS.Controls.Add(buttonDone_KDS);
            groupBoxOut_KDS.Controls.Add(buttonHelp_KDS);
            groupBoxOut_KDS.Controls.Add(labelResult_KDS);
            groupBoxOut_KDS.Location = new Point(415, 26);
            groupBoxOut_KDS.Name = "groupBoxOut_KDS";
            groupBoxOut_KDS.Size = new Size(467, 412);
            groupBoxOut_KDS.TabIndex = 1;
            groupBoxOut_KDS.TabStop = false;
            groupBoxOut_KDS.Text = "Вывод данных:";
            // 
            // dataGridViewOut_KDS
            // 
            dataGridViewOut_KDS.AllowUserToAddRows = false;
            dataGridViewOut_KDS.AllowUserToDeleteRows = false;
            dataGridViewOut_KDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_KDS.ColumnHeadersVisible = false;
            dataGridViewOut_KDS.Location = new Point(11, 56);
            dataGridViewOut_KDS.Name = "dataGridViewOut_KDS";
            dataGridViewOut_KDS.ReadOnly = true;
            dataGridViewOut_KDS.RowHeadersVisible = false;
            dataGridViewOut_KDS.RowHeadersWidth = 51;
            dataGridViewOut_KDS.ScrollBars = ScrollBars.None;
            dataGridViewOut_KDS.Size = new Size(260, 249);
            dataGridViewOut_KDS.TabIndex = 4;
            // 
            // buttonDone_KDS
            // 
            buttonDone_KDS.Location = new Point(68, 347);
            buttonDone_KDS.Name = "buttonDone_KDS";
            buttonDone_KDS.Size = new Size(107, 47);
            buttonDone_KDS.TabIndex = 3;
            buttonDone_KDS.Text = "Выполнить";
            buttonDone_KDS.UseVisualStyleBackColor = true;
            buttonDone_KDS.Click += buttonDone_KDS_Click;
            // 
            // buttonHelp_KDS
            // 
            buttonHelp_KDS.Location = new Point(11, 347);
            buttonHelp_KDS.Name = "buttonHelp_KDS";
            buttonHelp_KDS.Size = new Size(51, 47);
            buttonHelp_KDS.TabIndex = 2;
            buttonHelp_KDS.Text = "?";
            buttonHelp_KDS.UseVisualStyleBackColor = true;
            buttonHelp_KDS.Click += buttonHelp_KDS_Click;
            // 
            // labelResult_KDS
            // 
            labelResult_KDS.AutoSize = true;
            labelResult_KDS.Location = new Point(6, 23);
            labelResult_KDS.Name = "labelResult_KDS";
            labelResult_KDS.Size = new Size(75, 20);
            labelResult_KDS.TabIndex = 0;
            labelResult_KDS.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 442);
            Controls.Add(groupBoxOut_KDS);
            Controls.Add(groupBoxCondition_KDS);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 13| Кравченко Д.С";
            groupBoxCondition_KDS.ResumeLayout(false);
            groupBoxOut_KDS.ResumeLayout(false);
            groupBoxOut_KDS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KDS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_KDS;
        private Label labelCondition_KDS;
        private GroupBox groupBoxOut_KDS;
        private Button buttonHelp_KDS;
        private Label labelResult_KDS;
        private Button buttonDone_KDS;
        private DataGridView dataGridViewOut_KDS;
    }
}
