using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secundomer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int h;
		int m;
		int s;

		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Enabled = true;
			button1.Enabled = false;
			button2.Enabled = true;
			button3.Enabled = true;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			button1.Enabled = true;
			button2.Enabled = false;
			button3.Enabled = true;

		}

		private void button3_Click(object sender, EventArgs e)
		{
			h = 0; m = 0; s = 0;
			label4.Text = "0";
			label5.Text = "0";
			label6.Text = "0";
			button2_Click(sender, e); // Событие Click вызывается при нажатии элемента управления Button;

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			s = s + 1;// происходит суммирование пройденных секунд при включенном таймере;
			if (s > 59)
			{
				m = m + 1; // если количество пройденных секунд превысило 59, начинается подсчет минут;
				s = 0; // количество секунд приравнивается к 0, так как секундомер начинает отсчитывать их снова;
			}
			if (m > 59)
			{
				h = m + 1; // если количество пройденных минут превысило 59, начинается подсчет часов 
				m = 0; // количество минут приравнивается к нулю
			}
			label4.Text = Convert.ToString(h);
			label5.Text = Convert.ToString(m);
			label6.Text = Convert.ToString(s);
		}
		private void button4_Click(object sender, EventArgs e) // кнопка «Выход»
		{
			
		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

