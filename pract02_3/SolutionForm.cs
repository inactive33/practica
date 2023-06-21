using System;
using System.Windows.Forms;

namespace pract02_3
{
    /// <summary>
    /// Класс SolutionForm от Form служит для инициализации, загрузки
    /// компонентов и выполнения различных методов
    /// </summary>
    public partial class SolutionForm : Form
    {
        /// <summary>
        /// Конструктор SolutionForm инициализирует все компоненты
        /// с помощью метода InitializeComponent
        /// </summary>
        public SolutionForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Загрузка начальных значений в текстовые блоки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SolutionForm_Load(object sender, EventArgs e)
        {
            TxtBoxX.Text = "1,00";
            TxtBoxY.Text = "1,00";
            TxtBoxZ.Text = "1,00";
        }
        /// <summary>
        /// Обработка нажатия на кнопку
        /// Вывод результат с решением по формуле
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(TxtBoxX.Text);
            double y = Convert.ToDouble(TxtBoxY.Text);
            double z = Convert.ToDouble(TxtBoxZ.Text);

            double result = CheckFunc(x, y, z);
            lblTotalValue.Text = result.ToString();
        }
        /// <summary>
        /// Вычисление по формуле с Sin
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public double SumSin(double x, double y, double z)
        {
            double max = Math.Max(Math.Sin(x), Math.Max(y, z));
            double min = Math.Min(Math.Sin(x), y);
            double m = max / min + 5;
            return Math.Round(m);
        }
        /// <summary>
        /// Вычисление по формуле с Cos
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public double SumCos(double x, double y, double z)
        {
            double max = Math.Max(Math.Cos(x), Math.Max(y, z));
            double min = Math.Min(Math.Cos(x), y);
            double m = max / min + 5;
            return Math.Round(m);
        }
        /// <summary>
        /// Вычисление по формуле с Exp
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public double SumExp(double x, double y, double z)
        {
            double max = Math.Max(Math.Exp(x), Math.Max(y, z));
            double min = Math.Min(Math.Exp(x), y);
            double m = max / min + 5;
            return Math.Round(m);
        }
        /// <summary>
        /// Проверяем какая радио-кнопка нажата
        /// И возвращаем вычисление по определенному методу
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public double CheckFunc(double x, double y, double z)
        {
            if (rdoBtnSin.Checked)
            {
                return SumSin(x, y, z);
            }
            else if (rdoBtnCos.Checked)
            {
                return SumCos(x, y, z);
            }
            else if (rdoBtnExp.Checked)
            {
                return SumExp(x, y, z);
            }
            else
            {
                MessageBox.Show("Выберите функцию!");
                return 0;
            }
        }
    }
}
