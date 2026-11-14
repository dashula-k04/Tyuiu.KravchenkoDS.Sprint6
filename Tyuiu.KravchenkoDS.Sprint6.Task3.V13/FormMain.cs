using Tyuiu.KravchenkoDS.Sprint6.Task3.V13.Lib;


namespace Tyuiu.KravchenkoDS.Sprint6.Task3.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();


        }
        DataService ds = new DataService();

        private void buttonHelp_KDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студенка группы ИСТНб-26-1 Кравченко Д.С.",
                            "Сообщение",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_KDS_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[5, 5]
            {
                { -7,  34, -2, 25,   5 },
                { -16, -12, 30, -3,  17 },
                {  3, -15, 12,  5,  -5 },
                { 17,  22, -3, 32, -11 },
                {  9,  28,  1, -9,  -2 }
            };

            int[,] res = ds.Calculate(matrix);

            int rows = res.GetLength(0);
            int columns = res.GetLength(1);

            dataGridViewOut_KDS.ColumnCount = columns;
            dataGridViewOut_KDS.RowCount = rows;

            int colWidth = 40;
            int rowHeight = 25;

            for (int j = 0; j < columns; j++)
            {
                dataGridViewOut_KDS.Columns[j].Width = colWidth;
            }

            for (int i = 0; i < rows; i++)
            {
                dataGridViewOut_KDS.Rows[i].Height = rowHeight;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut_KDS.Rows[i].Cells[j].Value = res[i, j];
                }
            }
            dataGridViewOut_KDS.Width = columns * colWidth + 2;
            dataGridViewOut_KDS.Height = rows * rowHeight + 2;
        }
    }
}



