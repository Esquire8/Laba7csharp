using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            Laba6 zadanie1 = new Laba6();
            result = zadanie1.FindMax(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox3.Text = Convert.ToString(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(textBox4.Text);
            int second = Convert.ToInt32(textBox5.Text);
            Laba6 zadanie2 = new Laba6();
            zadanie2.Swap(ref first, ref second);
            textBox6.Text = Convert.ToString(first);
            textBox7.Text = Convert.ToString(second);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(tB3_1.Text);
            int result;
            Laba6 zadanie3 = new Laba6();
            bool overflow = zadanie3.Factorial1(number, out result);
            label9.Text = $"Переполнение: {Convert.ToString(overflow)}";
            label10.Text = $"Значение: { Convert.ToString(result)}";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tB4_1.Text);
            Laba6 zadanie4 = new Laba6();
            tB4_2.Text = Convert.ToString(zadanie4.Factorial(a));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tB5_1.Text);
            int b = Convert.ToInt32(tB5_2.Text);
            Laba6 zadanie5 = new Laba6();
            labelNOD.Text = Convert.ToString(zadanie5.NOD(a, b));

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tB5_3.Text);
            int b = Convert.ToInt32(tB5_4.Text);
            int c = Convert.ToInt32(tB5_5.Text);
            Laba6 zadanie5 = new Laba6();
            labelNOD2.Text = Convert.ToString(zadanie5.NOD(a, b, c));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tB6_1.Text);
            labeln.Text = Convert.ToString(n);
            Laba6 zadanie6 = new Laba6();
            labelFib.Text = Convert.ToString(zadanie6.Fib(n));
        }
    }
    class Laba6
    {
        public int FindMax(int first, int second)
        {
            int result;
            if (first > second)
            {
                result = first;
            }
            else
            {
                result = second;
            }
            return result;
        }

        public void Swap (ref int firts, ref int second)
        {
            int a = firts;
            firts = second;
            second = a;
        }
        public bool Factorial1 (int number, out int result)
        {
            result = 1;
            try
            {
                for (int i = 1; i <= number; i++)
                {
                    checked
                    {
                        result *= i;
                    }
                }
            }
            catch (OverflowException)
            {
                return false;
            }
            return true;
        } 
        public int Factorial(int a)
        {
            if (a == 0)
            {
                return 1;
            }
            return a * Factorial(a - 1);
            
        }

        public int NOD(int first, int second)
        {
            if (first == 0 || second == 0)
            {
                return first + second;
            }
            if (first > second)
            {
                return NOD(first - second, second);
            }
            else
            {
                return NOD(second - first, first);
            }
        }
        public int NOD(int first, int second, int third)
        {
            return NOD(NOD(first, second),third);
        }
        public int Fibonachi(int f1, int f2, int n)
        {
            return n == 0 ? f1 : Fibonachi(f2, f1 + f2, n - 1);
        }
        public int Fib(int n)
        {
            return Fibonachi(0, 1, n);
        }
    }
}
