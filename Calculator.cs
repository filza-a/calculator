using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        char symbol = ' ';
        //String text = null;

        

        static String calculate(string txt, char s)
        {

            int num1 = Int16.Parse(txt.Substring(0,txt.IndexOf(s)));
            Console.WriteLine(num1);
            Console.WriteLine(txt.IndexOf(s));
            Console.WriteLine(txt.Length);
            int num2 = Int16.Parse(txt.Substring(txt.IndexOf(s) + 1, txt.Length - (txt.IndexOf(s) + 1) ));
            
            int result = 0;

            switch (s)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        return "Division by Zero Error!";
                    break;

            }

            return result.ToString();
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "3";
        }

       
        private void four_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "6";

        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "7";

        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "8";

        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "9";

        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "0";

        }

        private void dot_Click(object sender, EventArgs e)
        {
            this.textBox.Text += ".";

        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox.Text = this.textBox.Text.Substring(0, this.textBox.Text.Length - 1);
        }

        private void allClear_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";

        }

        private void multiply_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "*";
            symbol = '*';

        }

        private void divide_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "/";
            symbol = '/';

        }

        private void minus_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "-";
            symbol = '-';

        }

        private void plus_Click(object sender, EventArgs e)
        {
            this.textBox.Text += "+";
            symbol = '+';

        }

        private void equals_Click(object sender, EventArgs e)
        {

            this.textBox.Text = calculate(this.textBox.Text, symbol);
        }
    }
}
