using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedCalculator
{
    public partial class Calculator : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((result.Text == "0") ||(operation_pressed))
                result.Clear();
            operation_pressed = false;

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
            // result.Text = result.Text + "1" 
            // result.Text += "1"
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            equation.Text = "";
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            equation.Text = "";

            switch(operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;

                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;

                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;

                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }

            

        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }
    } 
}
