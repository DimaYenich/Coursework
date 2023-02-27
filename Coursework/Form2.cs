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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coursework
{
    public partial class testForm : Form
    {
        //Питання для тесту
        private List<string> questions = new List<string>
        {
        "Яке море вважається найтеплішим у світі?",
        "Який острів являється найбільшим за своєю площею на планеті?",
        "В якому з перерахованих озер тече не прісна, а солона вода?",
        "Яке найбільше озеро в Україні?",
        "Яка столиця України?"
        };

        //Відповіді для питання де потрібно ввести відповідь з клавіатури
        private List<string> answers = new List<string>
        {
        "Червоне море",
        "Гренладія",
        "Дон Жуан",
        "Світязь",
        "Київ"
        };

        //Відповіді для кнопок 
        private List<string[]> answerOptions = new List<string[]>
        {
        new string[] { "Київ", "Львів", "Харків" },
        new string[] { "Юпітер", "Марс", "Венера" },
        new string[] { "Одеса", "Херсон", "Миколаїв" },
        new string[] { "Світязь", "Івано-Франківське", "Ялпуг" }
        };

        //Індекси питань, кнопки
        private List<int> correctAnswers = new List<int>
        {
        0,
        0,
        1,
        0
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

            if (index == 4)
            {
                answerTextBox.Visible = false;
                answButton1.Visible = true;
                answButton1.Text = answerOptions[0][0];
                answButton2.Visible = true;
                answButton2.Text = answerOptions[0][1];
                answButton3.Visible = true;
                answButton3.Text = answerOptions[0][2];
            }
            answerTextBox.Clear();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(answerTextBox.Visible == false)
            {
                if (answButton1.Checked || answButton2.Checked || answButton3.Checked)
                {
                    string selectAnsw = "";
                    if (answButton1.Checked)
                    {
                        selectAnsw = answButton1.Text;
                    }
                    else if (answButton2.Checked)
                    {
                        selectAnsw = answButton2.Text;
                    }
                    else if (answButton3.Checked)
                        selectAnsw = answButton3.Text;
                    if(selectAnsw == answerOptions[0][correctAnswers[0]])
                    {
                        currentBal++;
                    }
                }
                else
                {
                    MessageBox.Show("Обери відповідь!", "Помилка");
                    return;
                }
            }

            if (answerTextBox.Text.Length < 1 && answerTextBox.Visible == true)
            {
                MessageBox.Show("Поле вводу пусте!", "Помилка");
                return;
            }

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

            if(answButton1.Text == correctAnswer || answButton2.Text == correctAnswer || answButton3.Text == correctAnswer)
            {
                currentBal++;
            }
        }
        //Вивід результату
        private void ShowResults()
        {
            double percentageScore = (double)currentBal / questions.Count * 100;
            string resoult = $"Результат: {currentBal}/{questions.Count} ({percentageScore}%)";
            //StreamWriter sw = new StreamWriter("resoults.txt");
            if (mainForm.currentUser != null)
            {
                File.AppendAllText("resoults.txt", "\n" + mainForm.currentUser + " " + resoult.ToLower());
                if (MessageBox.Show(resoult, "Результат") == DialogResult.OK)
                {
                    GoToMain();
                    mainForm.currentUser = null;
                }
            }
            else
               if (MessageBox.Show(resoult, "Результат") == DialogResult.OK)
                {
                GoToMain();
                }
        }
    }
}
