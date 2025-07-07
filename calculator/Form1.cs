using System.Linq.Expressions;

namespace calculator
{
    public partial class Form1 : Form
    {
        double a, b;
        bool lockflag;

        int operation;

        public Form1()
        {
            InitializeComponent();
        }


        //check operation being done
        public bool evaluateOperation(int mode)
        {

            switch (mode)
            {
                case 1: //plus
                    Display1.Text = Convert.ToString(a + b);
                    return true;


                case 2: //minus
                    Display1.Text = Convert.ToString(a - b);
                    return true;

                case 3: //mult
                    Display1.Text = Convert.ToString(a * b);
                    return true;

                case 4: //div
                    Display1.Text = Convert.ToString(a / b);
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
            /*if (!lockflag)
            {
                Display1.Text += "1";
            }*/
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
                Display1.Text += ".";
            }

        }

        private void button_clr_Click(object sender, EventArgs e)
        {
            Display1.Text = "";
            Display2.Text = "";
            a = 0;
            b = 0;
        }

        private void button_clrentry_Click(object sender, EventArgs e)
        {
            Display1.Text = "";
            b = 0;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Display1.Text);
            Display1.Text += " + ";
            Display2.Text = Display1.Text;
            Display1.Text = "";
            operation = 1;

        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Display1.Text);
            Display1.Text += " - ";
            Display2.Text = Display1.Text;
            Display1.Text = "";
            operation = 2;
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Display1.Text);
            Display1.Text += " * ";
            Display2.Text = Display1.Text;
            Display1.Text = "";
            operation = 3;
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Display1.Text);
            Display1.Text += " / ";
            Display2.Text = Display1.Text;
            Display1.Text = "";
            operation = 4;
        }

        private void button_recip_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Display1.Text);
            Display1.Text = Convert.ToString(1 / a);
        }

        private void button_square_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Display1.Text);
            Display1.Text = Convert.ToString(a * a);
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Display1.Text);
            Display1.Text = Convert.ToString(Math.Sqrt(a));
        }

        private void button_eq_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(Display1.Text);
            Display2.Text = $" {a} + {b} =";
            evaluateOperation(operation);
            lockflag = true;

        }

        private void Display1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
