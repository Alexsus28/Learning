using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagramma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear(); //очищаем поле диаграммы 

            chart1.Series[0].Points.Add(Convert.ToInt32(numericUpDown1.Value)); // создаем первый сектор с размером, соответсвующим параметру Value объекта numericUpDown1;
            chart1.Series[0].Points.Add(Convert.ToInt32(numericUpDown2.Value)); // создаем второй сектор с размером, соответсвующим параметру Value объекта numericUpDown2;
            chart1.Series[0].Points.Add(Convert.ToInt32(numericUpDown3.Value)); // создаем третий сектор с размером, соответсвующим параметру Value объекта numericUpDown3;
            chart1.Series[0].Points.Add(Convert.ToInt32(numericUpDown4.Value)); //создаем четвертый сектор с размером, соответсвующим параметру Value объекта numericUpDown4
            chart1.Series[0].Points.Add(Convert.ToInt32(numericUpDown5.Value)); // создаем пятый сектор с размером, соответсвующим параметру Value объекта numericUpDown5;

            chart1.Series[0].Points[0].Color = Color.Red; // красим первый сектор в красный цвет;
            chart1.Series[0].Points[0].LegendText = label1.Text; // указываем название сектора в легенде;
            chart1.Series[0].Points[1].Color = Color.Black;      // красим второй сектор в черный цвет
            chart1.Series[0].Points[1].LegendText = label2.Text; // указываем название сектора в легенде;
            chart1.Series[0].Points[2].Color = Color.Green; // красим третий сектор в зеленый цвет;
            chart1.Series[0].Points[2].LegendText = label3.Text; // указываем название сектора в легенде;
            chart1.Series[0].Points[3].Color = Color.Yellow;  // красим четвертый сектор в желтый цвет;
            chart1.Series[0].Points[3].LegendText = label4.Text; //указываем название сектора в легенде;
            chart1.Series[0].Points[4].Color = Color.Pink; // красим пятый сектор в  розовый цвет;
            chart1.Series[0].Points[4].LegendText = label5.Text; // указываем название сектора в легенде;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear(); // очищаем поле диаграммы
            numericUpDown1.Value = 0; // присваиваем объекту numericUpDown1 значение 0;
            numericUpDown2.Value = 0; // присваиваем объекту numericUpDown2 значение 0;
            numericUpDown3.Value = 0; // присваиваем объекту numericUpDown3 значение 0;
            numericUpDown4.Value = 0; // присваиваем объекту numericUpDown4 значение 0 ;
            numericUpDown5.Value = 0; // присваиваем объекту numericUpDown5 значение 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
