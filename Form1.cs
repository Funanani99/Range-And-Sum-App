using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_And_Sum_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Program 6: Check if values are in range
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = int.Parse(txtNum3.Text);
            bool result = CheckInRange(num1, num2, num3);
            lblRangeResult.Text = "Result: " + result;
        }

        private bool CheckInRange(int num1, int num2, int num3)
        {
            return (num1 >= 20 && num1 <= 50) ||
                   (num2 >= 20 && num2 <= 50) ||
                   (num3 >= 20 && num3 <= 50);
        }

        // Program 10: Sum or return third
        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = int.Parse(txtNum3.Text);
            int result = SumOrReturnThird(num1, num2, num3);
            label5.Text = "Result: " + result;
        }

        private int SumOrReturnThird(int num1, int num2, int num3)
        {
            if (num1 == num2)
            {
                return num3;
            }
            else if (num1 == num3)
            {
                return num2;
            }
            else if (num2 == num3)
            {
                return num1;
            }
            else
            {
                return num1 + num2 + num3;
            }
        }
    }

}
