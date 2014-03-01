namespace DoStuff
{
    partial class NumbersGame
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
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonFirstNumber = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonSecondNumber = new System.Windows.Forms.Button();
            this.buttonThirdNumber = new System.Windows.Forms.Button();
            this.buttonFourthNumber = new System.Windows.Forms.Button();
            this.buttonFifthNumber = new System.Windows.Forms.Button();
            this.buttonSixthNumber = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(141, 177);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonFirstNumber
            // 
            this.buttonFirstNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFirstNumber.Location = new System.Drawing.Point(12, 62);
            this.buttonFirstNumber.Name = "buttonFirstNumber";
            this.buttonFirstNumber.Size = new System.Drawing.Size(29, 23);
            this.buttonFirstNumber.TabIndex = 2;
            this.buttonFirstNumber.Tag = "1";
            this.buttonFirstNumber.Text = "10";
            this.buttonFirstNumber.UseVisualStyleBackColor = false;
            this.buttonFirstNumber.Click += new System.EventHandler(this.buttonNumber_Click);
            this.buttonFirstNumber.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonNumber_Paint);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 177);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // buttonSecondNumber
            // 
            this.buttonSecondNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSecondNumber.Location = new System.Drawing.Point(47, 62);
            this.buttonSecondNumber.Name = "buttonSecondNumber";
            this.buttonSecondNumber.Size = new System.Drawing.Size(29, 23);
            this.buttonSecondNumber.TabIndex = 4;
            this.buttonSecondNumber.Tag = "2";
            this.buttonSecondNumber.Text = "10";
            this.buttonSecondNumber.UseVisualStyleBackColor = false;
            this.buttonSecondNumber.Click += new System.EventHandler(this.buttonNumber_Click);
            this.buttonSecondNumber.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonNumber_Paint);
            // 
            // buttonThirdNumber
            // 
            this.buttonThirdNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonThirdNumber.Location = new System.Drawing.Point(82, 62);
            this.buttonThirdNumber.Name = "buttonThirdNumber";
            this.buttonThirdNumber.Size = new System.Drawing.Size(29, 23);
            this.buttonThirdNumber.TabIndex = 5;
            this.buttonThirdNumber.Tag = "3";
            this.buttonThirdNumber.Text = "10";
            this.buttonThirdNumber.UseVisualStyleBackColor = false;
            this.buttonThirdNumber.Click += new System.EventHandler(this.buttonNumber_Click);
            this.buttonThirdNumber.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonNumber_Paint);
            // 
            // buttonFourthNumber
            // 
            this.buttonFourthNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFourthNumber.Location = new System.Drawing.Point(117, 62);
            this.buttonFourthNumber.Name = "buttonFourthNumber";
            this.buttonFourthNumber.Size = new System.Drawing.Size(29, 23);
            this.buttonFourthNumber.TabIndex = 6;
            this.buttonFourthNumber.Tag = "4";
            this.buttonFourthNumber.Text = "10";
            this.buttonFourthNumber.UseVisualStyleBackColor = false;
            this.buttonFourthNumber.Click += new System.EventHandler(this.buttonNumber_Click);
            this.buttonFourthNumber.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonNumber_Paint);
            // 
            // buttonFifthNumber
            // 
            this.buttonFifthNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFifthNumber.Location = new System.Drawing.Point(152, 62);
            this.buttonFifthNumber.Name = "buttonFifthNumber";
            this.buttonFifthNumber.Size = new System.Drawing.Size(29, 23);
            this.buttonFifthNumber.TabIndex = 7;
            this.buttonFifthNumber.Tag = "5";
            this.buttonFifthNumber.Text = "10";
            this.buttonFifthNumber.UseVisualStyleBackColor = false;
            this.buttonFifthNumber.Click += new System.EventHandler(this.buttonNumber_Click);
            this.buttonFifthNumber.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonNumber_Paint);
            // 
            // buttonSixthNumber
            // 
            this.buttonSixthNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSixthNumber.Location = new System.Drawing.Point(187, 62);
            this.buttonSixthNumber.Name = "buttonSixthNumber";
            this.buttonSixthNumber.Size = new System.Drawing.Size(29, 23);
            this.buttonSixthNumber.TabIndex = 8;
            this.buttonSixthNumber.Tag = "6";
            this.buttonSixthNumber.Text = "10";
            this.buttonSixthNumber.UseVisualStyleBackColor = false;
            this.buttonSixthNumber.Click += new System.EventHandler(this.buttonNumber_Click);
            this.buttonSixthNumber.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonNumber_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(82, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "60";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // NumbersGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 220);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSixthNumber);
            this.Controls.Add(this.buttonFifthNumber);
            this.Controls.Add(this.buttonFourthNumber);
            this.Controls.Add(this.buttonThirdNumber);
            this.Controls.Add(this.buttonSecondNumber);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonFirstNumber);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NumbersGame";
            this.ShowIcon = false;
            this.Text = "Numbers Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonFirstNumber;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonSecondNumber;
        private System.Windows.Forms.Button buttonThirdNumber;
        private System.Windows.Forms.Button buttonFourthNumber;
        private System.Windows.Forms.Button buttonFifthNumber;
        private System.Windows.Forms.Button buttonSixthNumber;
        private System.Windows.Forms.Button button1;
    }
}