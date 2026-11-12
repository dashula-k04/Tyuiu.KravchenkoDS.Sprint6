using Tyuiu.KravchenkoDS.Sprint6.Task1.V14.Lib;
namespace Tyuiu.KravchenkoDS.Sprint6.Task1.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonDone_KDS.Click += buttonDone_KDS_Click;
        }
        DataService ds = new DataService();

        private void buttonDone_KDS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = int.Parse(textBoxStart_KDS.Text);
                int stopStep = int.Parse(textBoxStop_KDS.Text);
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_KDS.Text = "";
                textBoxResult_KDS.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_KDS.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_KDS.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i < valueArray.Length; i++)
                {
                    string strLine = String.Format("|{0,10:d}|{1,10:f2}|", startStep + i, valueArray[i]);
                    textBoxResult_KDS.AppendText(strLine + Environment.NewLine);
                }

                textBoxResult_KDS.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

        private void buttonHelp_KDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Табулирование функции F(x) = (2x+6)/(cos(x)+x) - 3\nна диапазоне [-5; 5] с шагом 1.\nТаск 1 выполнила студентка группы ИСТНб-26-1 Кравченко Д. С.", "Справка");
        }
        private void labelCondition_KDS_Click(object sender, EventArgs e)
        {
        }



    }



}
