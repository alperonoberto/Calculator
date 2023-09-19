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
            button1 = new Button();
            clear = new Button();
            button2 = new Button();
            button3 = new Button();
            div = new Button();
            mult = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            substract = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            calc = new Button();
            add = new Button();
            button15 = new Button();
            button16 = new Button();
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 92);
            button1.Name = "button1";
            button1.Size = new Size(67, 66);
            button1.TabIndex = 1;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(85, 92);
            button2.Name = "button2";
            button2.Size = new Size(67, 66);
            button2.TabIndex = 18;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(158, 92);
            button3.Name = "button3";
            button3.Size = new Size(67, 66);
            button3.TabIndex = 19;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(158, 164);
            button6.Name = "button6";
            button6.Size = new Size(67, 66);
            button6.TabIndex = 23;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(85, 164);
            button7.Name = "button7";
            button7.Size = new Size(67, 66);
            button7.TabIndex = 22;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(12, 164);
            button8.Name = "button8";
            button8.Size = new Size(67, 66);
            button8.TabIndex = 21;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
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
            // button10
            // 
            button10.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(158, 236);
            button10.Name = "button10";
            button10.Size = new Size(67, 66);
            button10.TabIndex = 27;
            button10.Text = "1";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(85, 236);
            button11.Name = "button11";
            button11.Size = new Size(67, 66);
            button11.TabIndex = 26;
            button11.Text = "2";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(12, 236);
            button12.Name = "button12";
            button12.Size = new Size(67, 66);
            button12.TabIndex = 25;
            button12.Text = "3";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
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
            // button15
            // 
            button15.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button15.Location = new Point(85, 308);
            button15.Name = "button15";
            button15.Size = new Size(67, 66);
            button15.TabIndex = 30;
            button15.Text = ",";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button16.Location = new Point(12, 308);
            button16.Name = "button16";
            button16.Size = new Size(67, 66);
            button16.TabIndex = 29;
            button16.Text = "0";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 450);
            Controls.Add(calc);
            Controls.Add(add);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(substract);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(mult);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(div);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(clear);
            Controls.Add(button1);
            Controls.Add(totalDisplay);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox totalDisplay;
        private Button button1;
        private Button clear;
        private Button button2;
        private Button button3;
        private Button div;
        private Button mult;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button substract;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button calc;
        private Button add;
        private Button button15;
        private Button button16;
    }
}