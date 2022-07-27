using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        
        public Form1()
        {
            InitializeComponent();
        }
        private void button_click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            textBox.Text = textBox.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox.Text);
            labelCurrentOperation.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }


        private void buttonEqual_click(object sender, EventArgs e)
        {
            textBox.Text = Convert.ToString(resultValue);

            switch(operationPerformed)
            {
                case "+":
                    textBox.Text = (resultValue + Double.Parse(textBox.Text)).ToString();
                    break;

                case "-":
                    textBox.Text = (resultValue - Double.Parse(textBox.Text)).ToString();
                    break;

                case "*":
                    textBox.Text = (resultValue * Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (resultValue / Double.Parse(textBox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }


        private void buttonDot_Click(object sender, EventArgs e)
        {
            

        }






        private void buttonc_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void buttonce_Click(object sender, EventArgs e)
        {

            textBox.Text = "0";
            resultValue = 0; 
        }
    }
}
