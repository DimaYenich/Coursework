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
    public partial class mainForm : Form
    {
        static public string currentUser;
        public mainForm()
        {
            InitializeComponent();
            if (File.Exists("resoults.txt") == false)
                File.Create("resoults.txt");

        }

        //Подія кнопки яка починає тест
        private void button1_Click(object sender, EventArgs e)
        {
            //Перевірка довжини імені
            if (inputName.Text.Length >= 2)
            {
                currentUser = inputName.Text;
                inputName.Clear();
                this.Hide();
                testForm test = new testForm();
                test.Show();
            }
            else
                MessageBox.Show("Поле імені не може бути пустим та має містити в собі мінімум 2 символи. ","Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {

        }

        private void exitButton_MouseHover(object sender, EventArgs e)
        {
            exitButton.Font = new Font("Arial Black", 30);
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.Font = new Font("Arial Black", 25);
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resoults_Click(object sender, EventArgs e)
        {
            string resoults = File.ReadAllText("resoults.txt").ToString();
            if (resoults.Length == 0)
            {
                MessageBox.Show("Список порожній!","Результати");
                return;
            }

            MessageBox.Show(resoults,"Результати");
        }
    }
}