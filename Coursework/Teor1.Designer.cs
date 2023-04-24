namespace Coursework
{
    partial class Teor1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teor1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.exitButton = new System.Windows.Forms.Label();
            this.south = new System.Windows.Forms.PictureBox();
            this.greenland = new System.Windows.Forms.PictureBox();
            this.north = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.south)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenland)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.north)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(579, 411);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Arial Black", 25F);
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(888, -8);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(42, 48);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "×";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // south
            // 
            this.south.Image = global::Coursework.Properties.Resources.South_America__orthographic_projection__svg;
            this.south.Location = new System.Drawing.Point(597, 83);
            this.south.Name = "south";
            this.south.Size = new System.Drawing.Size(310, 285);
            this.south.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.south.TabIndex = 7;
            this.south.TabStop = false;
            // 
            // greenland
            // 
            this.greenland.Image = global::Coursework.Properties.Resources.Greenland__orthographic_projection__svg;
            this.greenland.Location = new System.Drawing.Point(597, 83);
            this.greenland.Name = "greenland";
            this.greenland.Size = new System.Drawing.Size(310, 285);
            this.greenland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greenland.TabIndex = 6;
            this.greenland.TabStop = false;
            // 
            // north
            // 
            this.north.Image = ((System.Drawing.Image)(resources.GetObject("north.Image")));
            this.north.Location = new System.Drawing.Point(602, 83);
            this.north.Name = "north";
            this.north.Size = new System.Drawing.Size(310, 281);
            this.north.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.north.TabIndex = 1;
            this.north.TabStop = false;
            // 
            // Teor1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.south);
            this.Controls.Add(this.greenland);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.north);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teor1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Північна Америка";
            ((System.ComponentModel.ISupportInitialize)(this.south)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenland)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.north)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox north;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.PictureBox greenland;
        private System.Windows.Forms.PictureBox south;
    }
}