using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UgadaiChislo
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

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		int Ch;
		private void button1_Click(object sender, EventArgs e)
		{
			Random rnd = new Random(DateTime.Now.Millisecond);
			//объявляем генератор псевдослучайных чисел и указываем для него свойство DateTime.Now.Millisecond, при помощи которого возможно избежать повторения случайных чисел;
			try //оператор try-catch служит для обработки различных исключений ;
			{
				Ch = rnd.Next(1, System.Convert.ToInt32(textBox1.Text));// данный метод возвращает случайное число в указанный диапазон;
			}
			catch // при возникновении исключения оператор Catch обрабатывает это исключение;
			{
				MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); // было вызвано исключение → выводится сообщение об ошибке; 
				return; // Выполнение метода при ошибке прекращается; 
			}
			button1.Enabled = false;//так как максимальное загадываемое число мы определили, кнопка «Загадать» нам уже не понадобится, значит ее можно заблокировать;
			button2.Enabled = true;// все остальные кнопки останутся доступными на данном этапе
			button3.Enabled = true;
			textBox2.Enabled = true;
			textBox2.Focus(); // Метод  Focus  предоставляет фокус ввода указанному элементу;
		
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int x; // объявляем переменную  X типа Integer для данной процедуры;
			x = Convert.ToInt32(textBox4.Text); // конвертируем текст в TextBox , после произведенной конвертации записываем этот текст в переменную Х;
			textBox4.Text = Convert.ToString(x + 1); //увеличиваем переменную X на 1, так как число попыток при каждой попытке угадать увеличивается;
			if (Convert.ToInt32(textBox2.Text) == Ch) // если предполагаемое число совпадает с загаданным числом;
			{
				textBox3.Text = "Угадал"; // в поле textBox3 («Результат») появится значение «Угадал»;
			}
			else if (Convert.ToInt32(textBox2.Text) > Ch) //если предполагаемое число больше загадываемого числа;
			{
				textBox3.Text = "Перелет"; //в поле textBox3(«Результат») появится значение «Перелет»;
			}
			else // если предполагаемое число меньше загадываемого числа;

			{
				textBox3.Text = "Недолет"; // в поле textBox3 («Результат») появится значение «Недолет»;
			}

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			Ch = 0; // загадываемое число станет равным 0;
			textBox1.Text = "0"; // значение в поле «Максимальное загадываемое число» станет равным 0;  
			textBox2.Text = "0"; // значение в поле «Предполагаемое число» станет равным 0;
			textBox3.Text = " "; // значение в поле «Результат» станет пустым;
			textBox4.Text = "0"; // значение в поле «Число попыток» станет равным 0; 
			button1.Enabled = true; // кнопка «Загадать» станет доступной;
			button2.Enabled = false; // остальные кнопки заблокируются;
			button3.Enabled = false;
			textBox2.Enabled = false;
			textBox1.Focus();// при помощи метода фокус в textBox1 устанавливается каретка ввода;
			

			}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar) == true) return; //если  введенный символ является числом, то происходим выход из процедуры;
			if (e.KeyChar == (char)Keys.Back) return; // если пользователь нажал на клавишу Backspace, то выходим из процедуры; 
			e.Handled = true;// обход обработки элемента, если введенный символ является буквой;

		}
	}
}
