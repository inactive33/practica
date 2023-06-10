using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pract02
{
    /// <summary>
    /// Разделяемый производный класс GameForm от Form.
    /// Отвечает за создание формы и инициализацию компонентов
    /// В нём реализована игра
    /// </summary>
    public partial class GameForm : Form
    {
        List<Button> buttons; // Создаём коллекцию для кнопок
        /// <summary>
        /// Конструктор GameForm() инициализирует объекты на форму
        /// </summary>
        public GameForm()
        {
            InitializeComponent(); // Инициализируем компоненты
            Button startbtn = new Button(); // Инициализиуем объект для стартовой кнопки
            startbtn.Click += startbtn_Click_1; // Обрабатываем нажатие на стартовую кнопку вместе с методом
            buttons = new List<Button>(); // Инициализируем объект в коллекцию
            // В объекте коллекции создаём список из кнопок размерностью 5
            buttons.AddRange(new Button[5] { btnClick_1, btnClick_2, btnClick_3, btnClick_4, btnClick_5 }); 
            btnClick_1.Click += btn_Click;
            btnClick_2.Click += btn_Click;
            btnClick_3.Click += btn_Click;
            btnClick_4.Click += btn_Click;
            btnClick_5.Click += btn_Click;

        }
        /// <summary>
        /// Метод Restart() предлагает перезапустить игру
        /// соотвественно инициализируя заного компоненты
        /// </summary>
        public void Restart()
        {
           foreach (Button btn in buttons) {
                if (btn.Visible) return;
            }
                // Диалог пользователя
                DialogResult result = MessageBox.Show(
                    "Начать заново?", "Сообщение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    InitializeComponent();
                }
                else this.Close();
        }
        /// <summary>
        /// Метод btn_Click отвечает за обработку нажатия основных игровых кнопок
        /// </summary>
        /// <param name="sender", объект, вызвавший событие>
        /// <param name="e", экземпляр EventArgs включения>
        private void btn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Button btn = buttons[random.Next(buttons.Count)];
            btn.Visible = !btn.Visible;
            Restart();
        }

        /// <summary>
        /// Метод startbtn_Click_1 обработка нажатия для старовой кнопки
        /// </summary>
        /// <param name="sender", объект, вызвавший событие>
        /// <param name="e", экземпляр EventArgs включения>
        private void startbtn_Click_1(object sender, EventArgs e)
        {
            // Скрываем стартовую кнопку
            startbtn.Visible = false;
        }
    }
}
