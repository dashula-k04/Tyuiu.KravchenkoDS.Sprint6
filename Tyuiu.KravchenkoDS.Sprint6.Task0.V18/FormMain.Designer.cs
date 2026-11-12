namespace Tyuiu.KravchenkoDS.Sprint6.Task0.V18
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
            labelCondition_KDS = new Label();
            labelTask_KDS = new Label();
            pictureBoxformula_KDS = new PictureBox();
            groupBoxInput_KDS = new GroupBox();
            textBoxInput_KDS = new TextBox();
            labelX_KDS = new Label();
            groupBoxOutput_KDS = new GroupBox();
            textBoxResult_KDS = new TextBox();
            labelResult_KDS = new Label();
            buttonHelp_KDS = new Button();
            buttonDone_KDS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxformula_KDS).BeginInit();
            groupBoxInput_KDS.SuspendLayout();
            groupBoxOutput_KDS.SuspendLayout();
            SuspendLayout();
            // 
            // labelCondition_KDS
            // 
            labelCondition_KDS.AutoSize = true;
            labelCondition_KDS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCondition_KDS.Location = new Point(20, 15);
            labelCondition_KDS.Name = "labelCondition_KDS";
            labelCondition_KDS.Size = new Size(68, 20);
            labelCondition_KDS.TabIndex = 0;
            labelCondition_KDS.Text = "Условие";
            // 
            // labelTask_KDS
            // 
            labelTask_KDS.Location = new Point(20, 40);
            labelTask_KDS.Name = "labelTask_KDS";
            labelTask_KDS.Size = new Size(240, 50);
            labelTask_KDS.TabIndex = 1;
            labelTask_KDS.Text = "Вычислить значение выражения при х=3";
            // 
            // pictureBoxformula_KDS
            // 
            pictureBoxformula_KDS.Image = Properties.Resources.formula;
            pictureBoxformula_KDS.Location = new Point(323, 28);
            pictureBoxformula_KDS.Name = "pictureBoxformula_KDS";
            pictureBoxformula_KDS.Size = new Size(133, 74);
            pictureBoxformula_KDS.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxformula_KDS.TabIndex = 2;
            pictureBoxformula_KDS.TabStop = false;
            // 
            // groupBoxInput_KDS
            // 
            groupBoxInput_KDS.Controls.Add(textBoxInput_KDS);
            groupBoxInput_KDS.Controls.Add(labelX_KDS);
            groupBoxInput_KDS.Location = new Point(12, 146);
            groupBoxInput_KDS.Name = "groupBoxInput_KDS";
            groupBoxInput_KDS.Size = new Size(250, 125);
            groupBoxInput_KDS.TabIndex = 3;
            groupBoxInput_KDS.TabStop = false;
            groupBoxInput_KDS.Text = "Ввод данных";
            // 
            // textBoxInput_KDS
            // 
            textBoxInput_KDS.Location = new Point(8, 64);
            textBoxInput_KDS.Name = "textBoxInput_KDS";
            textBoxInput_KDS.Size = new Size(125, 27);
            textBoxInput_KDS.TabIndex = 1;
            textBoxInput_KDS.Text = "3";
            textBoxInput_KDS.KeyPress += textBoxInput_KDS_KeyPress;
            // 
            // labelX_KDS
            // 
            labelX_KDS.AutoSize = true;
            labelX_KDS.Location = new Point(8, 41);
            labelX_KDS.Name = "labelX_KDS";
            labelX_KDS.Size = new Size(111, 20);
            labelX_KDS.TabIndex = 0;
            labelX_KDS.Text = "Переменная Х";
            // 
            // groupBoxOutput_KDS
            // 
            groupBoxOutput_KDS.Controls.Add(textBoxResult_KDS);
            groupBoxOutput_KDS.Controls.Add(labelResult_KDS);
            groupBoxOutput_KDS.Location = new Point(268, 146);
            groupBoxOutput_KDS.Name = "groupBoxOutput_KDS";
            groupBoxOutput_KDS.Size = new Size(210, 125);
            groupBoxOutput_KDS.TabIndex = 4;
            groupBoxOutput_KDS.TabStop = false;
            groupBoxOutput_KDS.Text = "Вывод данных";
            // 
            // textBoxResult_KDS
            // 
            textBoxResult_KDS.Location = new Point(6, 64);
            textBoxResult_KDS.Name = "textBoxResult_KDS";
            textBoxResult_KDS.ReadOnly = true;
            textBoxResult_KDS.Size = new Size(125, 27);
            textBoxResult_KDS.TabIndex = 1;
            // 
            // labelResult_KDS
            // 
            labelResult_KDS.AutoSize = true;
            labelResult_KDS.Location = new Point(6, 41);
            labelResult_KDS.Name = "labelResult_KDS";
            labelResult_KDS.Size = new Size(75, 20);
            labelResult_KDS.TabIndex = 0;
            labelResult_KDS.Text = "Результат";
            // 
            // buttonHelp_KDS
            // 
            buttonHelp_KDS.Location = new Point(268, 275);
            buttonHelp_KDS.Name = "buttonHelp_KDS";
            buttonHelp_KDS.Size = new Size(54, 29);
            buttonHelp_KDS.TabIndex = 5;
            buttonHelp_KDS.Text = "?";
            buttonHelp_KDS.UseVisualStyleBackColor = true;
            buttonHelp_KDS.Click += buttonHelp_KDS_Click;
            // 
            // buttonDone_KDS
            // 
            buttonDone_KDS.Location = new Point(344, 275);
            buttonDone_KDS.Name = "buttonDone_KDS";
            buttonDone_KDS.Size = new Size(112, 29);
            buttonDone_KDS.TabIndex = 6;
            buttonDone_KDS.Text = "Выполнить";
            buttonDone_KDS.UseVisualStyleBackColor = true;
            buttonDone_KDS.Click += buttonDone_KDS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 316);
            Controls.Add(buttonDone_KDS);
            Controls.Add(buttonHelp_KDS);
            Controls.Add(groupBoxOutput_KDS);
            Controls.Add(groupBoxInput_KDS);
            Controls.Add(pictureBoxformula_KDS);
            Controls.Add(labelTask_KDS);
            Controls.Add(labelCondition_KDS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 18| Кравченко Д.С";
            ((System.ComponentModel.ISupportInitialize)pictureBoxformula_KDS).EndInit();
            groupBoxInput_KDS.ResumeLayout(false);
            groupBoxInput_KDS.PerformLayout();
            groupBoxOutput_KDS.ResumeLayout(false);
            groupBoxOutput_KDS.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCondition_KDS;
        private Label labelTask_KDS;
        private PictureBox pictureBoxformula_KDS;
        private GroupBox groupBoxInput_KDS;
        private TextBox textBoxInput_KDS;
        private Label labelX_KDS;
        private GroupBox groupBoxOutput_KDS;
        private TextBox textBoxResult_KDS;
        private Label labelResult_KDS;
        private Button buttonHelp_KDS;
        private Button buttonDone_KDS;
    }
}
