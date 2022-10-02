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
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(n1.Text);
                double num2 = Convert.ToDouble(n2.Text);
                double sum = num1 + num2;

                answer.Text = sum.ToString();
            }catch(Exception)
            {
                MessageBox.Show("Please enter valid Inputs");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(n1.Text);
                double num2 = Convert.ToDouble(n2.Text);
                double sub = num1 - num2;

                answer.Text = sub.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid Inputs");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                double num1 = Convert.ToDouble(n1.Text);
                double num2 = Convert.ToDouble(n2.Text);
                double mul = num1 * num2;
                answer.Text = mul.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid Inputs");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(n1.Text);
                double num2 = Convert.ToDouble(n2.Text);
                double div = num1 / num2;

                answer.Text = div.ToString();
            }catch(Exception)
            {
                MessageBox.Show("Please enter valid Inputs");
            }
            
        }
    }
}
