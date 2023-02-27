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
        "Який острів є найбільшишй за своєю площею?",
        "1+1",
        "Назар"
        };

        //Відповіді для кнопок 
        private List<string[]> answerOptions = new List<string[]>
        {
        new string[] {"Червоне море","Мертве море","Азовське море","Аварійське море"},
        new string[] {"Гренландія"},      
        new string[] {"1","2","3","4"},      
        new string[] {"Сніжко"}      
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

            if (answerOptions[index].Length == 4)
            {
                answerTextBox.Visible = false;
                answButton1.Visible = true;
                answButton1.Text = answerOptions[index][0];
                answButton2.Visible = true;
                answButton2.Text = answerOptions[index][1];
                answButton3.Visible = true;
                answButton3.Text = answerOptions[index][2];
                answButton4.Visible = true;
                answButton4.Text = answerOptions[index][3];
            }
            else
            {
                answerTextBox.Visible = true;
                answButton1.Visible = false;
                answButton2.Visible = false;
                answButton3.Visible = false;
                answButton4.Visible = false;
            }
            answerTextBox.Clear();
        }
        //Кнопка перевірки та наступне питання
        private void NextButton_Click(object sender, EventArgs e)
        {
            //Перевірка правильної відповіді з кнопки
            if (answerOptions[currentQuestionIndex].Length == 4)
            {
                if (answButton1.Checked || answButton2.Checked || answButton3.Checked || answButton4.Checked)
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
                    {
                        selectAnsw = answButton3.Text;
                    }
                    else if (answButton4.Checked)
                    {
                        selectAnsw = answButton4.Text;
                    }

                    if (selectAnsw == answerOptions[currentQuestionIndex][correctAnswers[currentQuestionIndex]])
                    {
                        currentBal++;
                    }
                }
                else
                {
                    MessageBox.Show("Оберіть відповідь!", "Помилка");
                    return;
                }
            }
            
            //Провірка чи поле вводу пусте
            if (answerTextBox.Text.Length < 1 && answerTextBox.Visible == true)
            {
                MessageBox.Show("Поле вводу пусте!", "Помилка");
                return;
            }

            //Провірка правильної відповіді з поля для вводу питання
            if (answerOptions[currentQuestionIndex].Length == 1)
            {
                string userAnswer = answerTextBox.Text; //Поле користувача
                string correctAnswer = answerOptions[currentQuestionIndex][correctAnswers[currentQuestionIndex]];//Правильне питання
                if (string.Equals(userAnswer, correctAnswer, StringComparison.OrdinalIgnoreCase))
                {
                    currentBal++;
                }
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
            string resoult = $"Результат: {currentBal}/{questions.Count} ({Math.Round(percentageScore)}%)";
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
