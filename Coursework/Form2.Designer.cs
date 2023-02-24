namespace Coursework
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
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.White;
            this.questionLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.button1.Text = "Далі";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 254);
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
    }
}