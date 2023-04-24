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
        private int currentIndex;
        List<string> questions = new List<string>();
        List<string[]> answerOptions = new List<string[]>();
        List<int> correctAnswers = new List<int>();
        string currentTest = null;
        private void Ques(int index, ref List<string> questions, ref List<string[]> answerOptions, ref List<int> correctAnswers, ref string currentTest)
        {
            questions.Clear();
            answerOptions.Clear();
            correctAnswers.Clear();
            if(index == 0)
            {
                currentTest = "ЗАГАЛЬНИЙ ТЕСТ";
                questions.AddRange(new string[]{"В якій півкулі знаходиться Північна Америка?",              //1
                "Найбільша країна Північної Америки.",
                "Яким з перелічених океанів Північна Америка НЕ омивається.",//3
                "Найбільша температура зареєстрована в Північній Америці.",  //4
                "У якому році була створена перша карта Північної Америки.", //5
                "Найбільше місто в Північні Америці.",                       //6
                "Скільки країн розташовані в Північній Америці.",            //7
                "Найпоширенішою мовою в Північні Америці є.",                //8
                "Який відсоток від суші займає Північна Америка.",           //9
                "Яке приблизне населення в Північній Америці."});

                answerOptions.Add(new string[] { "Східна півкуля", "Західна півкуля", "Північна півкуля", "Південна півкуля" });
                answerOptions.Add(new string[] { "Канада" });//2
                answerOptions.Add(new string[] { "Північно льодовитий", "Атлантичний", "Індійський", "Тихий" });
                answerOptions.Add(new string[] { "57°C", "44°C", "39°C", "62°C" });
                answerOptions.Add(new string[] { "1801", "1782", "1539", "1422" });
                answerOptions.Add(new string[] { "Мехіко" });
                answerOptions.Add(new string[] { "23", "4", "5", "7" });
                answerOptions.Add(new string[] { "Французька", "Іспанська", "Англійська", "Італійська" });
                answerOptions.Add(new string[] { "32%", "12%", "22,2%", "16,5 %" });
                answerOptions.Add(new string[] { "565 млн осіб", "142 млн осіб", "651 млн осіб", "1.2 млрд осіб" });

                correctAnswers.AddRange(new int[]
                    {  1,//1
                        0,//2
                        2,//3
                        0,//4
                        2,//5
                        0,//6
                        0,//7
                        2,//8
                        3,//9
                        0});
            }
            if(index == 1)
            {
                currentTest = "Північна Америка";
                questions.AddRange(new string[]{"В якій півкулі знаходиться Північна Америка?",              //1
                "Найбільша країна Північної Америки.",
                "Яким з перелічених океанів Північна Америка НЕ омивається.",//3
                "Найбільша температура зареєстрована в Північній Америці.",  //4
                "У якому році була створена перша карта Північної Америки.", //5
                "Найбільше місто в Північні Америці.",                       //6
                "Скільки країн розташовані в Північній Америці.",            //7
                "Найпоширенішою мовою в Північні Америці є.",                //8
                "Який відсоток від суші займає Північна Америка.",           //9
                "Яке приблизне населення в Північній Америці."});

                answerOptions.Add(new string[] { "Східна півкуля", "Західна півкуля", "Північна півкуля", "Південна півкуля"});
                answerOptions.Add(new string[] { "Канада" });//2
                answerOptions.Add(new string[] { "Північно льодовитий", "Атлантичний", "Індійський", "Тихий" });
                answerOptions.Add(new string[] { "57°C", "44°C", "39°C", "62°C" });
                answerOptions.Add(new string[] { "1801", "1782", "1539", "1422" });
                answerOptions.Add(new string[] { "Мехіко" });
                answerOptions.Add(new string[] { "23", "4", "5", "7" });
                answerOptions.Add(new string[] { "Французька", "Іспанська", "Англійська", "Італійська" });
                answerOptions.Add(new string[] { "32%", "12%", "22,2%", "16,5 %" });
                answerOptions.Add(new string[] { "565 млн осіб", "142 млн осіб", "651 млн осіб", "1.2 млрд осіб" });
                
                correctAnswers.AddRange(new int[]
                    {  1,//1
                        0,//2
                        2,//3
                        0,//4
                        2,//5
                        0,//6
                        0,//7
                        2,//8
                        3,//9
                        0});
            }

            if(index == 2)
            {
                currentTest = "Південна Америка";
                questions.AddRange(new string[]{
                "Який материк розташований на заході від Атлантичного океану?",
                "Які океани омивають Південну Америку?",
                "Яка кількість незалежних країн знаходиться в Південній Америці?",
                "Яка країна є найбільшою в Південній Америці?",
                "Якою мовою говорять у Бразилії?",
                "Де розташовані найвищі водоспади світу?",
                "Який водоспад є найвищим у світі?",
                "Яка річка є найбільшою в світі та протікає по Південній Америці?",
                "Яка протяжність Південної Америки з півночі на південь та із заходу на схід?",
                "Площа Південої Америки — 17,8 млн км², яке місце вона посідає серед континентів?"});

                answerOptions.Add(new string[] { "Північна Америка", "Південна Америка", "Євразія", "Австралія" }); //
                answerOptions.Add(new string[] { "Тихий і Атлантичний", "Індійський та Атлантичний", "Тихий та Індійський", "Арктичний та Антарктичний" });//
                answerOptions.Add(new string[] { "12"}); //
                answerOptions.Add(new string[] { "Бразилія", "Аргентина", "Колумбія", "Чилі" }); //
                answerOptions.Add(new string[] { "Англійській", "Іспанській", "Португальській", "Французькій" });//
                answerOptions.Add(new string[] { "Північна Америка", "Європа","Африка", "Південна Америка"});//
                answerOptions.Add(new string[] { "Анхель", "Ігуасу","Ніагара", "Вікторія"});//
                answerOptions.Add(new string[] { "Міссісіпі", "Амазонка", "Хуанхе", "Ніл" });//
                answerOptions.Add(new string[] { "7350 км. та 4900 км.", "8320 км. та 3405 км.", "7350 км. та 2300 км.", "5110 км. та 4900 км." });
                answerOptions.Add(new string[] { "1", "2", "3", "4" });

                correctAnswers.AddRange(new int[]
                   { 
                        1,//1
                        0,//2
                        0,//3
                        0,//4
                        2,//5
                        3,//6
                        0,//7
                        1,//8
                        0,//9
                        3
                   });
            }

            if (index == 3)
            {
                currentTest = "Гренландія";
                questions.AddRange(new string[]{"До складу якої країни відноситься Гренландія?",//1
                "З точки зору географії чим є Гренландія?", //2
                "Яка кількість населення в Гренландії за даними на 2019 рік?",//3
                "Яка частина Гренландії вкрита льодом?",//4  
                "До якого материку географічно належить Гренландія?",//5 
                "Як називають основне населення Гренландії?",//6                       
                "Якою є найнижча темература зафіксована на острові?",            
                "На території Гренландії рошташований найбільший у світі льодовик. Яку назву він носить?",                
                "Яка назву носить столиця Гренландії?",//9           
                "Яка кількість людей проживає у столиці?"});//10

                answerOptions.Add(new string[] { "Швеція","Данія","Норвегія","США" });
                answerOptions.Add(new string[] { "Островом","Півостровом","Материком","Льодовиком" });
                answerOptions.Add(new string[] { "55,992", "559,920", "5,599", "5,599,200" });//3
                answerOptions.Add(new string[] { "94%", "80%", "72%", "54%" });//4
                answerOptions.Add(new string[] { "Африка", "Євразія", "Південа Америка", "Північна Америка" });//5
                answerOptions.Add(new string[] { "Ескімоси" });//6
                answerOptions.Add(new string[] { "-93 градусів", "-53 градусів", "-70 градусів", "-112 градусів" });//7
                answerOptions.Add(new string[] { "Сардона", "Алеч", "Ватнайекюдль", "Якобсхавн," });
                answerOptions.Add(new string[] { "Нуук"});//9
                answerOptions.Add(new string[] { "17 тисяч осіб", "9 тисяч осіб", "12 тисяч осіб", "22 тисяч осіб" });//10

                correctAnswers.AddRange(new int[]
                    {  1,//1
                        0,//2
                        0,//3
                        1,//4
                        3,//5
                        0,//6
                        2,//7
                        3,//8
                        0,//9
                        0});//10

            }
        }

        private int currentQuestionIndex = 0;
        private int currentBal = 0;
        public testForm(int index)
        {
            currentIndex = index;
            InitializeComponent();
            Ques(currentIndex, ref questions, ref answerOptions, ref correctAnswers, ref currentTest);
            LoadQuestion(currentQuestionIndex);
        }

        private void testForm_MouseLeave(object sender, EventArgs e)
        {

        }

        //Перехід на головну форму
        private void GoToMain()
        {
            this.Close();
            enterForm main = new enterForm(currentIndex);
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
                        if(currentIndex != 0)
                            MessageBox.Show("Відповідь правильна!", "Перевірка результатів");
                    }
                    else
                        if (currentIndex != 0)
                            MessageBox.Show($"Відповідь неправильна!\nПравильна відповідь: {answerOptions[currentQuestionIndex][correctAnswers[currentQuestionIndex]]}","Перевірка результатів");
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
                    if (currentIndex != 0)
                        MessageBox.Show("Відповідь правильна!", "Перевірка результатів");
                }
                else
                    if (currentIndex != 0)
                        MessageBox.Show($"Відповідь неправильна.\nПравильна відповідь {correctAnswer}", "Перевірка результатів");
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
            string resoult = $"{currentTest}. Результат: {currentBal}/{questions.Count} ({Math.Round(percentageScore)}%)";
            if (enterForm.currentUser != null)
            {
                File.AppendAllText("resoults.txt", "\n" + enterForm.currentUser + ". " + resoult);
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
