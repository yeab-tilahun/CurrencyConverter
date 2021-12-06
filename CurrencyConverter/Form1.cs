using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Enter(object sender, EventArgs e)
        {
            double a, result,check;
            int combo;
            combo = Convert.ToInt32(comboBox1.SelectedIndex);
            check = Convert.ToDouble(textBox1.Text);
            string test = textBox1.Text;
            // textBox1.Text= Convert.ToString(comboBox1.SelectedItem);
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please enter any valid amount!");
            }
            else if (combo == -1)
            {
                MessageBox.Show("Please choose a currency!");
            }
            else if (check<0)
            {
                MessageBox.Show("Please enter a valid amount!");
            }
            else
            {
                if (combo == 0)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    result = a * 43;
                    textBox2.Text = Convert.ToString(result);
                }
                else if (combo == 1)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    result = a * 54.33;
                    textBox2.Text = Convert.ToString(result);
                }
                else if (combo == 2)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    result = a * 7.53;
                    textBox2.Text = Convert.ToString(result);
                }
                else if (combo == 3)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    result = a * 37.37;
                    textBox2.Text = Convert.ToString(result);
                }
                else if (combo == 4)
                {
                    a = Convert.ToDouble(textBox1.Text);
                    result = a * 63.54;
                    textBox2.Text = Convert.ToString(result);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}
