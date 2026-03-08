using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MODUL3_103022430004
{
    public partial class Form1 : Form
    {
        private double totalResult = 0;
        private bool isNewInput = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Angka(string digit)
        {
            if (isNewInput)
            {
                label1.Text = digit;
                isNewInput = false;
            }
            else
            {
                if (label1.Text == "0")
                    label1.Text = digit;
                else
                    label1.Text += digit;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Angka("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Angka("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Angka("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Angka("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Angka("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Angka("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Angka("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Angka("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Angka("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Angka("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            totalResult += double.Parse(label1.Text);
            label1.Text = totalResult.ToString();
            totalResult = 0;
            isNewInput = true;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            totalResult += double.Parse(label1.Text);
            isNewInput = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
    }
}
