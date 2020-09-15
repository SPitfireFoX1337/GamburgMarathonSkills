using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kartSkills
{
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //Создаем новый экземпляр типа DateTime для хранения время начала события
            DateTime finishdate = new DateTime(2020, 10, 1, 9, 0, 0);
            //Вычисляем текущее время и время начала события
            TimeSpan result = finishdate - DateTime.Now;
            /*
             Проверяем условие, если finishdate (время начало события) меньше или равно текущей дате и времени (берется из компьютера), 
             то выводится сообщение что "Событие уже началось", если нет то отображаем счетчик
             */
            if (finishdate <= System.DateTime.Now)
            {
                // В элемент Label (с индификатором l_timer) в свойство Text добавляем сообщение Событие уже началось
                l_timer.Text = "Событие уже началось";
            }
            else
            {
                // В элемент Label (с индификатором l_timer) в свойство Text добавляем сообщение, которое так же принимается переменную result для отображениядаты и времени
                l_timer.Text = "До события осталось: " + result.Days + " дней " + result.Hours + " часов " + result.Minutes + " минут " + result.Seconds + " секунд";
            }
        }
    }
}
