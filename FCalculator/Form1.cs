namespace FCalculator
{
    public partial class Form1 : Form
    {
        string FirstNum = "";
        string SecondNum = "";
        char Operation = '+';
        bool IsFirst = true;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button12_Click(object sender, EventArgs e) // ›“Œ =
        {
            IsFirst = true;
            double Result = 0;
            switch (Operation)
            {
                case '+':
                    Result = Convert.ToDouble(FirstNum) + Convert.ToDouble(SecondNum); break;
                case '-':
                    Result = Convert.ToDouble(FirstNum) - Convert.ToDouble(SecondNum); break;
                case '*':
                    Result = Convert.ToDouble(FirstNum) * Convert.ToDouble(SecondNum); break;
                case '/':
                    Result = Convert.ToDouble(FirstNum) / Convert.ToDouble(SecondNum); break;

                default:
                    break;
            }
            richTextBox1.Text = Result.ToString();
        }

        private void button15_Click(object sender, EventArgs e) // ›“Œ + 
        {
            Operation = '+';
            IsFirst = false;
            richTextBox1.Text += "+";
        }
        private void button16_Click(object sender, EventArgs e) // ›“Œ -
        {
            Operation = '-';
            IsFirst = false;
            richTextBox1.Text += "-";
        }

        private void button14_Click(object sender, EventArgs e) // ›“Œ *
        {
            Operation = '*';
            IsFirst = false;
            richTextBox1.Text += "*";
        }

        private void button13_Click(object sender, EventArgs e) // ›“Œ /
        {
            Operation = '/';
            IsFirst = false;
            richTextBox1.Text += "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsFirst)
            {
                FirstNum += "1";
                richTextBox1.Text = FirstNum;
            }
            else
            {
                SecondNum += "1";
                richTextBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsFirst)
            {
                FirstNum += "2";
                richTextBox1.Text = FirstNum;
            }
            else
            {
                SecondNum += "2";
                richTextBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsFirst)
            {
                FirstNum += "3";
                richTextBox1.Text = FirstNum;
            }
            else
            {
                SecondNum += "3";
                richTextBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (IsFirst)
            {
                FirstNum += "4";
                richTextBox1.Text = FirstNum;
            }
            else
            {
                SecondNum += "4";
                richTextBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (IsFirst)
            {
                FirstNum += "5";
                richTextBox1.Text = FirstNum;
            }
            else
            {
                SecondNum += "5";
                richTextBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (IsFirst)
            {
                FirstNum += "6";
                richTextBox1.Text = FirstNum;
            }
            else
            {
                SecondNum += "6";
                richTextBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (IsFirst)
            {
                FirstNum += "7";
                richTextBox1.Text = FirstNum;
            }
            else
            {
                SecondNum += "7";
                richTextBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (IsFirst)
            {
                FirstNum += "8";
                richTextBox1.Text = FirstNum;
            }
            else
            {
                SecondNum += "8";
                richTextBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (IsFirst)
            {
                FirstNum += "9";
                richTextBox1.Text = FirstNum;
            }
            else
            {
                SecondNum += "9";
                richTextBox1.Text += "9";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (IsFirst)
            {
                FirstNum += "0";
                richTextBox1.Text = FirstNum;
            }
            else
            {
                SecondNum += "0";
                richTextBox1.Text += "0";
            }
        }

        private void button18_Click(object sender, EventArgs e)// ›ÚÓ —
        {
            richTextBox1.Text = "0";
            IsFirst = true;
            FirstNum = "";
            SecondNum = "";
        }

        private void button11_Click(object sender, EventArgs e) // ›“Œ .
        {
            if (IsFirst)
            {
                FirstNum += ",";
                richTextBox1.Text = FirstNum;
            }
            else
            {
                SecondNum += ",";
                richTextBox1.Text = SecondNum;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            if (IsFirst)
            {
                if (FirstNum.Length == 0) return;
                FirstNum = FirstNum.Substring(0, FirstNum.Length - 1);
                richTextBox1.Text = FirstNum;

            }
            else
            {
                if (SecondNum.Length == 0) return;
                SecondNum = SecondNum.Substring(0, SecondNum.Length - 1);
                richTextBox1.Text = SecondNum;
            }
        }

        
    }
}
