using Tyuiu.KravchenkoDS.Sprint6.Task0.V18.Lib;

namespace Tyuiu.KravchenkoDS.Sprint6.Task0.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_KDS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_KDS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInput_KDS.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студенка группы ИСТНб-26-1 Кравченко Д.С.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxInput_KDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
