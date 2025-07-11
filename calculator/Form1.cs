using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace calculator
{
    public partial class Form1 : Form
    {
        double c = 0;
        char sign;
        bool lockflag = false;
        double[] inOut = new double[3];

        int operation;
        public Form1()
        {
            InitializeComponent();
        }
        

        //check operation being done
        private double evaluateOperation(int mode)
        {

            switch (mode)
            {
                case 1: //plus

                    //d = a + b;

                    Display1.Text = Convert.ToString(c = inOut[0] + inOut[1]);
                    inOut[2] = c;
                    return c;

                case 2: //minus

                    //d = a - b;
                    Display1.Text = Convert.ToString(c = inOut[0] - inOut[1]);
                    inOut[2] = c;
                    return c;

                case 3: //mult

                    //d = a * b;
                    Display1.Text = Convert.ToString(c = inOut[0] * inOut[1]);
                    inOut[2] = c;
                    return c;

                case 4: //div

                    //d = a / b;
                    if (inOut[1] != 0)
                    {
                        Display1.Text = Convert.ToString(c = inOut[0] / inOut[1]);
                        inOut[2] = c;
                    }
                    else
                    {
                        c = 0;
                        Display1.Text = "Error: Division by Zero";
                    }
                        return c;

                default: //would never happen
                    c = 0;
                    return c;


            }

        }
        //prevents unwanted input in the message box 
        public string inputLock(string s, string input)
        {
            if (!lockflag)
            {
                if (Display1.Text == "0" && Display1.Text != null)
                {
                    s = input;
                }
                else
                {
                    s += input;
                }
            }
            return s;
        }
        public void equality()
        {
            if (!lockflag)
            {
                if (!(double.TryParse(Display1.Text, out double num)))
                {
                    inOut[1] = inOut[0];
                }
                else
                {
                    inOut[1] = Convert.ToDouble(Display1.Text);
                }
            }
            //inOut[1] = b;
            Display2.Text = $"{inOut[0]} {sign} {inOut[1]} = ";





            /*if ((double.TryParse(Display1.Text, out double result)))
            {
                b = result;
                

            }*/

            if (lockflag)
            {
                inOut[2] = evaluateOperation(operation);
            }
            else
            {
                inOut[2] = evaluateOperation(operation);
            }

            if (Display1.Text == "NaN")
            {
                Display1.Text = "output is not a number.";
            }
            (inOut[0], inOut[2]) = (inOut[2], inOut[0]);
            inOut[2] = 0;

            lockflag = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lockflag)
            {
                Display1.Text = "";
                Display2.Text = "";
                inOut[0] = 0;
                inOut[1] = 0;
                inOut[2] = 0;
                lockflag = false;
            }
            Display1.Text = inputLock(Display1.Text, "1");
            button_eq.Focus();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (lockflag)
            {
                Display1.Text = "";
                Display2.Text = "";
                inOut[0] = 0;
                inOut[1] = 0;
                inOut[2] = 0;
                lockflag = false;
            }
            Display1.Text = inputLock(Display1.Text, "2");
            button_eq.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lockflag)
            {
                Display1.Text = "";
                Display2.Text = "";
                inOut[0] = 0;
                inOut[1] = 0;
                inOut[2] = 0;
                lockflag = false;
            }
            Display1.Text = inputLock(Display1.Text, "3");
            button_eq.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lockflag)
            {
                Display1.Text = "";
                Display2.Text = "";
                inOut[0] = 0;
                inOut[1] = 0;
                inOut[2] = 0;
                lockflag = false;
            }
            Display1.Text = inputLock(Display1.Text, "4");
            button_eq.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lockflag)
            {
                Display1.Text = "";
                Display2.Text = "";
                inOut[0] = 0;
                inOut[1] = 0;
                inOut[2] = 0;
                lockflag = false;
            }
            Display1.Text = inputLock(Display1.Text, "5");
            button_eq.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lockflag)
            {
                Display1.Text = "";
                Display2.Text = "";
                inOut[0] = 0;
                inOut[1] = 0;
                inOut[2] = 0;
                lockflag = false;
            }
            Display1.Text = inputLock(Display1.Text, "6");
            button_eq.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lockflag)
            {
                Display1.Text = "";
                Display2.Text = "";
                inOut[0] = 0;
                inOut[1] = 0;
                inOut[2] = 0;
                lockflag = false;
            }
            Display1.Text = inputLock(Display1.Text, "7");
            button_eq.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (lockflag)
            {
                Display1.Text = "";
                Display2.Text = "";
                inOut[0] = 0;
                inOut[1] = 0;
                inOut[2] = 0;
                lockflag = false;
            }
            Display1.Text = inputLock(Display1.Text, "8");
            button_eq.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lockflag)
            {
                Display1.Text = "";
                Display2.Text = "";
                inOut[0] = 0;
                inOut[1] = 0;
                inOut[2] = 0;
                lockflag = false;
            }
            Display1.Text = inputLock(Display1.Text, "9");
            button_eq.Focus();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Display1.Text = inputLock(Display1.Text, "0");
            button_eq.Focus();
        }

        private void button_posneg_Click(object sender, EventArgs e)
        {
            if (!(Display1.Text.Contains("-")))
            {
                Display1.Text = $"-{Display1.Text}";
            }
            else
            {
                Display1.Text = Display1.Text.Replace("-", "");
            }
            button_eq.Focus();
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            if (!Display1.Text.Contains("."))
            {
                Display1.Text = inputLock(Display1.Text, ".");
            }
            button_eq.Focus();
        }

        private void button_clr_Click(object sender, EventArgs e)
        {
            Display1.Text = "";
            Display2.Text = "";
            inOut[0] = 0;
            inOut[1] = 0;
            inOut[2] = 0;
            lockflag = false;
            button_eq.Focus();
        }

        private void button_clrentry_Click(object sender, EventArgs e)
        {
            Display1.Text = "";
            inOut[0] = 0;
            lockflag = false;
            button_eq.Focus();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {

            equality();


            if (double.TryParse(Display1.Text, out double value))
            {
                inOut[0] = value;
                Display1.Text += " + ";
                sign = '+';
                Display2.Text = Display1.Text;
                Display1.Text = "";
                operation = 1;
                lockflag = false;
            }
            button_eq.Focus();
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            equality();

            if (double.TryParse(Display1.Text, out double value))
            {
                inOut[0] = value;
                Display1.Text += " - ";
                sign = '-';
                Display2.Text = Display1.Text;
                Display1.Text = "";
                operation = 2;
                lockflag = false;
            }
            button_eq.Focus();
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            equality();

            if (double.TryParse(Display1.Text, out double value))
            {
                inOut[0] = value;
                Display1.Text += " * ";
                sign = '*';
                Display2.Text = Display1.Text;
                Display1.Text = "";
                operation = 3;
                lockflag = false;
            }
            button_eq.Focus();
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            equality();

            if (double.TryParse(Display1.Text, out double value))
            {
                inOut[0] = value;
                Display1.Text += " / ";
                sign = '/';
                Display2.Text = Display1.Text;
                Display1.Text = "";
                operation = 4;
                lockflag = false;
            }
            button_eq.Focus();
        }

        private void button_recip_Click(object sender, EventArgs e)
        {

            if (double.TryParse(Display1.Text, out double value))
            {
                Display1.Text = Convert.ToString(inOut[0] = 1 / value);
                Display2.Text = $"1 / {value} ";
            }

            lockflag = true;
            button_eq.Focus();
        }

        private void button_square_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Display1.Text, out double value))
            {
                Display1.Text = Convert.ToString(inOut[0] = value * value);
                Display2.Text = $"{value}^2 =";
            }

            button_eq.Focus();
            lockflag = true;
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(Display1.Text, out double value)))
            {
                if (value < 0)
                {
                    Display1.Text = "Invalid input, please clear";
                }
                else
                {
                    Display1.Text = Convert.ToString(inOut[0] = Math.Sqrt(value));
                    Display2.Text = $"sqrt({value}) =";
                }
                lockflag = true;
            }
            button_eq.Focus();
        }

        private void button_eq_Click(object sender, EventArgs e)
        {
            equality();
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e) //keyboard compatibility
        {
            switch (e.KeyChar)
            {
                case '1':
                    button1.PerformClick(); break;

                case '2':
                    button2.PerformClick(); break;

                case '3':
                    button3.PerformClick(); break;

                case '4':
                    button4.PerformClick(); break;

                case '5':
                    button5.PerformClick(); break;

                case '6':
                    button6.PerformClick(); break;

                case '7':
                    button7.PerformClick(); break;

                case '8':
                    button8.PerformClick(); break;

                case '9':
                    button9.PerformClick(); break;

                case '0':
                    button0.PerformClick(); break;

                case '.':
                    button_dot.PerformClick(); break;

                case '+':
                    button_plus.PerformClick(); break;

                case '-':
                    button_minus.PerformClick(); break;

                case '*':
                    button_mult.PerformClick(); break;

                case '/':
                    button_div.PerformClick(); break;

                case (char)13: //enter
                    button_eq.PerformClick(); break;

                case (char)27: //escape
                    button_clr.PerformClick(); break;

                case (char)127: //delete
                    button_clrentry.PerformClick(); break;
            }
        }


    }
}
