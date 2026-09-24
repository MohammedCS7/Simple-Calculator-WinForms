using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SImple_Calculator
{
    public partial class Form1 : Form
    {

        double Number1 = 0;
        double Number2 = 0;

        double Result = 0;
        int ResRepeat = 0;

        enum Operation
        {
            Add,Substract,Multiply,Divide,None,Equal
        }

        Operation Op = Operation.None;
        Operation prevOp = Operation.None;

        static double GetResult(double num1, double num2, Operation op)
        {
            switch (op)
            {
                case Operation.Add:
                    return num1 + num2;
                case Operation.Substract:
                    return num1 - num2;
                case Operation.Multiply:
                    return num1 * num2;
                case Operation.Divide:
                    return Convert.ToDouble(num1 / num2);
            }
            return 0;
        }

        static String GetOperator(Operation op)
        {
            String[] ops = { "+", "-", "x", "÷" };
            return ops[((int)op)];
        }

        public Form1()
        {
            InitializeComponent();
            this.label1.Text = null;
            this.label2.Text = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Op == Operation.Equal)
            {
                button16_Click(sender, e);
                label2.Text = 1.ToString();
            }
            else
                label2.Text += 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Op == Operation.Equal)
            {
                button16_Click(sender, e);
                label2.Text = 2.ToString();
            }
            else
                label2.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Op == Operation.Equal)
            {
                button16_Click(sender, e);
                label2.Text = 3.ToString();
            }
            else
                label2.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Op == Operation.Equal)
            {
                button16_Click(sender, e);
                label2.Text = 4.ToString();
            }
            else
                label2.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Op == Operation.Equal)
            {
                button16_Click(sender, e);
                label2.Text = 5.ToString();
            }
            else
                label2.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Op == Operation.Equal)
            {
                button16_Click(sender, e);
                label2.Text = 6.ToString();
            }
            else
                label2.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Op == Operation.Equal)
            {
                button16_Click(sender, e);
                label2.Text = 7.ToString();
            }
            else
                label2.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Op == Operation.Equal)
            {
                button16_Click(sender, e);
                label2.Text = 8.ToString();
            }
            else
                label2.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Op == Operation.Equal)
            {
                button16_Click(sender,e);
                label2.Text = 9.ToString();
            }
            else
                label2.Text += 9;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bool Success;
            if (Op != Operation.None)
            {
                Success = double.TryParse(label2.Text, out double temp);
                if (Success)
                    Number1 = GetResult(Number1, temp, Op);
                else
                {
                    Op = Operation.Add;
                    label1.Text = Number1 + GetOperator(Operation.Add);
                    return;
                }
                Op = Operation.Add;
            }
            else
            {
                Op = Operation.Add;
                Success = double.TryParse(label2.Text, out Number1);
            }
            if (Success)
            {
                label1.Text = label2.Text + GetOperator(Operation.Add);
                label2.Text = null;
            }
            ResRepeat = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bool Success;
            if (Op != Operation.None && Op != Operation.Equal)
                prevOp = Op;
            Success = double.TryParse(label2.Text, out double temp);
            if (ResRepeat >= 1 && Result == temp)
            {
                Success = double.TryParse(label2.Text, out Number1);
                ResRepeat++;
            }
            if (Success)
            {
                label1.Text = null;
                if (Result == temp && ResRepeat == 0)
                {
                    if (Op != Operation.Substract)
                    {

                    }
                    else
                    {
                        Number2 = Number1;
                    }
                    Number1 = Result;
                    ResRepeat++;
                }
                else if (ResRepeat < 1)
                {
                    Number2 = temp;
                }
                if(Op == Operation.Equal)
                Result = GetResult(Number1, Number2, prevOp);
                else
                    Result = GetResult(Number1, Number2, Op);
                label2.Text = Convert.ToString(Result);
            }
            Op = Operation.Equal;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bool Success;
            if (Op != Operation.None)
            {
                Success = double.TryParse(label2.Text, out double temp);
                if (Success)
                    Number1 = GetResult(Number1, temp, Op);
                else
                {
                    Op = Operation.Substract;
                    label1.Text = Number1 + GetOperator(Operation.Substract);
                    return;
                }
                Op = Operation.Substract;
            }
            else
            {
                Op = Operation.Substract;
                Success = double.TryParse(label2.Text, out Number1);
            }
            if (Success)
            {
                label1.Text = label2.Text + GetOperator(Operation.Substract);
                label2.Text = null;
            }
            ResRepeat = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool Success;
            if (Op != Operation.None)
            {
                Success = double.TryParse(label2.Text, out double temp);
                if (Success)
                    Number1 = GetResult(Number1, temp, Op);
                else
                {
                    Op = Operation.Multiply;
                    label1.Text = Number1 + GetOperator(Operation.Multiply);
                    return;
                }
                Op = Operation.Multiply;
            }
            else
            {
                Op = Operation.Multiply;
                Success = double.TryParse(label2.Text, out Number1);
            }
            if (Success)
            {
                label1.Text = label2.Text + GetOperator(Operation.Multiply);
                label2.Text = null;
            }
            ResRepeat = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bool Success;
            if (Op != Operation.None)
            {
                Success = double.TryParse(label2.Text, out double temp);
                if (Success)
                    Number1 = GetResult(Number1, temp, Op);
                else
                {
                    Op = Operation.Divide;
                    label1.Text = Number1 + GetOperator(Operation.Divide);
                    return;
                }
                Op = Operation.Divide;
            }
            else
            {
                Op = Operation.Divide;
                Success = double.TryParse(label2.Text, out Number1);
            }
            if (Success)
            {
                label1.Text = label2.Text + GetOperator(Operation.Divide);
                label2.Text = null;
            }
            ResRepeat = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Op == Operation.Equal)
            {
                button16_Click(sender, e);
                label2.Text = 0.ToString();
            }
            else
                label2.Text += 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Number1 = 0;
            Number2 = 0;
            label1.Text = null;
            label2.Text = null;
            ResRepeat = 0;
            Op = Operation.None;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!label2.Text.Contains("."))
                label2.Text += ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(label2.Text.Length > 0)
            {
                label2.Text = label2.Text.Substring(0, label2.Text.Length - 1);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                button1.BackColor = Color.Black;
                button1.ForeColor = Color.White;

                button2.BackColor = Color.Black;
                button2.ForeColor = Color.White;

                button3.BackColor = Color.Black;
                button3.ForeColor = Color.White;

                button4.BackColor = Color.Black;
                button4.ForeColor = Color.White;

                button5.BackColor = Color.Black;
                button5.ForeColor = Color.White;

                button6.BackColor = Color.Black;
                button6.ForeColor = Color.White;

                button7.BackColor = Color.Black;
                button7.ForeColor = Color.White;

                button8.BackColor = Color.Black;
                button8.ForeColor = Color.White;

                button9.BackColor = Color.Black;
                button9.ForeColor = Color.White;

                button10.BackColor = Color.Black;
                button10.ForeColor = Color.White;

                button11.BackColor = Color.Black;
                button11.ForeColor = Color.White;

                button12.BackColor = Color.Black;
                button12.ForeColor = Color.White;

                button13.BackColor = Color.Black;
                button13.ForeColor = Color.White;

                button14.BackColor = Color.Black;
                button14.ForeColor = Color.White;

                button15.BackColor = Color.Black;
                button15.ForeColor = Color.White;

                button16.BackColor = Color.Black;
                button16.ForeColor = Color.White;

                button17.BackColor = Color.Black;
                button17.ForeColor = Color.White;

                button18.BackColor = Color.Black;
                button18.ForeColor = Color.White;

                button19.BackColor = Color.Black;
                button19.ForeColor = Color.White;

                this.BackColor = Color.Black;

                label1.BackColor = Color.Black;
                label1.ForeColor = Color.White;

                label2.BackColor = Color.Black;
                label2.ForeColor = Color.White;
            }
            else
            {
                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;

                button2.BackColor = Color.White;
                button2.ForeColor = Color.Black;

                button3.BackColor = Color.White;
                button3.ForeColor = Color.Black;

                button4.BackColor = Color.White;
                button4.ForeColor = Color.Black;

                button5.BackColor = Color.White;
                button5.ForeColor = Color.Black;

                button6.BackColor = Color.White;
                button6.ForeColor = Color.Black;

                button7.BackColor = Color.White;
                button7.ForeColor = Color.Black;

                button8.BackColor = Color.White;
                button8.ForeColor = Color.Black;

                button9.BackColor = Color.White;
                button9.ForeColor = Color.Black;

                button10.BackColor = Color.White;
                button10.ForeColor = Color.Black;

                button11.BackColor = Color.White;
                button11.ForeColor = Color.Black;

                button12.BackColor = Color.White;
                button12.ForeColor = Color.Black;

                button13.BackColor = Color.White;
                button13.ForeColor = Color.Black;

                button14.BackColor = Color.White;
                button14.ForeColor = Color.Black;

                button15.BackColor = Color.White;
                button15.ForeColor = Color.Black;

                button16.BackColor = Color.White;
                button16.ForeColor = Color.Black;

                button17.BackColor = Color.White;
                button17.ForeColor = Color.Black;

                button18.BackColor = Color.White;
                button18.ForeColor = Color.Black;

                button19.BackColor = Color.White;
                button19.ForeColor = Color.Black;

                this.BackColor = Color.White;

                label1.BackColor = Color.White;
                label1.ForeColor = Color.Black;

                label2.BackColor = Color.White;
                label2.ForeColor = Color.Black;
            }
        }
    }
}
