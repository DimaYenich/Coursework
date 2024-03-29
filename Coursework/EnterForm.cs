﻿using System;
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
    public partial class enterForm : Form
    {
        public int index;
        static public string currentUser = null;
        public enterForm(int tempIndex)
        {
            index = tempIndex;
            InitializeComponent();

            if(index == 0 )
            {
                textBox1.Text = "Загальний тест";
                withoutNameLabel.Visible = false;
            }
            if (index == 1)            
                textBox1.Text = "Північна Америка";              
            if (index == 2)
                textBox1.Text = "Південна Америка";
            if (index == 3)
                textBox1.Text = "Гренландія";

            if (File.Exists("resoults.txt") == false)
                File.Create("resoults.txt");

        }

        public enterForm()
        {
            InitializeComponent();
            

            if (File.Exists("resoults.txt") == false)
            {
                File.Create("resoults.txt");
            }

        }

        public void StartTest(int index)
        {
            this.Hide();
            new testForm(index).Show();
        }
        //Подія кнопки яка починає тест
        private void button1_Click(object sender, EventArgs e)
        {
            Start(index);
            //Перевірка довжини імені
            //if (inputName.Text.Length >= 2)
            //{
            //    currentUser = inputName.Text;
            //    inputName.Clear();
            //    StartTest(1);
            //}
            //else
            //    MessageBox.Show("Поле імені не може бути пустим та має містити в собі мінімум 2 символи. ","Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Start(int index)
        {
            if (inputName.Text.Length >= 2)
            {
                currentUser = inputName.Text;
                inputName.Clear();
                StartTest(index);
            }
            else
                MessageBox.Show("Поле імені не може бути пустим та має містити в собі мінімум 2 символи. ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }    

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inputName_TextChanged(object sender, EventArgs e)
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
            this.Close();
            new mainForm().Show();
        }

        private void resoults_Click(object sender, EventArgs e)
        {
            if (File.Exists("resoults.txt") == true)
            {
                string resoults = File.ReadAllText("resoults.txt").ToString();
                if (resoults.Length == 0)
                {
                    MessageBox.Show("Список порожній!", "Результати");
                    return;
                }
                MessageBox.Show(resoults, "Результати");
            }
            else
                MessageBox.Show("Список порожній!", "Результати");
        }

        //Пройти тест без вводу імені
        private void withoutNameLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartTest(index);
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Навчально-контролююча програма з георгафії. Написана на мові програмування C#.","Про програму", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void теоритичніВідомостіToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}