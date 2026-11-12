namespace Tyuiu.KravchenkoDS.Sprint6.Task1.V14
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
            groupBoxInput_KDS = new GroupBox();
            textBoxStop_KDS = new TextBox();
            labelStop_KDS = new Label();
            textBoxStart_KDS = new TextBox();
            labelStart_KDS = new Label();
            groupBoxOutput_KDS = new GroupBox();
            textBoxResult_KDS = new TextBox();
            labelResult_KDS = new Label();
            buttonHelp_KDS = new Button();
            buttonDone_KDS = new Button();
            groupBoxCondition_KDS.SuspendLayout();
            groupBoxInput_KDS.SuspendLayout();
            groupBoxOutput_KDS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_KDS
            // 
            groupBoxCondition_KDS.Controls.Add(labelCondition_KDS);
            groupBoxCondition_KDS.Location = new Point(12, 12);
            groupBoxCondition_KDS.Name = "groupBoxCondition_KDS";
            groupBoxCondition_KDS.Size = new Size(585, 125);
            groupBoxCondition_KDS.TabIndex = 0;
            groupBoxCondition_KDS.TabStop = false;
            groupBoxCondition_KDS.Text = "Условие";
            // 
            // labelCondition_KDS
            // 
            labelCondition_KDS.Location = new Point(6, 23);
            labelCondition_KDS.Name = "labelCondition_KDS";
            labelCondition_KDS.Size = new Size(460, 99);
            labelCondition_KDS.TabIndex = 0;
            labelCondition_KDS.Text = "Протабулировать функцию F(x)=(2x +6)/(cos(x)+x)-3 на заданном диапозоне [-5;5] с шагом 1.Результат вывести в Texbox.";
            labelCondition_KDS.Click += labelCondition_KDS_Click;
            // 
            // groupBoxInput_KDS
            // 
            groupBoxInput_KDS.Controls.Add(textBoxStop_KDS);
            groupBoxInput_KDS.Controls.Add(labelStop_KDS);
            groupBoxInput_KDS.Controls.Add(textBoxStart_KDS);
            groupBoxInput_KDS.Controls.Add(labelStart_KDS);
            groupBoxInput_KDS.Location = new Point(12, 313);
            groupBoxInput_KDS.Name = "groupBoxInput_KDS";
            groupBoxInput_KDS.Size = new Size(332, 125);
            groupBoxInput_KDS.TabIndex = 1;
            groupBoxInput_KDS.TabStop = false;
            groupBoxInput_KDS.Text = "Ввод данных";
            // 
            // textBoxStop_KDS
            // 
            textBoxStop_KDS.Location = new Point(190, 55);
            textBoxStop_KDS.Name = "textBoxStop_KDS";
            textBoxStop_KDS.Size = new Size(125, 27);
            textBoxStop_KDS.TabIndex = 3;
            textBoxStop_KDS.Text = "5";
            // 
            // labelStop_KDS
            // 
            labelStop_KDS.AutoSize = true;
            labelStop_KDS.Location = new Point(190, 26);
            labelStop_KDS.Name = "labelStop_KDS";
            labelStop_KDS.Size = new Size(91, 20);
            labelStop_KDS.TabIndex = 2;
            labelStop_KDS.Text = "Конец шага";
            // 
            // textBoxStart_KDS
            // 
            textBoxStart_KDS.Location = new Point(18, 55);
            textBoxStart_KDS.Name = "textBoxStart_KDS";
            textBoxStart_KDS.Size = new Size(125, 27);
            textBoxStart_KDS.TabIndex = 1;
            textBoxStart_KDS.Text = "-5";
            // 
            // labelStart_KDS
            // 
            labelStart_KDS.AutoSize = true;
            labelStart_KDS.Location = new Point(13, 26);
            labelStart_KDS.Name = "labelStart_KDS";
            labelStart_KDS.Size = new Size(85, 20);
            labelStart_KDS.TabIndex = 0;
            labelStart_KDS.Text = "Старт шага";
            // 
            // groupBoxOutput_KDS
            // 
            groupBoxOutput_KDS.Controls.Add(textBoxResult_KDS);
            groupBoxOutput_KDS.Controls.Add(labelResult_KDS);
            groupBoxOutput_KDS.Location = new Point(603, 12);
            groupBoxOutput_KDS.Name = "groupBoxOutput_KDS";
            groupBoxOutput_KDS.Size = new Size(306, 426);
            groupBoxOutput_KDS.TabIndex = 2;
            groupBoxOutput_KDS.TabStop = false;
            groupBoxOutput_KDS.Text = "Вывод данных";
            // 
            // textBoxResult_KDS
            // 
            textBoxResult_KDS.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_KDS.Location = new Point(6, 63);
            textBoxResult_KDS.Multiline = true;
            textBoxResult_KDS.Name = "textBoxResult_KDS";
            textBoxResult_KDS.ReadOnly = true;
            textBoxResult_KDS.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KDS.Size = new Size(300, 380);
            textBoxResult_KDS.TabIndex = 1;
            // 
            // labelResult_KDS
            // 
            labelResult_KDS.AutoSize = true;
            labelResult_KDS.Location = new Point(15, 40);
            labelResult_KDS.Name = "labelResult_KDS";
            labelResult_KDS.Size = new Size(78, 20);
            labelResult_KDS.TabIndex = 0;
            labelResult_KDS.Text = "Результат:";
            // 
            // buttonHelp_KDS
            // 
            buttonHelp_KDS.BackColor = SystemColors.MenuHighlight;
            buttonHelp_KDS.Location = new Point(350, 331);
            buttonHelp_KDS.Name = "buttonHelp_KDS";
            buttonHelp_KDS.Size = new Size(116, 101);
            buttonHelp_KDS.TabIndex = 3;
            buttonHelp_KDS.Text = "Справка";
            buttonHelp_KDS.UseVisualStyleBackColor = false;
            buttonHelp_KDS.Click += buttonHelp_KDS_Click;
            // 
            // buttonDone_KDS
            // 
            buttonDone_KDS.BackColor = Color.Green;
            buttonDone_KDS.Location = new Point(472, 331);
            buttonDone_KDS.Name = "buttonDone_KDS";
            buttonDone_KDS.Size = new Size(125, 101);
            buttonDone_KDS.TabIndex = 4;
            buttonDone_KDS.Text = "Выполнить";
            buttonDone_KDS.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 450);
            Controls.Add(buttonDone_KDS);
            Controls.Add(buttonHelp_KDS);
            Controls.Add(groupBoxOutput_KDS);
            Controls.Add(groupBoxInput_KDS);
            Controls.Add(groupBoxCondition_KDS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 14| Кравченко Д.С";
            groupBoxCondition_KDS.ResumeLayout(false);
            groupBoxInput_KDS.ResumeLayout(false);
            groupBoxInput_KDS.PerformLayout();
            groupBoxOutput_KDS.ResumeLayout(false);
            groupBoxOutput_KDS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_KDS;
        private Label labelCondition_KDS;
        private GroupBox groupBoxInput_KDS;
        private GroupBox groupBoxOutput_KDS;
        private TextBox textBoxStop_KDS;
        private Label labelStop_KDS;
        private TextBox textBoxStart_KDS;
        private Label labelStart_KDS;
        private Button buttonHelp_KDS;
        private Button buttonDone_KDS;
        private Label labelResult_KDS;
        private TextBox textBoxResult_KDS;
    }
}
