using System.CodeDom.Compiler;
using System.Linq.Expressions;

namespace calculator
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        bool lockflag;

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
                    Display1.Text = Convert.ToString(a + b);
                    return true;

                case 2: //minus
                    if (!lockflag)
                    {
                        Display1.Text = Convert.ToString(a - b);
                    }
                    else //accounting for the swap in variables during eq event
                    {
                        Display1.Text = Convert.ToString(b - a);
                    }
                    return true;

                case 3: //mult
                    Display1.Text = Convert.ToString(a * b);
                    return true;

                case 4: //div
                    if (!lockflag)
                    {
                        Display1.Text = Convert.ToString(a / b);
                    }
                    else //account for variable swap
                    {
                        Display1.Text = Convert.ToString(b / a);
                    }
                    return true;

                default:
                    return false;


            }
        }
        //prevents unwanted input in the message box 
        public string inputLock(string s, string input)
        {
            if (!lockflag)
            {
                s += input;
            }
            return s;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Display1.Text = inputLock(Display1.Text, "1");
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Display1.Text = inputLock(Display1.Text, "2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display1.Text = inputLock(Display1.Text, "3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display1.Text = inputLock(Display1.Text, "4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display1.Text = inputLock(Display1.Text, "5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display1.Text = inputLock(Display1.Text, "6"); ;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Display1.Text = inputLock(Display1.Text, "7"); ;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Display1.Text = inputLock(Display1.Text, "8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Display1.Text = inputLock(Display1.Text, "9"); ;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Display1.Text = inputLock(Display1.Text, "0"); ;
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
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            if (!Display1.Text.Contains("."))
            {
                Display1.Text = inputLock(Display1.Text, ".");
            }

        }

        private void button_clr_Click(object sender, EventArgs e)
        {
            Display1.Text = "0";
            Display2.Text = "";
            a = 0;
            b = 0;
            lockflag = false;
        }

        private void button_clrentry_Click(object sender, EventArgs e)
        {
            Display1.Text = "";
            b = 0;
            lockflag = false;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Display1.Text, out double value))
            {
                a = Convert.ToDouble(Display1.Text);
                Display1.Text += " + ";
                Display2.Text = Display1.Text;
                Display1.Text = "";
                operation = 1;
                lockflag = false;
            }

        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Display1.Text, out double value))
            {
                a = Convert.ToDouble(Display1.Text);
                Display1.Text += " - ";
                Display2.Text = Display1.Text;
                Display1.Text = "";
                operation = 2;
                lockflag = false;
            }
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Display1.Text, out double value))
            {
                a = Convert.ToDouble(Display1.Text);
                Display1.Text += " * ";
                Display2.Text = Display1.Text;
                Display1.Text = "";
                operation = 3;
                lockflag = false;
            }
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Display1.Text, out double value))
            {
                a = Convert.ToDouble(Display1.Text);
                Display1.Text += " / ";
                Display2.Text = Display1.Text;
                Display1.Text = "";
                operation = 4;
                lockflag = false;
            }
        }

        private void button_recip_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Display1.Text, out double value))
            {
                a = Convert.ToDouble(Display1.Text);
                Display1.Text = Convert.ToString(1 / a);
                Display2.Text = $"1 / {a} =";
                lockflag = true;
            }
        }

        private void button_square_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Display1.Text, out double value))
            {
                a = Convert.ToDouble(Display1.Text);
                Display1.Text = Convert.ToString(a * a);
                Display2.Text = $"{a}^2 =";
                lockflag = true;
            }
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            if (a < 0 || double.TryParse(Display1.Text, out double value) == false)
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

        private void button_eq_Click(object sender, EventArgs e)
        {
            Display2.Text = Display2.Text.Replace(Convert.ToString(b), Display1.Text);
            if ((double.TryParse(Display1.Text, out double result)))
            {
                b = Convert.ToDouble(Display1.Text);

            }

            double temp = a;

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

        private void Form1_KeyDown(object sender, KeyEventArgs e) //numpad compatibility
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    button1.PerformClick(); break;

                case Keys.NumPad2:
                    button2.PerformClick(); break;

                case Keys.NumPad3:
                    button3.PerformClick(); break;

                case Keys.NumPad4:
                    button4.PerformClick(); break;

                case Keys.NumPad5:
                    button5.PerformClick(); break;

                case Keys.NumPad6:
                    button6.PerformClick(); break;

                case Keys.NumPad7:
                    button7.PerformClick(); break;

                case Keys.NumPad8:
                    button8.PerformClick(); break;

                case Keys.NumPad9:
                    button9.PerformClick(); break;

                case Keys.NumPad0:
                    button0.PerformClick(); break;

                case Keys.Decimal:
                    button_dot.PerformClick(); break;

                case Keys.Add:
                    button_plus.PerformClick(); break;

                case Keys.Subtract:
                    button_minus.PerformClick(); break;

                case Keys.Multiply:
                    button_mult.PerformClick(); break;

                case Keys.Divide:
                    button_div.PerformClick(); break;

                case Keys.Enter:
                    button_eq.PerformClick(); break;

                case Keys.Escape:
                    button_clr.PerformClick(); break;

                case Keys.Delete:
                    button_clrentry.PerformClick(); break;
            }
        }
    }
}
