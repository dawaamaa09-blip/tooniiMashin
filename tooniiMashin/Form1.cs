using System.Security.Cryptography;

namespace tooniiMashin
{
    public partial class Form1 : Form
    {
        bool newNumber = false;
        double firstNumber = 0;
        string operation = "";
        double memory = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                textBox1.Text = "";
                newNumber = false;
            }

            textBox1.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                textBox1.Text = "";
                newNumber = false;
            }
            textBox1.Text += "1";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (newNumber)
            {
                textBox1.Text = "";
                newNumber = false;
            }
            textBox1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                textBox1.Text = "";
                newNumber = false;
            }
            textBox1.Text += "3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                textBox1.Text = "";
                newNumber = false;
            }
            textBox1.Text += "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (newNumber)
            {
                textBox1.Text = "";
                newNumber = false;
            }
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                textBox1.Text = "";
                newNumber = false;
            }
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                textBox1.Text = "";
                newNumber = false;
            }
            textBox1.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                textBox1.Text = "";
                newNumber = false;
            }
            textBox1.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                textBox1.Text = "";
                newNumber = false;
            }
            textBox1.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (newNumber)
            {
                textBox1.Text = "";
                newNumber = false;
            }

            if (!textBox1.Text.Contains("."))
            {
                if (textBox1.Text == "")
                    textBox1.Text = "0.";

                else
                    textBox1.Text += ".";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            operation = "+";
            newNumber = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            operation = "-";
            newNumber = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            operation = "*";
            newNumber = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            operation = "/";
            newNumber = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {

            double secondNumber;
            double result = 0;

            if (!double.TryParse(textBox1.Text, out secondNumber))
                return;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    break;

                case "*":
                    result = firstNumber * secondNumber;
                    break;

                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("0-д хувааж болохгүй!");
                        return;
                    }
                    result = firstNumber / secondNumber;
                    break;

                default:
                    return;
            }

            textBox1.Text = result.ToString();
            newNumber = true;
            operation = "";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            firstNumber = 0;
            operation = "";
            newNumber = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            newNumber = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
            {
                textBox1.Text =
                    textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);

            if (number < 0)
            {
                MessageBox.Show("Сөрөг тооноос язгуур гаргах боломжгүй!");
                return;
            }

            textBox1.Text = Math.Sqrt(number).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);

            if (operation == "+" || operation == "-")
                number = firstNumber * number / 100;
            else
                number = number / 100;

            textBox1.Text = number.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);

            if (number == 0)
            {
                MessageBox.Show("0-д хувааж болохгүй!");
                return;
            }

            textBox1.Text = (1 / number).ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);

            textBox1.Text = (-number).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory.ToString();
            newNumber = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            memory = double.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            memory += double.Parse(textBox1.Text);
        }
    }
}
