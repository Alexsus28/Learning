using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testpoarifmetice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            label1.Text = Convert.ToString(rnd.Next(0, 100));
            label5.Text = Convert.ToString(rnd.Next(0, 100));
            label2.Text = Convert.ToString(rnd.Next(0, 100));
            label6.Text = Convert.ToString(rnd.Next(0, 100));
            label3.Text = Convert.ToString(rnd.Next(0, 10));
            label7.Text = Convert.ToString(rnd.Next(0, 10));
            label8.Text = Convert.ToString(rnd.Next(1, 10));
            label4.Text = Convert.ToString(rnd.Next(1, 10) * Convert.ToInt32(label8.Text));
            label14.Text = "60";
            label13.Text = "--";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            timer1.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label14.Text = Convert.ToString(Convert.ToInt32(label14.Text) - 1);
            if (label14.Text == "0")
            {
                timer1.Enabled = false;
                button2_Click(button2, e);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String s1, s2, s3, s4;
            button1.Enabled = true;
            button2.Enabled = false;
            label13.Text = "5";
            label9.Text = "Правильно";
            label10.Text = "Правильно";
            label11.Text = "Правильно";
            label12.Text = "Правильно";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            s1 = Convert.ToString(Convert.ToInt32(label1.Text) + Convert.ToInt32(label5.Text));
            s2 = Convert.ToString(Convert.ToInt32(label2.Text) - Convert.ToInt32(label6.Text));
            s3 = Convert.ToString(Convert.ToInt32(label3.Text) * Convert.ToInt32(label7.Text));
            s4 = Convert.ToString(Convert.ToInt32(label4.Text) / Convert.ToInt32(label8.Text));
            if (textBox1.Text != s1)
            {
                label9.Text = "Ошибка";
                label13.Text = Convert.ToString(Convert.ToUInt32(label13.Text) - 1);
            }
            if (textBox2.Text != s2)
            {
                label10.Text = "Ошибка";
                label13.Text = Convert.ToString(Convert.ToInt32(label13.Text) - 1);
            }
            if (textBox3.Text != s3)
            {
                label11.Text = "Ошибка";
                label13.Text = Convert.ToString(Convert.ToInt32(label13.Text) - 1);
            }
            if (textBox4.Text != s4)
            {
                label12.Text = "Ошибка";
                label13.Text = Convert.ToString(Convert.ToInt32(label13.Text) - 1);
            }
            timer1.Enabled = false;
        }
    }
};
