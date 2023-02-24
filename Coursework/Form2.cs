using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class testForm : Form
    {
        private List<string> questions = new List<string>
        {
        "Яка столиця України?",
        "Яка найбільша планета в Сонячній системі?",
        "Який річковий порт знаходиться в Україні?",
        "Яке найбільше озеро в Україні?"
        };

        private List<string> answers = new List<string>
        {
        "Київ",
        "Юпітер",
        "Херсон",
        "Світязь"
        };

        private int currentQuestionIndex = 0;
        private int currentBal = 0;
        public testForm()
        {
            InitializeComponent();
            LoadQuestion(currentQuestionIndex);
        }

        private void testForm_MouseLeave(object sender, EventArgs e)
        {

        }

        //Перехід на головну форму
        private void GoToMain()
        {
            this.Close();
            mainForm main = new mainForm();
            main.Show();
        }
        //Кнопка закрити
        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете завершити тест та вийти." +
                                "\nДанні не буде збережено.", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                GoToMain();           


        }
        private void LoadQuestion(int index)
        {
            questionLabel.Text = questions[index];

            answerTextBox.Clear();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            string userAnswer = answerTextBox.Text;
            string correctAnswer = answers[currentQuestionIndex];

            if (string.Equals(userAnswer, correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                currentBal++;
            }

            if (currentQuestionIndex == questions.Count - 1)
            {
                ShowResults();
            }
            else
            {
                currentQuestionIndex++;
                LoadQuestion(currentQuestionIndex);
            }
        }
        //Вивід результату
        private void ShowResults()
        {
            double percentageScore = (double)currentBal / questions.Count * 100;
            string resoult = $"Результат: {currentBal}/{questions.Count} ({percentageScore}%)";
            //StreamWriter sw = new StreamWriter("resoults.txt");
            File.AppendAllText("resoults.txt", "\n" + mainForm.currentUser+ " " +resoult.ToLower());
            if (MessageBox.Show(resoult) == DialogResult.OK)
            {
                GoToMain();
                mainForm.currentUser = null;
            }
        }
    }
}
