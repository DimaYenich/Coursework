﻿namespace Coursework
{
    partial class testForm
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
            this.questionLabel = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.answButton1 = new System.Windows.Forms.RadioButton();
            this.answButton2 = new System.Windows.Forms.RadioButton();
            this.answButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.White;
            this.questionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionLabel.Enabled = false;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.questionLabel.Location = new System.Drawing.Point(12, 27);
            this.questionLabel.Multiline = true;
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.ReadOnly = true;
            this.questionLabel.Size = new System.Drawing.Size(516, 65);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.TabStop = false;
            this.questionLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Arial Black", 25F);
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(505, -9);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(42, 48);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "×";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.answerTextBox.Location = new System.Drawing.Point(12, 128);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(516, 38);
            this.answerTextBox.TabIndex = 6;
            this.answerTextBox.TabStop = false;
            this.answerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button1.Location = new System.Drawing.Point(12, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(516, 61);
            this.button1.TabIndex = 7;
            this.button1.TabStop = false;
            this.button1.Text = "Далі";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // answButton1
            // 
            this.answButton1.AutoSize = true;
            this.answButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.answButton1.Location = new System.Drawing.Point(14, 129);
            this.answButton1.Name = "answButton1";
            this.answButton1.Size = new System.Drawing.Size(167, 33);
            this.answButton1.TabIndex = 8;
            this.answButton1.TabStop = true;
            this.answButton1.Text = "radioButton1";
            this.answButton1.UseVisualStyleBackColor = true;
            this.answButton1.Visible = false;
            // 
            // answButton2
            // 
            this.answButton2.AutoSize = true;
            this.answButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.answButton2.Location = new System.Drawing.Point(194, 129);
            this.answButton2.Name = "answButton2";
            this.answButton2.Size = new System.Drawing.Size(167, 33);
            this.answButton2.TabIndex = 9;
            this.answButton2.TabStop = true;
            this.answButton2.Text = "radioButton1";
            this.answButton2.UseVisualStyleBackColor = true;
            this.answButton2.Visible = false;
            // 
            // answButton3
            // 
            this.answButton3.AutoSize = true;
            this.answButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.answButton3.Location = new System.Drawing.Point(379, 129);
            this.answButton3.Name = "answButton3";
            this.answButton3.Size = new System.Drawing.Size(167, 33);
            this.answButton3.TabIndex = 10;
            this.answButton3.TabStop = true;
            this.answButton3.Text = "radioButton1";
            this.answButton3.UseVisualStyleBackColor = true;
            this.answButton3.Visible = false;
            // 
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 260);
            this.Controls.Add(this.answButton3);
            this.Controls.Add(this.answButton2);
            this.Controls.Add(this.answButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.questionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "testForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.MouseLeave += new System.EventHandler(this.testForm_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionLabel;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton answButton1;
        private System.Windows.Forms.RadioButton answButton2;
        private System.Windows.Forms.RadioButton answButton3;
    }
}