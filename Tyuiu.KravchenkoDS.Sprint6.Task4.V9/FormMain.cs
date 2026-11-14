using System.IO;
using System.Diagnostics;
using Tyuiu.KravchenkoDS.Sprint6.Task4.V9.Lib;


namespace Tyuiu.KravchenkoDS.Sprint6.Task4.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_KDS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KDS.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KDS.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartF_KDS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartF_KDS.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOut_KDS.Text = "";

                chartF_KDS.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartF_KDS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOut_KDS.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студенка группы ИСТНб-26-1 Кравченко Дарья Сергеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_KDS_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V9.txt");
                File.WriteAllText(path, textBoxOut_KDS.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }



}


