﻿namespace Coursework
{
    partial class enterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inputName = new System.Windows.Forms.TextBox();
            this.resoults = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Label();
            this.withoutNameLabel = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic);
            this.enterLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.enterLabel.Location = new System.Drawing.Point(19, 102);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(313, 31);
            this.enterLabel.TabIndex = 0;
            this.enterLabel.Text = "Введіть ім\'я щоб почати";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 65);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "Почати тест";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputName
            // 
            this.inputName.BackColor = System.Drawing.Color.White;
            this.inputName.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputName.Location = new System.Drawing.Point(12, 142);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(328, 38);
            this.inputName.TabIndex = 0;
            this.inputName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resoults
            // 
            this.resoults.BackColor = System.Drawing.Color.Green;
            this.resoults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resoults.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resoults.ForeColor = System.Drawing.Color.White;
            this.resoults.Location = new System.Drawing.Point(180, 212);
            this.resoults.Name = "resoults";
            this.resoults.Size = new System.Drawing.Size(160, 65);
            this.resoults.TabIndex = 3;
            this.resoults.TabStop = false;
            this.resoults.Text = "Результати учасників";
            this.resoults.UseVisualStyleBackColor = false;
            this.resoults.Click += new System.EventHandler(this.resoults_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Arial Black", 25F);
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(319, -7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(42, 48);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "×";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            this.exitButton.MouseHover += new System.EventHandler(this.exitButton_MouseHover);
            // 
            // withoutNameLabel
            // 
            this.withoutNameLabel.AutoSize = true;
            this.withoutNameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.withoutNameLabel.LinkColor = System.Drawing.Color.Gray;
            this.withoutNameLabel.Location = new System.Drawing.Point(28, 186);
            this.withoutNameLabel.Name = "withoutNameLabel";
            this.withoutNameLabel.Size = new System.Drawing.Size(308, 18);
            this.withoutNameLabel.TabIndex = 7;
            this.withoutNameLabel.TabStop = true;
            this.withoutNameLabel.Text = "Пройти без вводу імені (дані не буде збережено)";
            this.withoutNameLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.withoutNameLabel_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBox1.Location = new System.Drawing.Point(31, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(293, 64);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 290);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.withoutNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resoults);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enterLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "enterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Button resoults;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.LinkLabel withoutNameLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}

