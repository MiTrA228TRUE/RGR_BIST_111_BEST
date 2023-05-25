using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        //размерность двумерного массива (матрицы)
        int Row, Col;
        //тип и имя двумерного массива (матрицы)
        double[,] two_array;
        //переменная для генерации случайных чисел
        Random rnd = new Random();
        //логическая переменная (создана (прочитана из файла)
        // или не создана (не прочитана из файла) матрица )
        bool is_exist_array = false;
        public static void ClearArray(DataGridView dgv, int Row, int Col) 
        {
            if (Row > 0 && Col > 0)
            {
                // очищаем таблицу 
                dgv.Rows.Clear();
                dgv.Columns.Clear();
                // убираем видимость названий столбцов и строк
                dgv.RowHeadersVisible = false;
                dgv.ColumnHeadersVisible = false;
                // назначаем размер таблицы эквивалентным размеры массива
                dgv.ColumnCount = Col;
                dgv.RowCount = Row;
                // задаем размер ячеек
                for (int i = 0; i < Col; i++) dgv.Columns[i].Width = 60;
                for (int i = 0; i < Row; i++) dgv.Rows[i].Height = 30;
            }
            else if (Row == 0 && Col == 0) 
            {
                MessageBox.Show("КОЛИЧЕСТВО СТРОК И СТОЛБЦОВ РАВНО НУЛЮ",
                                "ВНИМАНИЕ!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk,
                                MessageBoxDefaultButton.Button1);
            }
            else if(Row == 0)
             {
                MessageBox.Show("КОЛИЧЕСТВО СТРОК РАВНО НУЛЮ",
                    "ВНИМАНИЕ!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1);
             }
            else {
                MessageBox.Show("КОЛИЧЕСТВО СТОЛБЦОВ РАВНО НУЛЮ",
                                "ВНИМАНИЕ!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk,
                                MessageBoxDefaultButton.Button1);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        public static GraphicsPath RoundedRect(Rectangle baseRect, int radius)
        {
            var diameter = radius * 2;
            var sz = new Size(diameter, diameter);
            var arc = new Rectangle(baseRect.Location, sz);
            var path = new GraphicsPath();

            // Верхний левый угол
            path.AddArc(arc, 180, 90);

            // Верхний правый угол
            arc.X = baseRect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Нижний правый угол
            arc.Y = baseRect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Нижний левый угол
            arc.X = baseRect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
        private void tb_cols_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number1 = e.KeyChar;
            if (!Char.IsDigit(number1) && number1 != 8)
                e.Handled = true;
        }
        private void tb_rows_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number1 = e.KeyChar;
            if (!Char.IsDigit(number1) && number1 != 8)
                e.Handled = true;
        }
        private void tb_number_start_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number1 = e.KeyChar;
            if (!Char.IsDigit(number1) && number1 != 8 && number1 != 45)
                e.Handled = true;
        }
        private void tb_number_end_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number1 = e.KeyChar;
            if (!Char.IsDigit(number1) && number1 != 8 && number1 != 45)
                e.Handled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // ввод размера массива
            bool cols_falsch = string.IsNullOrEmpty(tb_cols.Text);
            bool rows_falsch = string.IsNullOrEmpty(tb_rows.Text);
            bool start_falsch = string.IsNullOrEmpty(tb_number_start.Text);
            bool end_falsch = string.IsNullOrEmpty(tb_number_end.Text);
            for (int i = 1; i < tb_number_start.Text.Length; i++)
            {
                if(tb_number_start.Text[i] == '-' || tb_number_start.Text.Length > 5)
                start_falsch = true;
            }
            for (int i = 1; i < tb_number_end.Text.Length; i++)
            {
                if (tb_number_end.Text[i] == '-' || tb_number_end.Text.Length > 5)
                    end_falsch = true;
            }
            if (tb_cols.Text.Length > 2 || tb_rows.Text.Length > 2) 
            {
                MessageBox.Show("ПРЕВЫШЕНИЕ ЛИМИТА РАЗМЕРА МАТРИЦЫ!",
                               "ВНИМАНИЕ!",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Asterisk,
                               MessageBoxDefaultButton.Button1);
            }
            else if ((cols_falsch == false) && (rows_falsch == false) && (start_falsch == false) && (end_falsch == false))
            {
                Row = int.Parse(tb_rows.Text);
                Col = int.Parse(tb_cols.Text);

                // ввод минимального и максимального числа рандома
                int number_start = int.Parse(tb_number_start.Text);
                int number_end = int.Parse(tb_number_end.Text);

                // создание заданого массива
                two_array = new double[Row, Col];

                // вызов метода очистки таблицы
                ClearArray(dgv1, Row, Col);

                int number_between = number_end - number_start;

                // очищаем tb_output
                tb_output.Clear();
                // заполняем массив и таблицу
                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < Col; j++)
                    {
                        two_array[i, j] = number_start + rnd.NextDouble() * number_between;
                        dgv1.Rows[i].Cells[j].Value = String.Format("{0:0.00}", two_array[i, j]);
                    }
                }
                is_exist_array = true;

            }
            else
            {
                // создаем информативное окно предупреждения о ошибке , на случай невведения размера массива
                MessageBox.Show("ОШИБКА ВВОДА",
                                "ВНИМАНИЕ!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk,
                                MessageBoxDefaultButton.Button1);

            }
        }
        private void tb_run_Click(object sender, EventArgs e)
        {
            {
                // кнопака запуска заданий
                if (is_exist_array)
                {

                    if (rb1.Checked == true)
                    {
                        // задание 1 Поиск среднеарифметического значения массива
                        double[] sred = new double[Row];
                        for (int i = 0; i < Row; i++)
                        {
                            for (int j = 0; j < Col; j++)
                            {
                                sred[i] += two_array[i, j];
                            }

                        }
                        for (int i = 0; i < Row; i++)
                        {
                            sred[i] /= Col;
                        }
                        tb_output.Clear();

                        ClearArray(dgv2, Row, Col);
                        double[,] mass = new double[Row, Col + 1];
                        for (int i = 0; i < Row; i++)
                        {
                            for (int j = 0; j < Col; j++)
                            {
                                mass[i, j] = two_array[i, j];
                            }

                        }
                        for (int i = 0; i < Col; i++)
                        {
                            mass[i, Col] = sred[i];
                        }
                        dgv2.ColumnCount = Col + 1;
                        dgv2.RowCount = Row;
                        

                        // заполняем массив и таблицу
                        for (int i = 0; i < Row; i++)
                        {
                            for (int j = 0; j < Col + 1; j++)
                            {

                                dgv2.Rows[i].Cells[j].Value = String.Format("{0:0.00}", mass[i, j]);
                            }
                        }
                    }
                    else if(rb2.Checked == true)
                    {
                        // задание 2 поиск следа матрицы
                        double sled_mass = 0;
                        if ((Row == Col) && (Row >= 5))
                        {
                            double d1 = 0;
                            int count1 = 0;
                            for (int i = 0; i < Row; i++)
                            {
                                for (int j = 0; j < 0 + i; j++)
                                {

                                    d1 += two_array[i, j];
                                    count1++;
                                }
                            }
                            d1 /= count1;

                            double d2 = 0;
                            int count2 = 0;
                            for (int i = 0; i < Row; i++)
                            {
                                for (int j = 0; j < 0 + i; j++)
                                {
                                    d2 += two_array[j, i];
                                    count2++;
                                }

                            }
                            d2 /= count2;
                            tb_output.Clear();
                            tb_output.Text +=
                                String.Format("Среднее арифметическое под главной диагональю={0}" + Environment.NewLine, d1);
                            tb_output.Text +=
                                String.Format("Среднее арифметическое над главной диагональю={0}" + Environment.NewLine, d2);
                            tb_output.Text +=
                                String.Format("Их произведение={0}" + Environment.NewLine, d1 * d2);
                        }
                        else
                        {
                            MessageBox.Show("МАТРИЦА НЕ КВАДРАТНА",
                                    "ВНИМАНИЕ!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Asterisk,
                                    MessageBoxDefaultButton.Button1);
                        }
                    }
                    else if(rb3.Checked == true)
                    {
                        ClearArray(dgv2, Row, Col);
                        int[,] mass = new int[Row, Col];

                        int summ = 0;
                        int count = 0;
                        for (int i = 0; i < Row; i++)
                        {
                            for (int j = 0; j < Col; j++)
                            {
                                mass[i, j] = rnd.Next(9, 81);
                                if ((mass[i, j] == 9) || (mass[i, j] == 16) || (mass[i, j] == 25) || (mass[i, j] == 36) || (mass[i, j] == 49) || (mass[i, j] == 64) || (mass[i, j] == 81))
                                {
                                    summ += mass[i, j];
                                    count++;
                                }
                            }

                        }
                        for (int i = 0; i < Row; i++)
                        {
                            for (int j = 0; j < Col; j++)
                            {

                                dgv2.Rows[i].Cells[j].Value = String.Format("{0:0.00}", mass[i, j]);
                            }
                        }

                        tb_output.Clear();
                        tb_output.Text +=
                            String.Format("Сумма квадратов={0}" + Environment.NewLine, summ);
                        tb_output.Text +=
                            String.Format("Количество={0}" + Environment.NewLine, count);
                    }
                    else if(rb4.Checked == true)
                    {
                        if ((Row == Col) && (Row >= 5))
                        {
                            ClearArray(dgv2, Row, Col);
                            double[] diagonal = new double[Row];
                            for (int i = 0; i < Row; i++)
                            {
                                diagonal[i] = two_array[i, i];
                            }
                            Array.Sort(diagonal);
                            for (int i = 0; i < Row; i++)
                            {
                                two_array[i, i] = diagonal[i];
                            }
                            for (int i = 0; i < Row; i++)
                            {
                                for (int j = 0; j < Col; j++)
                                {
                                    dgv2.Rows[i].Cells[j].Value = String.Format("{0:0.00}", two_array[i, j]);
                                }
                            }
                            tb_output.Clear();

                        }
                        else
                        {
                            MessageBox.Show("МАТРИЦА НЕ КВАДРАТНА",
                            "ВНИМАНИЕ!",
                                MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button1);
                        }
                    }
                    else if(rb5.Checked == true)
                    {
                        tb_output.Clear();
                        double MIN = double.MaxValue;
                        double MAX = double.MinValue;
                        for (int i = 0; i < Row; i++)
                        {
                            for (int j = 0; j < Col; j++)
                            {
                                if (two_array[i, j] < MIN) MIN = two_array[i, j];
                                if (two_array[i, j] > MAX) MAX = two_array[i, j];
                            }
                        }
                        if (MIN != 0)
                        {
                            ClearArray(dgv2, Row, Col);
                            for (int i = 0; i < Row; i++)
                            {
                                for (int j = 0; j < Col; j++)
                                {
                                    two_array[i, j] /= MAX;
                                }
                            }
                            for (int i = 0; i < Row; i++)
                            {
                                for (int j = 0; j < Col; j++)
                                {
                                    dgv2.Rows[i].Cells[j].Value = String.Format("{0:0.00}", two_array[i, j]);
                                }
                            }
                            tb_output.Text +=
                        String.Format("Минимальный элемент={0}" + Environment.NewLine, MIN);
                            tb_output.Text +=
                        String.Format("Максимальный элемент={0}" + Environment.NewLine, MAX);
                        }
                        else
                        {
                            MessageBox.Show("MIN равен 0",
                                    "ВНИМАНИЕ!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Asterisk,
                                    MessageBoxDefaultButton.Button1);
                        }
                    }
                    else if(tb6.Checked == true) 
                    {
                        if (input_k.Text.Length > 0 && input_k.Text != "Введите k" && input_k.Text.Length < 5) 
                        {
                            tb_output.Clear();
                            double summa = 0;
                            int k = 0;
                            k = Convert.ToInt32(input_k.Text);
                            for (int i = 0; i < Row; i++)
                            {
                                for (int j = 0; j < Col; j++)
                                {
                                    if (i + j == k)
                                        summa += two_array[i, j];
                                }
                            }
                            tb_output.Text +=
                                String.Format("Сумма элементов матрицы, индексы которых составляют в сумме заданное число K={0}" + Environment.NewLine, summa);
                            tb_output.Text +=
                                String.Format("Заданное число K={0}" + Environment.NewLine, k);
                        }
                        else 
                        {
                            MessageBox.Show("ВВЕДИТЕ k",
                                                                "ВНИМАНИЕ!",
                                                                MessageBoxButtons.OK,
                                                                MessageBoxIcon.Asterisk,
                                                                MessageBoxDefaultButton.Button1);
                        }

                    }
                    else 
                    {
                        MessageBox.Show("ВЫБЕРИТЕ ЗАДАНИЕ",
                                                            "ВНИМАНИЕ!",
                                                            MessageBoxButtons.OK,
                                                            MessageBoxIcon.Asterisk,
                                                            MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }
        private void tb_help_Click(object sender, EventArgs e)
        {
            // вывод окна со списком задач
            MessageBox.Show("Задача 1 - Сгенерировать матрицу и заполнить целыми положительными числами в диапазоне от 9 до 81. Вычислить сумму и количество значений, которые являются квадратами чисел от 3 до 9.\n\nЗадача 7 - Сгенерировать матрицу и заполнить вещественными числами (положительными и отрицательными). Вычислить и вывести сумму элементов матрицы, индексы которых составляют в сумме заданное число K. Число K должно вводиться пользователем в отдельное поле.\n\nЗадача 12 - Сгенерировать матрицу и заполнить вещественными числами (положительными и отрицательными). Найти среднее арифметическое элементов каждой строки и вывести их в виде дополнительного столбца матрицы.\n\nЗадача 18 - Сгенерировать квадратную (N≥5, M≥5) матрицу и заполнить вещественными числами (положительными и отрицательными). Отсортировать элементы главной диагонали по возрастанию.\n\nЗадача 29 - Сгенерировать квадратную (N≥5, M≥5) матрицу и заполнить вещественными числами (положительными и отрицательными). Найти среднее арифметическое элементов, стоящих под главной диагональю нулями и среднее арифметическое элементов, стоящих над главной диагональю. Вычислить произведение этих значений.\n\nЗадача 35 - Сгенерировать матрицу и заполнить вещественными числами (положительными и отрицательными). В матрицы найти максимальное значение и поделить на него все элементы матрицы. Проверить не является ли минимальное значение нулем.  ",
                                "ВНИМАНИЕ!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk,
                                MessageBoxDefaultButton.Button1);
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            //кнопка сохранения массива в отдельный файл типа .txt
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Текстовый файл|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(filePath, false);
                sw.WriteLine(Row);
                sw.WriteLine(Col);
                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < Col; j++)
                    {
                        sw.Write(two_array[i, j] + "\t");
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Region = new Region(
                RoundedRect(
                    new Rectangle(0, 0, this.Width, this.Height)
                    , 8
                )
            );

        }
        private void input_k_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number1 = e.KeyChar;
            if (!Char.IsDigit(number1) && number1 != 8)
                e.Handled = true;
        }
        private void tb6_Leave(object sender, EventArgs e)
        {
            input_k.Visible = false;
        }
        private void tb6_Enter(object sender, EventArgs e)
        {
            input_k.Visible = true;
        }
        private void input_k_Enter(object sender, EventArgs e)
        {
            input_k.Visible = true;
            input_k.Text = "";
        }
        private void button_open_Click(object sender, EventArgs e)
        {
            // кнопка импорта массива из файла типа .txt
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Текстовый файл |*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(filePath);
                // чтение размера массива
                Row = int.Parse(sr.ReadLine());
                Col = int.Parse(sr.ReadLine());
                // вывод размера массива
                tb_rows.Text = Row.ToString();
                tb_cols.Text = Col.ToString();
                // создание массива с заданым размером
                two_array = new double[Row, Col];
                ClearArray(dgv1, Row, Col);
                // чтение и и заполнение массива из файла
                for (int i = 0; i < Row; i++)
                {
                    string[] str_array = sr.ReadLine().Split('\t');
                    for (int j = 0; j < Col; j++)
                    {
                        two_array[i, j] = double.Parse(str_array[j]);
                    }
                }
                // заполнение таблицы
                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < Col; j++)
                    {
                        dgv1.Rows[i].Cells[j].Value = String.Format("{0:0.00}", two_array[i, j]);
                    }
                }
            }
        } 
    }
}