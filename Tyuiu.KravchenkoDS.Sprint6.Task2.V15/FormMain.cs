using Tyuiu.KravchenkoDS.Sprint6.Task2.V15.Lib;


namespace Tyuiu.KravchenkoDS.Sprint6.Task2.V15
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

                double[] valueArray = ds.GetMassFunction(startStep, stopStep);
                int len = valueArray.Length;
                dataGridViewResult_KDS.Rows.Clear();
                chartFunction_KDS.Series[0].Points.Clear();
                chartFunction_KDS.Titles.Clear();

                chartFunction_KDS.Titles.Add("График функции F(x)");
                chartFunction_KDS.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_KDS.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i < len; i++)
                {
                    int x = startStep + i;
                    dataGridViewResult_KDS.Rows.Add(Convert.ToString(x), Convert.ToString(valueArray[i]));
                    chartFunction_KDS.Series[0].Points.AddXY(x, valueArray[i]);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonHelp_KDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
              "Таск 2 выполнила студентка группы ИСТНб-26-1\nКравченко Дарья Сергеевна",
              "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_KDS_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KDS.BackColor = Color.Pink;
        }

        private void buttonDone_KDS_MouseLeave(object sender, EventArgs e)
        {
           buttonDone_KDS.BackColor = Color.Green; 

         }

        private void buttonDone_KDS_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KDS.BackColor= Color.Blue;
        }
    }
}
