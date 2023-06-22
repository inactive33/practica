using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace pract02_5
{
    /// <summary>
    /// Класс SolutionForm
    /// Отвечает за инициализацию компонентов и их обработку
    /// </summary>
    public partial class SolutionForm : Form
    {
        /// <summary>
        /// Конструктор инициализирует компоненты на форму
        /// </summary>
        public SolutionForm()
        {
            InitializeComponent();
        }

        private void SolutionForm_Load(object sender, EventArgs e)
        {
            lstBoxData.Items.Add("We will rest and you drive.");
            lstBoxData.Items.Add("It 2 sentenses.");
        }

        /// <summary>
        /// Обработка нажатия кнопки.
        /// Преобразуем текст из listbox
        /// В текст с прописными буквами у каждого слова
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Создаём экземпляр списка текста
            List<string> text = new List<string>();

            // Перебираем все item и представляем как текст
            // Добавляем это в коллекцию текста
            foreach(var item in lstBoxData.Items)
            {
                text.Add(item.ToString());
            }
            // Создаём ещё экземпляр коллекции для модифицирования текста
            List<string> modifiedText = new List<string>();
            // Перебираем предложения в тексте
            foreach (var sentence in text)
            {   // Создаём массив слов и разделяем предложение на подстроки пробелами
                string[] words = sentence.Split(' '); 
                string modifiedSentences = ""; // Создаём пустую строку, в которой будем хранить итоговое предложение
                foreach (var word in words) // Перебираем слова в предложении
                {
                    // Создаём модифицированное слово
                    // В каждом слове увеличиваем 1 букву,
                    // (берём первую букву (индекс - 0) и прибавляем оставшуюся подстроку) 
                    string modifiedWord = char.ToUpper(word[0]) + word.Substring(1);
                    // Прибавляем каждое модифицированное слово и разделяем пробелами
                    modifiedSentences += modifiedWord + " ";
                }
                // Добавляем в текст наши предложения, удаляя начальные и конечнные символы пробелов
            modifiedText.Add(modifiedSentences.Trim()); 
            }
            // Записываем в label наш текст
            lblTotal.Text = string.Join(Environment.NewLine, modifiedText);
        }
    }
}
