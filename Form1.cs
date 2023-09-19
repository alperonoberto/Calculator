namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int result;
        double resultDouble;
        int num1;
        int num2;
        double num1Double = 0;
        double num2Double = 0;
        string operation = "";

        private void button1_Click(object sender, EventArgs e)
        {
            totalDisplay.Text += btn7.Text;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            totalDisplay.Text += btn8.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            totalDisplay.Text += btn9.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            totalDisplay.Text = string.Empty;
            num1 = 0;
            num2 = 0;
            num1Double = 0;
            num2Double = 0;
            result = 0;
            resultDouble = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            totalDisplay.Text += btn6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            totalDisplay.Text += btn5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            totalDisplay.Text += btn4.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            totalDisplay.Text += btn3.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            totalDisplay.Text += btn2.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            totalDisplay.Text += btn1.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (totalDisplay.Text == "" || !(totalDisplay.Text.StartsWith("0") && totalDisplay.Text.Length > 0))
            {
                totalDisplay.Text += btn0.Text;
            }
            else { return; }

            return;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (totalDisplay.Text != "")
            {
                if (!totalDisplay.Text.Contains(","))
                {
                    totalDisplay.Text = $"{totalDisplay.Text},";
                }

                return;
            }

            return;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (totalDisplay.Text != "")
            {
                if (totalDisplay.Text.Contains(","))
                {
                    num1Double = Convert.ToDouble(totalDisplay.Text);
                    totalDisplay.Text = String.Empty;
                    operation = mult.Text;
                    return;
                }
                num1 = int.Parse(totalDisplay.Text);
                totalDisplay.Text = String.Empty;
                operation = mult.Text;
            }

            return;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (totalDisplay.Text != "")
            {
                if (num1Double != 0)
                {
                    totalDisplay.Text.Replace(".", ",");
                    num2Double = double.Parse(totalDisplay.Text);
                    totalDisplay.Text = String.Empty;

                    switch (operation)
                    {
                        case "/":
                            resultDouble = num1Double / num2Double;
                            break;
                        case "*":
                            resultDouble = num1Double * num2Double;
                            break;
                        case "+":
                            resultDouble = num1Double + num2Double;
                            break;
                        case "-":
                            resultDouble = num1Double - num2Double;
                            break;
                    }

                    totalDisplay.Text = Math.Round(resultDouble, 3).ToString();

                    return;
                }
                if (num1 != 0)
                {
                    num2 = int.Parse(totalDisplay.Text);

                    switch (operation)
                    {
                        case "/":
                            resultDouble = (double)num1 / num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                    }

                    totalDisplay.Text = operation == "/" ? Math.Round(resultDouble, 3).ToString() : result.ToString();
                    //totalDisplay.Text = result.ToString();
                }

            }

            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (totalDisplay.Text != "")
            {
                if (totalDisplay.Text.Contains(","))
                {
                    num1Double = Convert.ToDouble(totalDisplay.Text);
                    totalDisplay.Text = String.Empty;
                    operation = div.Text;
                    return;
                }
                num1 = int.Parse(totalDisplay.Text);
                totalDisplay.Text = String.Empty;
                operation = div.Text;
            }

            return;
        }

        private void substract_Click(object sender, EventArgs e)
        {
            if (totalDisplay.Text != "")
            {
                if (totalDisplay.Text.Contains(","))
                {
                    num1Double = Convert.ToDouble(totalDisplay.Text);
                    totalDisplay.Text = String.Empty;
                    operation = substract.Text;
                    return;
                }
                num1 = int.Parse(totalDisplay.Text);
                totalDisplay.Text = String.Empty;
                operation = substract.Text;
            }
            else if (!totalDisplay.Text.Contains("-"))
            {
                totalDisplay.Text = "-";
            }

            return;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (totalDisplay.Text != "")
            {
                if (totalDisplay.Text.Contains(","))
                {
                    num1Double = Convert.ToDouble(totalDisplay.Text);
                    totalDisplay.Text = String.Empty;
                    operation = add.Text;
                    return;
                }
                num1 = int.Parse(totalDisplay.Text);
                totalDisplay.Text = String.Empty;
                operation = add.Text;
            }

            return;
        }
    }
}