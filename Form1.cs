using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursvalut_praktuchna_chumak
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
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "=>";
            textBox3.Enabled = false;
            textBox4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kurs1, kurs2, sum, sum_out;
            kurs1 = double.Parse(textBox1.Text);
            kurs2 = double.Parse(textBox2.Text);
            if (radioButton1.Checked == true)
            {
                textBox4.Enabled = true;
                sum = double.Parse(textBox3.Text);
                sum_out = sum * kurs1;
                textBox4.Text = sum_out.ToString();
            }
            if (radioButton2.Checked == true)
            {
                textBox3.Enabled = true;
                textBox3.Clear();

                sum = double.Parse(textBox4.Text);
                sum_out = sum / kurs2;
                textBox3.Text = sum_out.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "<=";
            textBox3.Enabled = true;
            textBox4.Enabled = false;
        }

       
    }
}
