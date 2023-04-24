using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new enterForm(0).Show();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void проПрограмуToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Навчально контролююча програма на тему географія", "Про програму");
        }

        private void теоріяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void тема1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Teor1().Show();

        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void тема2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teor1 teor = new Teor1(1);
            teor.Show();
        }

        private void тестНаТему1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new enterForm(1).Show();
        }

        private void тестНаТему2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new enterForm(2).Show();
        }

        private void загальнийТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new enterForm(3).Show();
        }

        private void тема3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teor1 teor = new Teor1(3);
            teor.Show();
        }
    }
}
