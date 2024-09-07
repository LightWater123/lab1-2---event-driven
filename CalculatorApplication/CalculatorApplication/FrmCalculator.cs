using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    
    public partial class FrmCalculator : Form
    {
        private CalculatorClass cal;

        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        public delegate T Formula<T>(T arg1, T arg2); // declare a generic delegate 

    public class CalculatorClass
    {
            public Formula<double> formula;

            // returns the sum
            public static double GetSum(double num1, double num2)
            {
                return num1 + num2;
            }
            // returns the difference
            public static double GetDifference(double num1, double num2)
            {
                return num1 - num2;
            }
            // returns the product
            public static double GetProduct(double num1, double num2)
            {
                return num1 * num2;
            }
            // returns the quotient
            public static double GetQuotient(double num1, double num2)
            {
                return num1 / num2;
            }

            // event accessor

            public event Formula<double> CalculateEvent
            {
                add
                {
                    Console.WriteLine("Added the delegate"); 
                }
                remove
                {
                    Console.WriteLine("Removed the delegate");
                }
            }
    }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                double num1, num2;
                // get the input from the textboxes and store it in a variable
                num1 = double.Parse(txtBoxInput1.Text);
                num2 = double.Parse(txtBoxInput2.Text);


                // validate the selected arithmetic operator in the cb, then display the answer in a label
                if (cbOperator.SelectedIndex == 0) // addition
                {
                    cal.CalculateEvent += new Formula<double>(CalculatorClass.GetSum);
                    lblDisplayTotal.Text = CalculatorClass.GetSum(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(CalculatorClass.GetSum);

                }
                else if(cbOperator.SelectedIndex == 1) // subtraction
                {
                    cal.CalculateEvent += new Formula<double>(CalculatorClass.GetDifference);
                    lblDisplayTotal.Text = CalculatorClass.GetDifference(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(CalculatorClass.GetDifference);

                }
                else if (cbOperator.SelectedIndex == 2) // multiplication
                {
                    cal.CalculateEvent += new Formula<double>(CalculatorClass.GetProduct);
                    lblDisplayTotal.Text = CalculatorClass.GetProduct(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(CalculatorClass.GetProduct);

                }
                else if (cbOperator.SelectedIndex == 3) // division
                {
                    cal.CalculateEvent += new Formula<double>(CalculatorClass.GetQuotient);
                    lblDisplayTotal.Text = CalculatorClass.GetQuotient(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(CalculatorClass.GetQuotient);

                }

                /*// reset calculations

                txtBoxInput1.Clear();
                txtBoxInput2.Clear();
                cbOperator.SelectedIndex = -1;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill in the numbers","NOTICE");
            }
        }
    }
}