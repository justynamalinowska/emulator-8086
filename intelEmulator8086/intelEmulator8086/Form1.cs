using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intelEmulator8086
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var AH = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var BH = textBox1.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            var BL = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            var CL = textBox1.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var CH = textBox1.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            var DH = textBox1.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            var AL = textBox1.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            var CL = textBox1.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            var DL = textBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
