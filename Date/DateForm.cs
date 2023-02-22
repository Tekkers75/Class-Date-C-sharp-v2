/// @author Саранчин К.А.
/// Обработчики событий
/// 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WindowsFormsAppDate1;

namespace AppDate
{

    public partial class FormDate : Form
    {

        /// Ссылки на объекты
        Date Date1 = new Date();
        Date Date2 = new Date();
        Date Date3 = new Date();

        /// Конструктор форм
        public FormDate()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 239, 219);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int CheckDate1()
        {
            int chet = 0;
            if (Convert.ToInt32(textBoxDay.Text) < 0 || (Convert.ToInt32(textBoxDay.Text) > 31))
            {
                textBoxDay.BackColor = Color.Red;
                chet++;
                textBoxError.Text = "Некорректно задан день";
            }
            else textBoxDay.BackColor = Color.White;


            if (Convert.ToInt32(textBoxMonth.Text) < 0 || (Convert.ToInt32(textBoxMonth.Text) > 12))
            {
                textBoxMonth.BackColor = Color.Red;
                chet++;
                textBoxError.Text = "Некорректно задан месяц";
            }
            else textBoxMonth.BackColor = Color.White;

            if (Convert.ToInt32(textBoxYear.Text) < 0)
            {
                textBoxYear.BackColor = Color.Red;
                chet++;
                textBoxError.Text = "Некорректно задан год";
            }
            else textBoxYear.BackColor = Color.White;

            if (Convert.ToInt32(textBoxResult1.Text) < 0)
            {
                textBoxResult1.BackColor = Color.Red;
                chet++;
                textBoxError.Text = "Некорректно заданы дни";
            }
            else textBoxResult1.BackColor = Color.White;

            return chet;
        }

        private int CheckDate2()
        {
            int chet = 0;

            if (Convert.ToInt32(textBoxDay2.Text) < 0 || (Convert.ToInt32(textBoxDay2.Text) > 31))
            {
                textBoxDay2.BackColor = Color.Red;
                chet++;
                textBoxError.Text = "Некорректно задан день";
            }
            else textBoxDay2.BackColor = Color.White;


            if (Convert.ToInt32(textBoxMonth2.Text) < 0 || (Convert.ToInt32(textBoxMonth2.Text) > 12))
            {
                textBoxMonth2.BackColor = Color.Red;
                chet++;
                textBoxError.Text = "Некорректно задан месяц";
            }
            else textBoxMonth2.BackColor = Color.White;

            if (Convert.ToInt32(textBoxYear2.Text) < 0)
            {
                textBoxYear2.BackColor = Color.Red;
                chet++;
                textBoxError.Text = "Некорректно задан год";
            }
            else textBoxYear2.BackColor = Color.White;

            return chet;
        }


        /// Задаем даты
        private void SetDate()
        {
            try
            {
                Date1.SetDay(Convert.ToInt32(textBoxDay.Text));
                Date1.SetMonth(Convert.ToInt32(textBoxMonth.Text));
                Date1.SetYear(Convert.ToInt32(textBoxYear.Text));
                Date2.SetDay(Convert.ToInt32(textBoxDay2.Text));
                Date2.SetMonth(Convert.ToInt32(textBoxMonth2.Text));
                Date2.SetYear(Convert.ToInt32(textBoxYear2.Text));
            }
            catch (ArgumentException er)
            {
                textBoxError.Text = er.Message;
            }
        }

        /// Перевод даты в дни
        private void buttonConvertDate_Click(object sender, EventArgs e)
        {

            if (CheckDate1() == 0)
            {
                SetDate();
                textBoxResult1.Text = Date1.ConvertDate().ToString();
                textBoxError.Text = "Информация";
            }

        }



        /// Перевод дней в дату
        private void buttonSetDateInDay_Click(object sender, EventArgs e)
        {
            if (CheckDate1() == 0)
            {
                Date1.SetDateInDay(Convert.ToInt32(textBoxResult1.Text));
                textBoxYear.Text = Date1.GetYear().ToString();
                textBoxMonth.Text = Date1.GetMonth().ToString();
                textBoxDay.Text = Date1.GetDay().ToString();
                textBoxError.Text = "Информация";
            }
        }




        /// Сложение даты
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if ((CheckDate1() == 0) || (CheckDate2() == 0))
            {
                SetDate();
                Date3.CalcDay(Date1, Date2);
                textBoxResultAll.Text = " New date = " + "\n" + Date2.GetDay().ToString() + " days " + Date2.GetMonth().ToString() +
                    " month " + Date2.GetYear().ToString() + " year ";
                textBoxError.Text = "Информация";
            }
        }

        /// Вычитание даты
        private void buttonSub_Click(object sender, EventArgs e)
        {
            if ((CheckDate1() == 0) || (CheckDate2() == 0))
            {
                SetDate();
                Date3.SubDate(Date1, Date2);
                textBoxResultAll.Text = " New sub date = " + "\n" + Date2.GetDay().ToString() + " days " + Date2.GetMonth().ToString() +
                    " month " + Date2.GetYear().ToString() + " year ";
                textBoxError.Text = "Информация";
            }

        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Саранчин Константин Александрович" + "\nВМК-21", "Автор");
        }

        private void инструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" -В дни вводятся положительные числа, от 0 до 31"
                           + "\n -В месяца вводятся положительные числа, от 0 до 12"
                           + "\n -В года вводятся положительные числа, от 0"
                           + "\n -В общее кол-во дней вводятся положительные числа, от 0"
                           + "\n -Сложение происходит к первой дате, прибавляется вторая"
                           + "\n -Вычитание происходит от первой даты, вычитается вторая"
                           + "\n -Ответ записывается новой датой "
                           + "\n -В поле информация выводятся ошибки"
                           + "\n -Ошибки указывается поочередно, от Год - Месяц - День", "Инструкция");
        }
    }
}
