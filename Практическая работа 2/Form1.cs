using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lb_2;

namespace Практическая_работа_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Очистить
        private void button2_Click(object sender, EventArgs e)
        {
            table.ColumnCount = 5;
            table.RowCount = 1;
            kolvo1.Value = 5;
            for (int i = 0; i < table.ColumnCount; i++)
                    table[i, 0].Value = " ";
            rez.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.ColumnCount = 5;
            table.RowCount = 1;
        }
        //Кол-во колонок
        private void kolvo_ValueChanged(object sender, EventArgs e)
        {
            table.ColumnCount = Convert.ToInt32(kolvo1.Value);//Кол-во столбцов
        }
        //Выход
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Заполнить
        private void button4_Click(object sender, EventArgs e)
        {
            int RandMax = Convert.ToInt32(diapozon.Value);
            Random Rand = new Random();
            for (int i = 0; i < table.ColumnCount; i++)              
                    table[i, 0].Value = Rand.Next(RandMax);
        }
        //расчёт
        private void button1_Click(object sender, EventArgs e)
        {
            int sum=Lb_2.Class1.Find(table);
            rez.Text = sum.ToString();
        }
        //О программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа № 2, 12 вариант\n" +
                "Ввести n целых чисел. Найти сумму чисел >15. Результат вывести на экран.\n" +
                "Платов Андрей ИСП-31");
        }           
    }
}
