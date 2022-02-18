using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerevozkaTovarov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x1, x2, x3, x4, x5, p1, p2, p3, p4, p5, w1, w2, w3, w4, w5,
y1, y2, y3, y4, y5, st, max, tw;
            y1 = 0;
            y2 = 0;
            y3 = 0;
            y4 = 0;
            y5 = 0;
            p1 = Convert.ToInt32(textBox12.Text);
            p2 = Convert.ToInt32(textBox13.Text);
            p3 = Convert.ToInt32(textBox14.Text);
            p4 = Convert.ToInt32(textBox15.Text);
            p5 = Convert.ToInt32(textBox16.Text);
            w1 = Convert.ToInt32(textBox6.Text);
            w2 = Convert.ToInt32(textBox7.Text);
            w3 = Convert.ToInt32(textBox8.Text);
            w4 = Convert.ToInt32(textBox9.Text);
            w5 = Convert.ToInt32(textBox10.Text);
            max = 0;
            tw = Convert.ToInt32(textBox11.Text);
            for (x1 = 0; x1 <= 1; x1++)
                for (x2 = 0; x2 <= 1; x2++)
                    for (x3 = 0; x3 <= 1; x3++)
                        for (x4 = 0; x4 <= 1; x4++)
                            for (x5 = 0; x5 <= 1; x5++)
                                if (x1 * w1 + x2 * w2 + x3 * w3 + x4 * w4 + x5 * w5 <= tw)
                                {
                                    st = x1 * p1 + x2 * p2 + x3 * p3 + x4 * p4 + x5 * p5;
                                    if (st > max)
                                    {
                                        max = st; y1 = x1; y2 = x2; y3 = x3; y4 = x4; y5 = x5;
                                    }
                                }
            label6.Text = ((y1 > 0) ? "Перевозить" : "Не перевозить");
            label7.Text = ((y2 > 0) ? "Перевозить" : "Не перевозить");
            label8.Text = ((y3 > 0) ? "Перевозить" : "Не перевозить");
            label9.Text = ((y4 > 0) ? "Перевозить" : "Не перевозить");
            label10.Text = ((y5 > 0) ? "Перевозить" : "Не перевозить");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "---";
            textBox2.Text = "---";
            textBox3.Text = "---";
            textBox4.Text = "---";
            textBox5.Text = "---";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
