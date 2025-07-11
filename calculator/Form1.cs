using System.CodeDom.Compiler;
using System.Linq.Expressions;

namespace calculator
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        double c = 0;
        bool lockflag = false;

        int operation;
        public Form1()
        {
            InitializeComponent();
        }



        //check operation being done
        private bool evaluateOperation(int mode)
        {

            switch (mode)
            {
                case 1: //plus
                    //d = a + b;
                    Display2.Text += Display1.Text;
                    Display1.Text = Convert.ToString(a + b);
                    return true;

                case 2: //minus
                    if (!lockflag)
                    {
                        //d = a - b;
                        Display1.Text = Convert.ToString(a - b);
                    }
                    else //accounting for the swap in variables during eq event
                    {
                        //d = b - a;
                        Display1.Text = Convert.ToString(b - a);
                    }
                    return true;

                case 3: //mult
                    //d = a * b;
                    Display1.Text = Convert.ToString(a * b);
                    return true;

                case 4: //div
                    if (!lockflag)
                    {
                        //d = a / b;
                        Display1.Text = Convert.ToString(a / b);
                    }
                    else //account for variable swap
                    {
                        //d = b / a;
                        Display1.Text = Convert.ToString(b / a);
                    }
                    return true;

                default:
                    //d = 0;
                    return false;


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
            Display2.Text = Display2.Text.Replace(Convert.ToString(b), Display1.Text);
            try
            {
                b = Convert.ToDouble(Display1.Text);
            }
            catch (Exception e) 
            {
                Display1.Text += e.Message;
            }

            double temp = a;

            if ((double.TryParse(Display1.Text, out double result)))
            {
                b = Convert.ToDouble(Display1.Text);

            }

            if (lockflag)
            {
                evaluateOperation(operation);
            }
            else
            {
                Display2.Text = $"{Display2.Text}{Display1.Text} = ";
                evaluateOperation(operation);
                a = b;
                b = temp;
            }

            lockflag = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lockflag)
            {
                Display1.Text = "";
                Display2.Text = "";
                a = 0;
                b = 0;
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
                a = 0;
                b = 0;
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
                a = 0;
                b = 0;
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
                a = 0;
                b = 0;
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
                a = 0;
                b = 0;
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
                a = 0;
                b = 0;
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
                a = 0;
                b = 0;
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
                a = 0;
                b = 0;
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
                a = 0;
                b = 0;
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
            a = 0;
            b = 0;
            lockflag = false;
            button_eq.Focus();
        }

        private void button_clrentry_Click(object sender, EventArgs e)
        {
            Display1.Text = "";
            b = 0;
            lockflag = false;
            button_eq.Focus();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {

            equality();


            if (double.TryParse(Display1.Text, out double value))
            {
                a = Convert.ToDouble(Display1.Text);
                Display1.Text += " + ";
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
                a = Convert.ToDouble(Display1.Text);
                Display1.Text += " - ";
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
                a = Convert.ToDouble(Display1.Text);
                Display1.Text += " * ";
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
                a = Convert.ToDouble(Display1.Text);
                Display1.Text += " / ";
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
                a = Convert.ToDouble(Display1.Text);
                Display1.Text = Convert.ToString(1 / a);
                Display2.Text = $"1 / {a} ";
            }

            lockflag = true;
            button_eq.Focus();
        }

        private void button_square_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Display1.Text, out double value))
            {
                a = Convert.ToDouble(Display1.Text);
                Display1.Text = Convert.ToString(a * a);
                Display2.Text = $"{a}^2 =";
            }

            button_eq.Focus();
            lockflag = true;
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(Display1.Text, out double value)))
            {
                if (a < 0)
                {
                    Display1.Text = "Invalid input, please clear";
                }
                else
                {
                    a = Convert.ToDouble(Display1.Text);
                    Display1.Text = Convert.ToString(Math.Sqrt(a));
                    Display2.Text = $"sqrt({a}) =";
                }
                lockflag = true;
            }
            button_eq.Focus();
        }

        private void button_eq_Click(object sender, EventArgs e)
        {

            Display2.Text += Display2.Text.Replace(Convert.ToString(b), Display1.Text);
            b = Convert.ToDouble(Display1.Text);

            double temp = a;
            //equality();
            if ((double.TryParse(Display1.Text, out double result)))
            {
                b = result;

            }

            if (lockflag)
            {
                evaluateOperation(operation);
                //Display1.Text = Convert.ToString(d);
            }
            else
            {
                Display2.Text = $"{Display2.Text}{Display1.Text} = ";
                evaluateOperation(operation);
                a = b;
                c = a;
                b = temp;
                //Display1.Text = Convert.ToString(d);
            }

            lockflag = true;
            button_eq.Focus();
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
