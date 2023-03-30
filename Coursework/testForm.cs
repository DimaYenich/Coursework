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
        "В якій півкулі знаходиться Північна Америка?",              //1
        "Найбільша країна Північної Америки.",                       //2
        "Яким з перелічених океанів Північна Америка НЕ омивається.",//3
        "Найбільша температура зареєстрована в Північній Америці.",  //4
        "У якому році була створена перша карта Північної Америки.",  //5
        "Найбільше місто в Північні Америці.",  //6
        "Скільки країн розташовані в Північній Америці.",  //7
        "Найпоширенішою мовою в Північні Америці є.",  //8
        "Який відсоток від суші займає Північна Америка.",  //9
        "Яке приблизне населення в Північній Америці."   //10
        };

        //Відповіді для кнопок 
        private List<string[]> answerOptions = new List<string[]>
        {
        new string[] {"Східна півкуля","Західна півкуля","Північна півкуля","Південна півкуля"},//1
        new string[] {"Канада"},      //2
        new string[] {"Північно льодовитий","Атлантичний","Індійський","Тихий"},//3
        new string[] {"57°C", "44°C", "39°C", "62°C"},      //4
        new string[] {"1801","1782","1539","1422"},  //5    
        new string[] {"Мехіко"},//6
        new string[] {"23","4","5","7"},//7
        new string[] {"Французька","Іспанська","Англійська","Італійська"},//8
        new string[] {"32%","12%","22,2%","16,5 %"},//9
        new string[] { "565 млн осіб", "142 млн осіб","651 млн осіб","1.2 млрд осіб"}//10
        };

        //Індекси питань, кнопки
        private List<int> correctAnswers = new List<int>
        {
        1,//1
        0,//2
        2,//3
        0,//4
        2,//5
        0,//6
        0,//7
        2,//8
        3,//9
        0 //10

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
            enterForm main = new enterForm();
            main.Show();
        }
        //Кнопка закрити
        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ви дійсно хочете завершити тест та вийти." +
                                "\nданні не буде збережено.", "вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
            answButton1.Checked = false;
            answButton2.Checked = false;
            answButton3.Checked = false;
            answButton4.Checked = false;
            //Провірка чи поле вводу пусте
            if (answerTextBox.Text.Length < 1 && answerTextBox.Visible == true)
            {
                MessageBox.Show("Поле вводу пусте!", "Помилка");
                return;
            }

            //Провірка правильної відповіді з поля для вводу питання
            if (answerOptions[currentQuestionIndex].Length == 1)
            {
                //this.Size = new Size(540, 500);
                string userAnswer = answerTextBox.Text; //Поле користувача
                string correctAnswer = answerOptions[currentQuestionIndex][correctAnswers[currentQuestionIndex]];//Правильне питання
                if (string.Equals(userAnswer.ToLower(), correctAnswer.ToLower(), StringComparison.OrdinalIgnoreCase))
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
            if (enterForm.currentUser != null)
            {
                File.AppendAllText("resoults.txt", "\n" + enterForm.currentUser + " " + resoult.ToLower());
                if (MessageBox.Show(resoult, "Результат") == DialogResult.OK)
                {
                    GoToMain();
                    enterForm.currentUser = null;
                }
            }
            else
               if (MessageBox.Show(resoult, "Результат") == DialogResult.OK)
                {
                    GoToMain();
                }
        }

        private void testForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
