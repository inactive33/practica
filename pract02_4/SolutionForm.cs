using System;
using System.Windows.Forms;

namespace pract02_4
{
    /// <summary>
    /// Проиводный класс SolutionForm от Form
    /// Тело нашей формы
    /// </summary>
    public partial class SolutionForm : Form
    {
        /// <summary>
        /// Конструктор, инициализирует компоненты на форму
        /// </summary>
        public SolutionForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Задаём начальные значения для переменных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SolutionForm_Load(object sender, EventArgs e)
        {
            txtBoxValueX0.Text = "-4";
            txtBoxValueXk.Text = "-6,2";
            txtBoxValueDx.Text = "-0,2";
            txtBoxValueA.Text = "0,1";
            txtBoxValueB.Text = "1";
        }
        /// <summary>
        /// Вычисление цикла с функцией и вывод её в текстовое поле
        /// </summary>
        /// <param name="x0"></param>
        /// <param name="xk"></param>
        /// <param name="dx"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private double SumFunc(double x0, double xk, double dx, double a, double b, double y)
        {
            double x = x0;
            while (x >= xk + dx / 2)
            {
                y = x + Math.Sqrt(Math.Abs(Math.Pow(x, 3) + a - b * Math.Exp(x)));
                txtBoxTotalValue.Text += "x = " + Convert.ToString(x) + "; y = " 
                    + Convert.ToString(y) + Environment.NewLine;
                x += dx;
            }
            return y;
        }
        /// <summary>
        /// Обработчик кнопки, вычисление функции по значениям переменных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTotal_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(txtBoxValueX0.Text);
            double xk = Convert.ToDouble(txtBoxValueXk.Text);
            double dx = Convert.ToDouble(txtBoxValueDx.Text);
            double a = Convert.ToDouble(txtBoxValueA.Text);
            double b = Convert.ToDouble(txtBoxValueB.Text);

            double y = 0;
            SumFunc(x0, xk, dx, a, b, y);
        }
    }
}
