namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            totalDisplay = new TextBox();
            btn7 = new Button();
            clear = new Button();
            btn8 = new Button();
            btn9 = new Button();
            div = new Button();
            mult = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            substract = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            calc = new Button();
            add = new Button();
            btnComma = new Button();
            btn0 = new Button();
            SuspendLayout();
            // 
            // totalDisplay
            // 
            totalDisplay.BorderStyle = BorderStyle.FixedSingle;
            totalDisplay.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            totalDisplay.Location = new Point(12, 12);
            totalDisplay.Multiline = true;
            totalDisplay.Name = "totalDisplay";
            totalDisplay.ReadOnly = true;
            totalDisplay.RightToLeft = RightToLeft.No;
            totalDisplay.Size = new Size(286, 74);
            totalDisplay.TabIndex = 0;
            totalDisplay.TextAlign = HorizontalAlignment.Right;
            totalDisplay.TextChanged += textBox1_TextChanged;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(12, 92);
            btn7.Name = "btn7";
            btn7.Size = new Size(67, 66);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button1_Click;
            // 
            // clear
            // 
            clear.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            clear.Location = new Point(12, 380);
            clear.Name = "clear";
            clear.Size = new Size(286, 58);
            clear.TabIndex = 17;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += button17_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(85, 92);
            btn8.Name = "btn8";
            btn8.Size = new Size(67, 66);
            btn8.TabIndex = 18;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button2_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(158, 92);
            btn9.Name = "btn9";
            btn9.Size = new Size(67, 66);
            btn9.TabIndex = 19;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button3_Click;
            // 
            // div
            // 
            div.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            div.Location = new Point(231, 92);
            div.Name = "div";
            div.Size = new Size(67, 66);
            div.TabIndex = 20;
            div.Text = "/";
            div.UseVisualStyleBackColor = true;
            div.Click += button4_Click;
            // 
            // mult
            // 
            mult.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            mult.Location = new Point(231, 164);
            mult.Name = "mult";
            mult.Size = new Size(67, 66);
            mult.TabIndex = 24;
            mult.Text = "*";
            mult.UseVisualStyleBackColor = true;
            mult.Click += button5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(158, 164);
            btn4.Name = "btn4";
            btn4.Size = new Size(67, 66);
            btn4.TabIndex = 23;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(85, 164);
            btn5.Name = "btn5";
            btn5.Size = new Size(67, 66);
            btn5.TabIndex = 22;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button7_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(12, 164);
            btn6.Name = "btn6";
            btn6.Size = new Size(67, 66);
            btn6.TabIndex = 21;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button8_Click;
            // 
            // substract
            // 
            substract.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            substract.Location = new Point(231, 236);
            substract.Name = "substract";
            substract.Size = new Size(67, 66);
            substract.TabIndex = 28;
            substract.Text = "-";
            substract.UseVisualStyleBackColor = true;
            substract.Click += substract_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(158, 236);
            btn1.Name = "btn1";
            btn1.Size = new Size(67, 66);
            btn1.TabIndex = 27;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button10_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(85, 236);
            btn2.Name = "btn2";
            btn2.Size = new Size(67, 66);
            btn2.TabIndex = 26;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button11_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(12, 236);
            btn3.Name = "btn3";
            btn3.Size = new Size(67, 66);
            btn3.TabIndex = 25;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button12_Click;
            // 
            // calc
            // 
            calc.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            calc.Location = new Point(231, 308);
            calc.Name = "calc";
            calc.Size = new Size(67, 66);
            calc.TabIndex = 32;
            calc.Text = "=";
            calc.UseVisualStyleBackColor = true;
            calc.Click += button13_Click;
            // 
            // add
            // 
            add.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            add.Location = new Point(158, 308);
            add.Name = "add";
            add.Size = new Size(67, 66);
            add.TabIndex = 31;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // btnComma
            // 
            btnComma.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnComma.Location = new Point(85, 308);
            btnComma.Name = "btnComma";
            btnComma.Size = new Size(67, 66);
            btnComma.TabIndex = 30;
            btnComma.Text = ",";
            btnComma.UseVisualStyleBackColor = true;
            btnComma.Click += button15_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(12, 308);
            btn0.Name = "btn0";
            btn0.Size = new Size(67, 66);
            btn0.TabIndex = 29;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button16_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(309, 450);
            Controls.Add(calc);
            Controls.Add(add);
            Controls.Add(btnComma);
            Controls.Add(btn0);
            Controls.Add(substract);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(mult);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(div);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(clear);
            Controls.Add(btn7);
            Controls.Add(totalDisplay);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox totalDisplay;
        private Button btn7;
        private Button clear;
        private Button btn8;
        private Button btn9;
        private Button div;
        private Button mult;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button substract;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button calc;
        private Button add;
        private Button btnComma;
        private Button btn0;
    }
}