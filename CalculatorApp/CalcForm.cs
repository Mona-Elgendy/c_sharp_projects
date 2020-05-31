using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalcForm : Form
    {
        private decimal firstNumber = 0.0m;
        private decimal secondNumber= 0.0m;
        private decimal resultDecimal = 0.0m;
        private string operatorString = "+" ;

        public CalcForm()
        {
            InitializeComponent();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            RemoveZero(0);
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            RemoveZero(1);
        }

        private void RemoveZero(int number)
        {
            if (CalcTextBox.Text == "0")
                CalcTextBox.Text = number.ToString();
            else
                CalcTextBox.Text += number.ToString();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            RemoveZero(2);
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            RemoveZero(3);
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            RemoveZero(4);
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            RemoveZero(5);
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            RemoveZero(6);
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            RemoveZero(7);
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            RemoveZero(8);
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            RemoveZero(9);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CalcTextBox.Clear();
            CalcTextBox.Text="0";
            firstNumber = 0.0m;
            secondNumber = 0.0m;
            resultDecimal = 0.0m;
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if(!CalcTextBox.Text.Contains("."))
            CalcTextBox.Text += ".";
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            SuppliedOperator("+");
        }

        private void SuppliedOperator(string _OperatorString)
        {
            operatorString = _OperatorString;
            firstNumber = decimal.Parse(CalcTextBox.Text);
            CalcTextBox.Text = "0";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            SuppliedOperator("-");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            SuppliedOperator("*");
            
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            SuppliedOperator("/");
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            secondNumber = decimal.Parse(CalcTextBox.Text);
            switch (operatorString)
            {
                case "+":
                    resultDecimal = firstNumber + secondNumber;
                    break;
                case "-":
                    resultDecimal = firstNumber - secondNumber;
                    break;
                case "*":
                    resultDecimal = firstNumber * secondNumber;
                    break;
                case "/":
                    resultDecimal = firstNumber / secondNumber;
                    break;
                case "%":
                    resultDecimal = firstNumber % secondNumber;
                    break;



            }

            CalcTextBox.Text = resultDecimal.ToString();
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            if (!CalcTextBox.Text.Contains("-"))
                CalcTextBox.Text = "-" + CalcTextBox.Text;
            else
            {
                CalcTextBox.Text = CalcTextBox.Text.Trim('-');
            }
        }

        private void PercentButton_Click(object sender, EventArgs e)
        {
            SuppliedOperator("%");
        }
    }
}
