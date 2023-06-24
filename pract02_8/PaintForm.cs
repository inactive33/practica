using System.Drawing;
using System.Windows.Forms;

namespace pract02_8
{   
    /// <summary>
    /// Производный класс PaintForm
    /// Инициализирует компоненты и рисует объекты на форму
    /// </summary>
    public partial class PaintForm : Form
    {
        // Создаём 2 экземпляра с цветами для пространственной кисти
        SolidBrush myFigureGY = new SolidBrush(Color.GreenYellow);
        SolidBrush myFigureG = new SolidBrush(Color.ForestGreen);
        /// <summary>
        /// Конструктор для инициализации компонентов
        /// </summary>
        public PaintForm() 
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик PaintForm_Paint для рисования на форме объектов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaintForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // инициализируем графику
            g.Clear(Color.White); // Очищаем экран формы
            // Создаём 3 объекта по точкам с заполненными полигонами
            g.FillPolygon(myFigureGY, new Point[] {

                new Point(50, 400), new Point(100, 500),
                new Point(100, 500), new Point(250, 200),
                new Point(250, 200), new Point(150,200),
            });
            g.FillPolygon(myFigureG, new Point[] {
                new Point(250, 200), new Point(400, 400),
                new Point (400, 400), new Point(300,400),
                new Point (300, 400), new Point(200, 295)
            });

            g.FillPolygon(myFigureGY, new Point[]
            {
                new Point(400, 400), new Point(180, 400),
                new Point(180, 400), new Point(125, 500),
                new Point(130, 500), new Point(350, 500)
            });
        }
    }
}
