using System;
using System.Windows.Forms;

namespace pract02_6
{
    /// <summary>
    /// Производная форма для инициализации компонентов на форму
    /// И обработки её элементов
    /// </summary>
    public partial class SolutionForm : Form
    {
        int[] array = new int[15]; // Глобально заданный массив для всех всех методов
        /// <summary>
        /// Конструктор SolutionForm
        /// Инициализизация компонентов на форму
        /// </summary>
        public SolutionForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработка кнопки заполнения. При нажатии
        /// метод заполняет массив размером 15
        /// рандомными числами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFillArray_Click(object sender, EventArgs e)
        {
            lstBoxOriginalValue.Items.Clear(); // Очищаем item элементы в listbox
            Random rnd = new Random(); // экземпляр рандома

            for (int i = 0; i < 15; i++) // добавляем каждый item элемент с массивом с радонмным значением
            {
                array[i] = rnd.Next(-50, 50);
                lstBoxOriginalValue.Items.Add("Array[" + i.ToString() + "] = " + array[i].ToString());
            }
        }
        /// <summary>
        /// Обработка кнопки замены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReplaceArray_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int K = rnd.Next(1, 15);
            int M = rnd.Next(1, 10);
            int[] newArray = new int[array.Length + M]; // Создаём новый массив для изменений с размерностью 15 + M нолей

            lstBoxModifiedValue.Items.Clear(); // Очищаем item элементы в listbox

            for (int i = 0; i < K; i++) // Перебираем массив до K индеса и записываем наш массив
            {
                newArray[i] = array[i];
            }

            for (int i = K; i < K+M; i++) // Перебираем количество начиная с K индекса и записываем M нулей
            {
                newArray[i] = 0;
            }
            for (int i = K +M; i < newArray.Length; i++) // Перебираем оставшую часть массива после нулей
            {
                newArray[i] = array[i - M];
            }
            for (int j = 0; j < newArray.Length; j++)
            {
                // добавляем каждый item элемент измененного массива значениеми
                lstBoxModifiedValue.Items.Add("Array[" + j.ToString() + "] = " + newArray[j].ToString());
            }
        }
    }
}
