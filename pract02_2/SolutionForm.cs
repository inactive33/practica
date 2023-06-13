using System;
using System.Windows.Forms;

namespace pract02_2
{
    /// <summary>
    /// Производный класс SolutionForm от Form
    /// для решения выражения по формуле
    /// </summary>
    public partial class SolutionForm : Form
    {
        /// <summary>
        /// Конструктор SolutionForm
        /// содержит метод из SolutionForm.Disigner,
        /// который служит для инициализации компонентов
        /// </summary>
        public SolutionForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод SolutionForm
        /// Задаёт начальный значения для переменных
        /// </summary>
        private void SolutionForm_Load(object sender, EventArgs e)
        {
            TxtValueX.Text = "3,251";
            TxtValueY.Text =  "0,827";
            TxtValueZ.Text = "25,001";
            TxtValueB.Text = "0,7121";
        }
        /// <summary>
        /// Метод Calculation вычислляет текущие переменные
        /// и возвращает результат
        /// </summary
        private double Calculation(ref double total)
        {
            double x, y, z, b;
            x = double.Parse(TxtValueX.Text);
            y = double.Parse(TxtValueY.Text);
            z = double.Parse(TxtValueZ.Text);
            b = double.Parse(TxtValueB.Text);

            double a = Math.Pow(y, Math.Pow(1.0 / 3.0, Math.Abs(x)))
                + Math.Pow(Math.Cos(y), 3);
            double d = Math.Abs(x - y) * (1 + Math.Pow(Math.Sin(z), 2)) / Math.Sqrt(x + y);
            double f = Math.Pow(Math.E, Math.Abs(x - y)) + x / 2;
            total = a * d / f;
            return total;
        }
        /// <summary>
        /// Метод btnSolve_Click обрабатывает нажатие кнопки.
        /// Выводим в label ответ
        /// </summary>
        private void btnSolve_Click(object sender, EventArgs e)
        {
            double total = 0;
            Calculation(ref total); 
            lblTotalValue.Text = total.ToString(); // Вывод в label результата
        }

    }
}
